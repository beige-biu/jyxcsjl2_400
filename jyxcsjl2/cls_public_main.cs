using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Collections;
using System.Security.Cryptography;
using System.Drawing;
using DevExpress.XtraEditors;

namespace jyxcsjl2
{
	/// <summary>
	/// cls_public_main ��ժҪ˵����
	/// </summary>

	public class cls_public_main
	{	
		public static int IRON_NO_LENGTH=8;//���κų���
		public const string RZMESDB = "RZMESDB.udl";//�������ݿ�
        public const string RZW9DB = "RZW9DB.udl";//�������ݿ�
        public const string RZW9RTDB = "RZW9DB.udl";
        public static string RZMESDB_CONSTR = "";//�������ݿ�
        public static string RZW9DB_CONSTR = "User Id = ORALTL2_ST; Password=oraltl2_400s;Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 172.16.8.16)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = ORALTL2)))";//��������
        public static string RZW9RTD_CONSTR = "";
        public static DataTable t_group_auhority = new DataTable();
        
        private static int m_bRecordLog=1;//�Ƿ��¼��־
		private static string m_strOldLog="";
	
		public static string m_strConnectL2="";
		public static string m_strConnectL2Mode="";
		public static string m_strConnectCenter="";
		public static string m_strEventCase="";//�¼���Ϣ

        /// <summary>
        /// �û�ID ����
        /// </summary>
        public static string m_strUserID = "";
        /// <summary>
        /// �û���
        /// </summary>
		public static string m_strUserName = "";
        /// <summary>
        /// �û���ɫ
        /// </summary>
        public static string m_strRoleName = "admin";

        public static bool bReStart = false;

        public static string m_team = "0";
        public static string m_strSHIFTID = "0";
        public static string m_emp = "0";
        public static string m_emp_name = "0";
        public static string login_time;
        public static string exit_time;


        public const int LOG_TYPE_SYSTEM = 2;
        public const int LOG_TYPE_OPERATE = 1;
        public const int LOG_TYPE_ERROR = 0;

        /// <summary>
        /// �û�Ȩ��
        /// </summary>
        public static List<MODEL.T_SYS_FUNCTION1> userFunc;

        #region//���ݿ����
        private static OleDbConnection		m_connect = new OleDbConnection();
		private static OleDbCommand		m_command = new OleDbCommand();
        #endregion
        /// <summary>
        /// ����EXECL·��ѡ��
        /// </summary>
        public static string to_path()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.ShowDialog();
            string path = saveFileDialog.FileName;
            return path;
        }
		public cls_public_main()
		{
			
		}

		#region //��ʼ����־�ļ�
		public static void Initialize()
		{

            m_strEventCase = "CASE SUBSTRING(EventCode,3,2) WHEN '01' THEN '��ˮ�����ﴦ��λ' WHEN '02' THEN '����ʼ' ";
			m_strEventCase+="WHEN '03' THEN '�������' WHEN '04' THEN '����' WHEN '05' THEN 'ȡ��' ";
			m_strEventCase+="WHEN '06' THEN '��ˮ���뿪' WHEN '10' THEN '�����ж�' ";
            m_strEventCase += "END AS  �����¼�";
		}
		#endregion

		#region �����дini�ļ���API����

		[DllImport("kernel32")]
		public static extern int GetPrivateProfileString(string section,string Key,string def,StringBuilder retVal,int size,string filePath);
		[DllImport("kernel32")]
		public static extern int GetPrivateProfileInt(string section,string key,int val,string filePath);
		[DllImport("kernel32")]
		public static extern int WritePrivateProfileString(string section,string key,string val,string filePath);
			
		#endregion

		#region ReadIni()��ini�ļ��ж�ȡϵͳ������Ϣ 
		public static string ReadDeviceID()
		{
			string path = System.IO.Directory.GetCurrentDirectory();
			string strIniName = path +"\\config.ini";
			StringBuilder temp = new StringBuilder(1024);
			GetPrivateProfileString("DEVICE","ID","B2",temp,temp.MaxCapacity,strIniName);
			return temp.ToString();
		}
        public static string Readrep(string repfile)
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            string strIniName = path + "\\" + repfile;
            return strIniName.ToString();
            //StringBuilder temp = new StringBuilder(1024);
            // GetPrivateProfileString("DEVICE", "ID", "B2", temp, temp.MaxCapacity, strIniName);
            // return temp.ToString();
        }
        public static int ReadConfig(string section,string key)
		{
			string path = System.IO.Directory.GetCurrentDirectory();
			string strIniName = path +"\\config.ini";
			//string strIniName = "config.ini";
			return GetPrivateProfileInt(section,key,0,strIniName);
		}
		#endregion

		#region ReadUdl()��udl�ļ��ж�ȡ���ݿ������ַ��� 
		public static string ReadUdl(string strUDL)
		{
			string ConnString = "";
			if(strUDL == "")
			{
				ConnString = "";
			}
			else
			{
				try
				{
					StreamReader sr = new StreamReader(strUDL);
					sr.ReadLine();
					if(sr.ToString() !="")
					{
						sr.ReadLine();
						ConnString = sr.ReadLine();
                        //if(( ConnString.IndexOf("SQLOLEDB") == -1)&&(ConnString.IndexOf("MSDAORA") == -1))
                        //{
                        //    ConnString = "";
                        //}
                        //else
                        //{
                        //    //	int istart = ConnString.IndexOf(";");
                        //    //	ConnString = ConnString.Substring(istart+1);
                        //}
					}
					else
					{
						ConnString = "";
					}
					sr.Close();
                    sr = null;
				}
				catch
				{
					MessageBox.Show("ϵͳ���ݿ�����ʧ�ܣ�����udl�ļ������ã�","����",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				

			}
			return ConnString;

		}

		public static string ReadUdl2(string strUDL)//���Ӷ���ϵͳ
		{
			string FileName=strUDL;
			string ConnString = "";

			if(FileName == "")
			{
				ConnString = "UnConnected";
			}
			else
			{
				try
				{
					StreamReader sr = new StreamReader(FileName);
					sr.ReadLine();
					if(sr.ToString() !="")
					{
						sr.ReadLine();
						ConnString = sr.ReadLine();
						if( ConnString.IndexOf("SQLOLEDB") == -1)
						{
							ConnString = "UnConnected";
						}
						else
						{
							//	int istart = ConnString.IndexOf(";");
							//	ConnString = ConnString.Substring(istart+1);
						}
					}
					else
					{
						ConnString = "UnConnected";
					}
				}
				catch
				{
					MessageBox.Show("ϵͳ���ݿ�����ʧ�ܣ�����udl�ļ������ã�","����",MessageBoxButtons.OK,MessageBoxIcon.Error);

				}

			}

			return ConnString;

		}
		#endregion

		#region ReadUdl_L2()��udl�ļ��ж�ȡ�������ݿ������ַ��� 
		public static string ReadUdl_L2()
		{
			if(m_strConnectL2=="")
			{
				m_strConnectL2=ReadUdl(RZW9DB);
			}
			return m_strConnectL2;
		}
		#endregion

        public static void auhority()
        {
            string sql = "SELECT  t_group_auhority.authority_name, t_group_auhority.select_authorty, t_group_auhority.updata_authorty " +
                         " FROM t_user INNER JOIN t_group_auhority ON t_user.group_id = t_group_auhority.group_id " +
                         " where t_user.user_id = " +cls_public_main.m_strUserID;
            t_group_auhority.Clear();
            t_group_auhority = cls_public_main.ExecuteQuery(RZW9DB_CONSTR, sql);
        }

        public static string get_team()
        {
            using (jyxcsjl2.MODEL.T_USER db = new jyxcsjl2.MODEL.T_USER())
            {

                var systime = db.Database.SqlQuery<string>(" SELECT F_GET_CLASS_NAME(SYSDATE) FROM DUAL ").FirstAsync();
                return systime.Result.ToString();
            }
        }

        public static string get_shift()
        {
            using (jyxcsjl2.MODEL.T_USER db = new jyxcsjl2.MODEL.T_USER())
            {
                var systime = db.Database.SqlQuery<string>(" SELECT f_get_shift_id(TO_CHAR(SYSDATE,'YYYY-MM-DD HH24:MI:SS')) FROM DUAL ").FirstAsync();
                if (systime.Result.ToString() == "1")
                {
                    return "ҹ��";
                }
                else if (systime.Result.ToString() == "0")
                {
                    return "�װ�";
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// ����Ȩ�޿���
        /// </summary>
        /// <param name="control">�û�����</param>
        /// <param name="addBtns">��Ӱ���</param>
        /// <param name="updateBtns">�޸İ���</param>
        /// <param name="delBtns">ɾ������</param>
        /// <param name="sendBtns">���Ͱ���</param>
        /// <param name="receiveBtns">���հ���</param>
        /// <returns></returns>
        public static MODEL.T_SYS_FUNCTION1 ButtonControl(UserControl control, List<SimpleButton> addBtns, List<SimpleButton> updateBtns,
            List<SimpleButton> delBtns, List<SimpleButton> sendBtns, List<SimpleButton> receiveBtns)
        {
            MODEL.T_SYS_FUNCTION1 func = new MODEL.T_SYS_FUNCTION1();
            try
            {
                func = cls_public_main.userFunc.Find(t => t.FUNCTION_FORM == control.GetType().Name);
                //���Ȩ��
                if (addBtns != null)
                {
                    if (1 == func.FUNCTION_ADD)
                    {
                        foreach (SimpleButton button in addBtns)
                        {
                            button.Enabled = true;
                        }
                    }
                    else
                    {
                        foreach (SimpleButton button in addBtns)
                        {
                            button.Enabled = false;
                        }
                    }
                }

                //�޸�Ȩ��
                if (updateBtns != null)
                {
                    if (1 == func.FUNCTION_UPDATE)
                    {
                        foreach (SimpleButton button in updateBtns)
                        {
                            button.Enabled = true;
                        }
                    }
                    else
                    {
                        foreach (SimpleButton button in updateBtns)
                        {
                            button.Enabled = false;
                        }
                    }
                }

                //ɾ��Ȩ��
                if (delBtns != null)
                {
                    if (1 == func.FUNCTION_DEL)
                    {
                        foreach (SimpleButton button in delBtns)
                        {
                            button.Enabled = true;
                        }
                    }
                    else
                    {
                        foreach (SimpleButton button in delBtns)
                        {
                            button.Enabled = false;
                        }
                    }
                }

                //����Ȩ��
                if (sendBtns != null)
                {
                    if (1 == func.FUNCTION_SEND)
                    {
                        foreach (SimpleButton button in sendBtns)
                        {
                            button.Enabled = true;
                        }
                    }
                    else
                    {
                        foreach (SimpleButton button in sendBtns)
                        {
                            button.Enabled = false;
                        }
                    }
                }

                //����Ȩ��
                if (receiveBtns != null)
                {
                    if (1 == func.FUNCTION_RECEIVE)
                    {
                        foreach (SimpleButton button in receiveBtns)
                        {
                            button.Enabled = true;
                        }
                    }
                    else
                    {
                        foreach (SimpleButton button in receiveBtns)
                        {
                            button.Enabled = false;
                        }
                    }
                }

                return func;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ȩ������ " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Ȩ�޿���
        /// </summary>
        /// <param name="control">�û�����</param>
        /// <param name="addBtns">��Ӱ���</param>
        /// <param name="updateGrid">�޸�grid</param>
        /// <param name="delBtns">ɾ������</param>
        /// <param name="sendBtns">���Ͱ���</param>
        /// <param name="receiveBtns">���հ���</param>
        /// <returns></returns>
        public static MODEL.T_SYS_FUNCTION1 FuncControl(UserControl control, List<SimpleButton> addBtns, List<DevExpress.XtraGrid.Views.Grid.GridView> updateGrids,
            List<SimpleButton> delBtns, List<SimpleButton> sendBtns, List<SimpleButton> receiveBtns)
        {
            MODEL.T_SYS_FUNCTION1 func = new MODEL.T_SYS_FUNCTION1();
            try
            {
                func = cls_public_main.userFunc.Find(t => t.FUNCTION_FORM == control.GetType().Name);
                //���Ȩ��
                if (addBtns != null)
                {
                    if (1 == func.FUNCTION_ADD)
                    {
                        foreach (SimpleButton button in addBtns)
                        {
                            button.Enabled = true;
                        }
                    }
                    else
                    {
                        foreach (SimpleButton button in addBtns)
                        {
                            button.Enabled = false;
                        }
                    }
                }

                //�޸�Ȩ��
                if (updateGrids != null)
                {
                    if (1 == func.FUNCTION_UPDATE)
                    {
                        foreach (DevExpress.XtraGrid.Views.Grid.GridView updateGrid in updateGrids)
                        {
                            updateGrid.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
                        }
                    }
                    else
                    {
                        foreach (DevExpress.XtraGrid.Views.Grid.GridView updateGrid in updateGrids)
                        {
                            updateGrid.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
                        }
                    }
                }

                //ɾ��Ȩ��
                if (delBtns != null)
                {
                    if (1 == func.FUNCTION_DEL)
                    {
                        foreach (SimpleButton button in delBtns)
                        {
                            button.Enabled = true;
                        }
                    }
                    else
                    {
                        foreach (SimpleButton button in delBtns)
                        {
                            button.Enabled = false;
                        }
                    }
                }

                //����Ȩ��
                if (sendBtns != null)
                {
                    if (1 == func.FUNCTION_SEND)
                    {
                        foreach (SimpleButton button in sendBtns)
                        {
                            button.Enabled = true;
                        }
                    }
                    else
                    {
                        foreach (SimpleButton button in sendBtns)
                        {
                            button.Enabled = false;
                        }
                    }
                }

                //����Ȩ��
                if (receiveBtns != null)
                {
                    if (1 == func.FUNCTION_RECEIVE)
                    {
                        foreach (SimpleButton button in receiveBtns)
                        {
                            button.Enabled = true;
                        }
                    }
                    else
                    {
                        foreach (SimpleButton button in receiveBtns)
                        {
                            button.Enabled = false;
                        }
                    }
                }

                return func;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ȩ������ " + ex.Message);
                return null;
            }
        }

        public static DataRow[] auhority_check(string name)
        {
            DataRow[] zhls_dr;
            return zhls_dr = cls_public_main.t_group_auhority.Select(name);
        }
        #region ReadUdl_Center()��udl�ļ��ж�ȡ�������ݿ������ַ��� 
        public static string ReadUdl_Center()
		{
			if(m_strConnectCenter=="")
			{
				m_strConnectCenter=ReadUdl(RZMESDB);
			}
			return m_strConnectCenter;
		}
        #endregion

        public static void ExecuteSelectSql_dt(string strSql, ref DataTable dt)
        {
            //string connstr = ConfigurationManager.AppSettings["Oracle"].ToString();
            string strMsg = "";
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = RZW9DB_CONSTR;
            OracleDataAdapter da = new OracleDataAdapter(strSql, conn);
            try
            {
                conn.Open();
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                strMsg = ex.Message.ToString();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }


        /// <summary>
        /// ��ȡ
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        internal static DataTable GetData(string sql)
        {
            OracleConnection conn = new OracleConnection(RZW9DB_CONSTR);
            OracleCommand cmd = new OracleCommand(sql, conn);
            OracleDataAdapter oda = new OracleDataAdapter(cmd);

            DataTable dtORA = new DataTable();
            dtORA.Clear();

            try
            {
                conn.Open();
                oda.Fill(dtORA);
                return dtORA;
            }
            catch (Exception exp)
            {

                string strError = exp.ToString();

                string FileName = Application.StartupPath + "\\Exception\\error.txt";

                System.IO.StreamWriter MyWriter = null;
                try
                {
                    MyWriter = new StreamWriter(FileName, true, System.Text.Encoding.Default);
                }
                catch (Exception exp1)//�ļ���ȡ�쳣
                {
                    Console.WriteLine(exp1.Message);

                    return dtORA;
                }
                MyWriter.WriteLine("--------------------------------------------------------------------------");
                MyWriter.WriteLine(DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString());
                MyWriter.WriteLine(exp.ToString());
                MyWriter.WriteLine(sql);

                if (MyWriter != null)
                {
                    MyWriter.Close();
                }
                return dtORA;
            }
            finally
            {
                dtORA.Dispose();
                oda.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// д��
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        internal static bool SaveData(string sql)
        {
            OracleConnection conn = new OracleConnection(RZW9DB_CONSTR);            
            OracleCommand cmd = new OracleCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception exp)
            {
                string strError = exp.ToString();

                string FileName = Application.StartupPath + "\\Exception\\error.txt";

                System.IO.StreamWriter MyWriter = null;
                try
                {
                    MyWriter = new StreamWriter(FileName, true, System.Text.Encoding.Default);
                }
                catch (Exception exp1)
                {
                    Console.WriteLine(exp1.Message);
                    return false;
                }
                MyWriter.WriteLine("--------------------------------------------------------------------------");
                MyWriter.WriteLine(DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString());
                MyWriter.WriteLine(exp.ToString());
                MyWriter.WriteLine(sql);

                if (MyWriter != null)
                {
                    MyWriter.Close();
                }
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        public static int InsertData(string strSQL, DataTable dt)
        {
            int iRet = 0;
            string strMsg = "";
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = RZW9DB_CONSTR;
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                foreach (DataRow row in dt.Rows)
                    row.SetAdded();
                conn.Open();
                OracleCommandBuilder cmdBuilder = new OracleCommandBuilder(da);
                da.SelectCommand = new OracleCommand(strSQL, conn);
                da.InsertCommand = cmdBuilder.GetInsertCommand();
                iRet = da.Update(dt);
            }
            catch (Exception ex)
            {
                strMsg = ex.Message.ToString();
                iRet = -2;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return iRet;
        }

        // �������ݿ���ж�Ӧ��dt��¼�������
        public static int UpdateData(string strSQL, DataTable dt)
        {
            int iRet = 0;
            string strMsg = "";
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = RZW9DB_CONSTR;
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                conn.Open();
                OracleCommandBuilder cmdBuilder = new OracleCommandBuilder(da);
                da.SelectCommand = new OracleCommand(strSQL, conn);
                da.UpdateCommand = cmdBuilder.GetUpdateCommand();
                iRet = da.Update(dt);
            }
            catch (Exception ex)
            {
                strMsg = ex.Message.ToString();
                iRet = -2;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return iRet;
        }
        
        #region ExcuteSQL()���ݿ���ִ����ӡ��޸ġ�ɾ�������ĺ���
        public static int ExcuteSQL(string strUDL,string SQL)
		{
			int i_ES=0;
			OracleConnection  SqlConnection=null;
			OracleCommand  SqlServerCommand=null;
			try
			{
				SqlConnection = new OracleConnection(RZW9DB_CONSTR);
				SqlConnection.Open();
				SqlServerCommand= SqlConnection.CreateCommand();
				SqlServerCommand.CommandType = CommandType.Text;
				SqlServerCommand.CommandText = SQL ;
				SqlServerCommand.ExecuteNonQuery();	
			}
			catch(Exception ExFail)
			{
                MessageBox.Show(ExFail.Message);
                i_ES = 1;
            }
			finally
			{
				if (SqlConnection.State.ToString() == "Open")
				{
                    if (i_ES != 1) { i_ES = 2; }
                    SqlConnection.Close();
                }
            }
			return i_ES;
		}
		#endregion

		#region//���ݿ��ѯ
		public static DataTable ExecuteQuery(string strUDL,string SQL)
		{
            DataTable datatable = new DataTable();
            try
			{
                using (OracleConnection conn = new OracleConnection(RZW9DB_CONSTR))
                {
                    conn.Open();
                    using (OracleCommand cmd = conn.CreateCommand())
                    {  
                            cmd.CommandText = SQL;
                            //cmd.Parameters.AddRange(parameters);
                            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                            adapter.Fill(datatable);
                    }
                }
            }
			catch(Exception ExFail)
			{
                //Console.Write(ExFail.Message);
                MessageBox.Show(ExFail.Message);
            }
			finally
			{
			}
			return datatable;
		}
        #endregion
        public static DataTable ExecuteP(string strUDL, string SQL)
        {
            OleDbConnection SqlConnection = null;
            OleDbCommand SqlServerCommand = null;
            OleDbDataAdapter SqlAdapter = null;
            DataTable SqlDataTable = new DataTable();
            try
            {
                SqlConnection = new OleDbConnection(strUDL);
                SqlConnection.Open();
                SqlServerCommand = SqlConnection.CreateCommand();
                SqlServerCommand.CommandType = CommandType.StoredProcedure;
                SqlServerCommand.CommandText = SQL;
                SqlAdapter = new OleDbDataAdapter(SqlServerCommand);
                SqlAdapter.Fill(SqlDataTable);
            }
            catch (Exception ExFail)
            {
                //Console.Write(ExFail.Message);
                MessageBox.Show(ExFail.Message);
            }
            finally
            {
                if (SqlConnection.State.ToString() == "Open")
                {
                    SqlConnection.Close();
                }
            }
            return SqlDataTable;
        }


        #region //��ȡ������ʱ��
        public static string GetServerDateTime()
		{
			string str=System.DateTime.Now.ToString();
			string strConn = ReadUdl_Center();
			OleDbConnection oleCn = new OleDbConnection(RZW9DB_CONSTR);
			try
			{
				OleDbCommand oleCmd = oleCn.CreateCommand();
				oleCmd.CommandText = "SELECT getdate() ";
				OleDbDataAdapter oleDa = new OleDbDataAdapter();
				oleDa.SelectCommand = oleCmd;
				DataTable tbl=new DataTable();
				oleDa.Fill(tbl);
				if(tbl.Rows.Count>0)
				{
					DataRow row = tbl.Rows[0];
					str = row[0].ToString();
				}
				oleCn.Close();
			}
			catch(Exception ex)
			{
				Console.Write(ex.Message);
				oleCn.Close();
			}
			return str;
			
		}


        public static string newid(string t_name)
        {
            string sql = " select IDENT_CURRENT('" + t_name + "')";
            DataTable temp_dt = new DataTable();
            temp_dt = cls_public_main.ExecuteQuery(cls_public_main.RZW9DB_CONSTR, sql);
            return temp_dt.Rows[0][0].ToString();
        }
        #endregion

        public static string sys_time()
        {
            
            using (var db = new jyxcsjl2.MODEL.T_USER())
            {
                var systime = db.Database.SqlQuery<string>("select to_char(sysdate,'yyyy-mm-dd hh24:mi:ss') from dual").FirstAsync();
                return systime.Result.ToString();
            }
           
        }

        public static DateTime sys_timeDateTime()
        {
            return DateTime.Parse(sys_time());
        }

        public static string f_getzlno()
        {

            using (var db = new jyxcsjl2.MODEL.T_USER())
            {
                var systime = db.Database.SqlQuery<string>("select f_getzlno from dual").FirstAsync();
                return systime.Result.ToString();
            }

        }
        public static void update_time(string i)
        {
            if ( i == "begin")
            {
                string sql = " UPDATE t_user " +
                               "SET login_time = '" + login_time + "'" +                                  
                            " WHERE USER_ID = '" + m_strUserID + "'";
                ExcuteSQL(RZW9DB, sql);
            }
            if (i == "exit")
            {
                string sql = " UPDATE t_user " +
                              "SET exit_time = '" + GetServerDateTime() + "'" +
                           " WHERE USER_ID = '" + m_strUserID + "'";
                ExcuteSQL(RZW9DB, sql);
            }

        }
      
        public static void select_time (out string beg,out string end)
        {
            beg = "0";
            end = "0";

            DateTime time = Convert.ToDateTime(cls_public_main.sys_time()).Date;
            beg = time.AddDays(-1).ToShortDateString() + " 20:00:00";
            end = time.AddDays(0).ToShortDateString() + " 20:00:00"; ;
        }

        public static void select_time(out DateTime dtStart, out DateTime dtEnd)
        {
            DateTime time = Convert.ToDateTime(cls_public_main.sys_time());
            time = time.AddMinutes(-time.Minute).AddSeconds(-time.Second);
            int hour = time.Hour;
            int compHour = 20 - hour;
            if (hour >= 20)
            {
                dtStart = time.AddHours(compHour);
                dtEnd = time.AddDays(1).AddHours(compHour);
            }
            else
            {
                dtStart = time.AddDays(-1).AddHours(compHour);
                dtEnd = time.AddHours(compHour);
            }
        }

        #region //д��־
        public static void writeLog(string strMsg)
		{
			//	m_parentWnd.SetStatusText(strMsg);
			if(m_bRecordLog==0)
				return;
			try
			{
				string strTime = System.DateTime.Now.ToLongDateString();
				string path = System.IO.Directory.GetCurrentDirectory();
				if(Directory.Exists(path+"\\Log")==false)
					Directory.CreateDirectory(path+"\\Log");
				string strName = path +"\\Log\\"+strTime+".log";
				StreamWriter wrt=null;
				if(File.Exists(strName)==false)
					wrt = File.CreateText(strName);
				else
					wrt = new StreamWriter(strName,true);
				strMsg = strMsg.Replace("\r\n"," ");
				string strLog=GetServerDateTime()+"     "+strMsg;
				wrt.WriteLine(strLog);
				wrt.Close();
			}
			catch(Exception )
			{
			}
		}

		public static void writeToDatabase(int Flag,string strTabName,string strFunc,string strDesc,string strReason,string strOperator)
		{
			try
			{
				m_connect.ConnectionString = cls_public_main.ReadUdl_L2();
				m_connect.Open();
				m_command = m_connect.CreateCommand();
				m_command.CommandText="insert into T_SYSTEM_Log(Type,WindowName,FunctionName,Descrip,Reason,Operator) values('";
				m_command.CommandText+=Flag.ToString()+"','"+strTabName+"','"+strFunc+"','"+strDesc+"','"+strReason+"','"+strOperator+"')";
				m_command.ExecuteNonQuery();
			}
			catch(Exception)
			{
			}
			finally
			{
				if (m_connect.State.ToString() == "Open")
				{
					m_connect.Close();
				}
			}
		}


		public static void writeLog(int Flag,string strTabName,string strFunc,string strDesc,string strReason)
		{
			if(m_bRecordLog==0)
				return;
			string strTmp=strTabName+strFunc+strDesc+strReason+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm");
			if(m_strOldLog==strTmp)
				return;
			else
				m_strOldLog=strTmp;
			try
			{
				string strTime = System.DateTime.Now.ToLongDateString();
				string path = System.IO.Directory.GetCurrentDirectory();
				if(Directory.Exists(path+"\\Log")==false)
					Directory.CreateDirectory(path+"\\Log");
				string strName = path +"\\Log\\"+strTime+".log";
				StreamWriter wrt=null;
				if(File.Exists(strName)==false)
					wrt = File.CreateText(strName);
				else
					wrt = new StreamWriter(strName,true);
				switch(Flag)
				{
					case LOG_TYPE_SYSTEM:
						wrt.WriteLine("��־���ͣ�ϵͳ��¼");
						wrt.WriteLine("ϵͳʱ�䣺"+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
						wrt.WriteLine("�û����ƣ�"+m_strUserName);
						wrt.WriteLine("�������ڣ�"+strTabName);
						wrt.WriteLine("�������ƣ�"+strFunc);
						wrt.WriteLine("��¼˵����"+strDesc);
						wrt.WriteLine("��ϸ���ݣ�"+strReason);
						break;
					case LOG_TYPE_OPERATE:
						wrt.WriteLine("��־���ͣ��û�����");
						wrt.WriteLine("ϵͳʱ�䣺"+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
						wrt.WriteLine("�û����ƣ�"+m_strUserName);
						wrt.WriteLine("�������ڣ�"+strTabName);
						wrt.WriteLine("�������ƣ�"+strFunc);
						wrt.WriteLine("����˵����"+strDesc);
						wrt.WriteLine("��ϸ���ݣ�"+strReason);
						break;
					case LOG_TYPE_ERROR:				
						wrt.WriteLine("��־���ͣ�����");
						wrt.WriteLine("ϵͳʱ�䣺"+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
						wrt.WriteLine("�û����ƣ�"+m_strUserName);
						wrt.WriteLine("�������ڣ�"+strTabName);
						wrt.WriteLine("�������ƣ�"+strFunc);
						wrt.WriteLine("��¼˵����"+strDesc);
						wrt.WriteLine("����ԭ��"+strReason);
						break;
					default:
						break;
				}
				wrt.WriteLine("*******************************************");
				wrt.Close();
			}
			catch(Exception )
			{
			}
			writeToDatabase(Flag,strTabName,strFunc,strDesc,strReason,m_strUserName);
		}
		#endregion

		#region //�ж�һ���ַ����Ƿ����������
		public static bool IsNum(string str)
		{
			if(str.Length==0)
				return false;
			try
			{
				Convert.ToDouble(str);
			}
			catch(Exception)
			{
				return false;
			}
			return true;
		}
		#endregion

		#region//��ȡ����汾
		public static int ReadVersion()
		{
			string path = System.IO.Directory.GetCurrentDirectory();
			string strIniName = path +"\\config.ini";
			return GetPrivateProfileInt("Version","ID",0,strIniName);
		}
		#endregion

		
	}
}
