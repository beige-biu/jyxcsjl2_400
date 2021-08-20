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
	/// cls_public_main 的摘要说明。
	/// </summary>

	public class cls_public_main
	{	
		public static int IRON_NO_LENGTH=8;//铁次号长度
		public const string RZMESDB = "RZMESDB.udl";//中心数据库
        public const string RZW9DB = "RZW9DB.udl";//本地数据库
        public const string RZW9RTDB = "RZW9DB.udl";
        public static string RZMESDB_CONSTR = "";//中心数据库
        public static string RZW9DB_CONSTR = "User Id = ORALTL2_ST; Password=oraltl2_400s;Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 172.16.8.16)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = ORALTL2)))";//本地数据
        public static string RZW9RTD_CONSTR = "";
        public static DataTable t_group_auhority = new DataTable();
        
        private static int m_bRecordLog=1;//是否记录日志
		private static string m_strOldLog="";
	
		public static string m_strConnectL2="";
		public static string m_strConnectL2Mode="";
		public static string m_strConnectCenter="";
		public static string m_strEventCase="";//事件信息

        /// <summary>
        /// 用户ID 工号
        /// </summary>
        public static string m_strUserID = "";
        /// <summary>
        /// 用户名
        /// </summary>
		public static string m_strUserName = "";
        /// <summary>
        /// 用户角色
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
        /// 用户权限
        /// </summary>
        public static List<MODEL.T_SYS_FUNCTION1> userFunc;

        #region//数据库变量
        private static OleDbConnection		m_connect = new OleDbConnection();
		private static OleDbCommand		m_command = new OleDbCommand();
        #endregion
        /// <summary>
        /// 导出EXECL路径选择
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

		#region //初始化日志文件
		public static void Initialize()
		{

            m_strEventCase = "CASE SUBSTRING(EventCode,3,2) WHEN '01' THEN '铁水包到达处理位' WHEN '02' THEN '处理开始' ";
			m_strEventCase+="WHEN '03' THEN '处理结束' WHEN '04' THEN '测温' WHEN '05' THEN '取样' ";
			m_strEventCase+="WHEN '06' THEN '铁水包离开' WHEN '10' THEN '处理中断' ";
            m_strEventCase += "END AS  生产事件";
		}
		#endregion

		#region 导入读写ini文件的API函数

		[DllImport("kernel32")]
		public static extern int GetPrivateProfileString(string section,string Key,string def,StringBuilder retVal,int size,string filePath);
		[DllImport("kernel32")]
		public static extern int GetPrivateProfileInt(string section,string key,int val,string filePath);
		[DllImport("kernel32")]
		public static extern int WritePrivateProfileString(string section,string key,string val,string filePath);
			
		#endregion

		#region ReadIni()从ini文件中读取系统配置信息 
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

		#region ReadUdl()从udl文件中读取数据库连接字符串 
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
					MessageBox.Show("系统数据库连接失败，请检查udl文件的配置！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				

			}
			return ConnString;

		}

		public static string ReadUdl2(string strUDL)//连接二级系统
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
					MessageBox.Show("系统数据库连接失败，请检查udl文件的配置！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);

				}

			}

			return ConnString;

		}
		#endregion

		#region ReadUdl_L2()从udl文件中读取本地数据库连接字符串 
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
                    return "夜班";
                }
                else if (systime.Result.ToString() == "0")
                {
                    return "白班";
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// 按键权限控制
        /// </summary>
        /// <param name="control">用户窗体</param>
        /// <param name="addBtns">添加按键</param>
        /// <param name="updateBtns">修改按键</param>
        /// <param name="delBtns">删除按键</param>
        /// <param name="sendBtns">发送按键</param>
        /// <param name="receiveBtns">接收按键</param>
        /// <returns></returns>
        public static MODEL.T_SYS_FUNCTION1 ButtonControl(UserControl control, List<SimpleButton> addBtns, List<SimpleButton> updateBtns,
            List<SimpleButton> delBtns, List<SimpleButton> sendBtns, List<SimpleButton> receiveBtns)
        {
            MODEL.T_SYS_FUNCTION1 func = new MODEL.T_SYS_FUNCTION1();
            try
            {
                func = cls_public_main.userFunc.Find(t => t.FUNCTION_FORM == control.GetType().Name);
                //添加权限
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

                //修改权限
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

                //删除权限
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

                //发送权限
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

                //接收权限
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
                Console.WriteLine("权限设置 " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 权限控制
        /// </summary>
        /// <param name="control">用户窗体</param>
        /// <param name="addBtns">添加按键</param>
        /// <param name="updateGrid">修改grid</param>
        /// <param name="delBtns">删除按键</param>
        /// <param name="sendBtns">发送按键</param>
        /// <param name="receiveBtns">接收按键</param>
        /// <returns></returns>
        public static MODEL.T_SYS_FUNCTION1 FuncControl(UserControl control, List<SimpleButton> addBtns, List<DevExpress.XtraGrid.Views.Grid.GridView> updateGrids,
            List<SimpleButton> delBtns, List<SimpleButton> sendBtns, List<SimpleButton> receiveBtns)
        {
            MODEL.T_SYS_FUNCTION1 func = new MODEL.T_SYS_FUNCTION1();
            try
            {
                func = cls_public_main.userFunc.Find(t => t.FUNCTION_FORM == control.GetType().Name);
                //添加权限
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

                //修改权限
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

                //删除权限
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

                //发送权限
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

                //接收权限
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
                Console.WriteLine("权限设置 " + ex.Message);
                return null;
            }
        }

        public static DataRow[] auhority_check(string name)
        {
            DataRow[] zhls_dr;
            return zhls_dr = cls_public_main.t_group_auhority.Select(name);
        }
        #region ReadUdl_Center()从udl文件中读取中心数据库连接字符串 
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
        /// 读取
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
                catch (Exception exp1)//文件读取异常
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
        /// 写入
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

        // 更新数据库表中对应的dt记录表的数据
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
        
        #region ExcuteSQL()数据库中执行添加、修改、删除操作的函数
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

		#region//数据库查询
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


        #region //获取服务器时间
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

        #region //写日志
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
						wrt.WriteLine("日志类型：系统记录");
						wrt.WriteLine("系统时间："+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
						wrt.WriteLine("用户名称："+m_strUserName);
						wrt.WriteLine("操作窗口："+strTabName);
						wrt.WriteLine("函数名称："+strFunc);
						wrt.WriteLine("记录说明："+strDesc);
						wrt.WriteLine("详细内容："+strReason);
						break;
					case LOG_TYPE_OPERATE:
						wrt.WriteLine("日志类型：用户操作");
						wrt.WriteLine("系统时间："+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
						wrt.WriteLine("用户名称："+m_strUserName);
						wrt.WriteLine("操作窗口："+strTabName);
						wrt.WriteLine("函数名称："+strFunc);
						wrt.WriteLine("操作说明："+strDesc);
						wrt.WriteLine("详细内容："+strReason);
						break;
					case LOG_TYPE_ERROR:				
						wrt.WriteLine("日志类型：错误");
						wrt.WriteLine("系统时间："+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
						wrt.WriteLine("用户名称："+m_strUserName);
						wrt.WriteLine("操作窗口："+strTabName);
						wrt.WriteLine("函数名称："+strFunc);
						wrt.WriteLine("记录说明："+strDesc);
						wrt.WriteLine("错误原因："+strReason);
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

		#region //判断一个字符串是否由数字组成
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

		#region//获取软件版本
		public static int ReadVersion()
		{
			string path = System.IO.Directory.GetCurrentDirectory();
			string strIniName = path +"\\config.ini";
			return GetPrivateProfileInt("Version","ID",0,strIniName);
		}
		#endregion

		
	}
}
