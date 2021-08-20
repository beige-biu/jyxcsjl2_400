using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Threading;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;
namespace jyxcsjl2_verup
{
    class autoupdate
    {
        string connstr = "User Id = ORALTL2_ST; Password=oraltl2_400s;Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 172.16.8.16)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = ORALTL2)))";
        //private DataSet m_DataSet;
        //private string m_TableName = "t_autoupdate";
        //private DataTable m_Table;
        /// <summary>    
        /// 定义本软件在注册表中software下的公司名和软件名称   
        /// </summary>
        private string m_companyname = "金自天正", m_softwarename = "江阴兴澄二级系统";
        /// <summary>   
        /// 从注册表中读信息;  
        /// </summary>    
        ///  <param name="p_KeyName">要读取的键值</param>    
        /// <returns>读到的键值字符串,如果失败(如注册表尚无信息),则返回""</returns>   
        public string ReadInfo(string p_KeyName)
       {
            RegistryKey SoftwareKey=Registry.LocalMachine.OpenSubKey("Software",true);
            RegistryKey CompanyKey=SoftwareKey.OpenSubKey(m_companyname);
            string strValue="";
            if (CompanyKey==null) return "";
            RegistryKey SoftwareNameKey = CompanyKey.OpenSubKey(m_softwarename);//建立    
            if (SoftwareNameKey==null)     return "";
            try
            {
                strValue =SoftwareNameKey.GetValue(p_KeyName).ToString().Trim();
            }
            catch
            { }
            if (strValue==null)
                strValue ="";
            return strValue;
        }
        /// <summary>   
        /// 将信息写入注册表   
        /// </summary>    
        ///  <param name="p_keyname">键名</param>   
        ///  <param name="p_keyvalue">键值</param>    
        public void WriteInfo(string p_keyname,string p_keyvalue)
        {
            RegistryKey SoftwareKey=Registry.LocalMachine.OpenSubKey("Software",true);
            RegistryKey CompanyKey=SoftwareKey.CreateSubKey(m_companyname);
            RegistryKey SoftwareNameKey=CompanyKey.CreateSubKey(m_softwarename);    //写入相应信息      
            SoftwareNameKey.SetValue(p_keyname,p_keyvalue);
        }
        /// <summary>   
        /// 获取操作员情况，同时更新主程序版本  
        ///  </summary>   
        public void GetInfo()
        {
            OracleConnection myConnect = new OracleConnection(connstr);
            OracleCommand myCommand = new OracleCommand();
            OracleDataAdapter myDataAdapter = new OracleDataAdapter();
            try
            {
                //检查是否有新的版本      
                DataSet dataset=new DataSet();
                string tablename= "t_autoupdate";     
                //为减少数据传送时间，不获取文件内容     
                string strSql = "select file_name,ver_sn from t_autoupdate";
                myCommand = new OracleCommand(strSql, myConnect);
                myDataAdapter = new OracleDataAdapter();
                myDataAdapter.SelectCommand=myCommand;
                myDataAdapter.Fill(dataset,tablename);
                if (dataset.Tables[tablename].Rows.Count==1)//有文件     
                {
                    string filename=dataset.Tables[tablename].Rows[0]["file_name"].ToString();
                    string version=dataset.Tables[tablename].Rows[0]["ver_sn"].ToString();       //读入本机主程序的版本号       
                    string oldversion=this.ReadInfo(filename);
                    if (oldversion.Length==0)//不存在       
                        oldversion ="0";
                    if (Decimal.Parse(version)>Decimal.Parse(oldversion))//有新的版本出现      
                    {
                        //取回文件内容       
                        MessageBox.Show("注意：系统有新版本系统将自动升级系统将自动关闭");
                        System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName("jyxcsjl2");
                        //关闭原有应用程序的所有进程 
                        foreach (System.Diagnostics.Process pro in proc)
                        {
                            pro.Kill();
                        }
                        dataset =new DataSet();
                        strSql = "select * from t_autoupdate";
                        myCommand =new OracleCommand(strSql,myConnect);
                        myDataAdapter =new OracleDataAdapter();
                        myDataAdapter.SelectCommand=myCommand;
                        myDataAdapter.Fill(dataset,tablename);
                        //将文件下载到本地        
                        DataRow row=dataset.Tables[tablename].Rows[0];
                        if (row["file_content"] !=DBNull.Value)
                        {
                            Byte[] byteBLOBData =  new Byte[0];
                            byteBLOBData = (Byte[])row["file_content"];
                            try
                            {
                                
                                FileStream fs=new  FileStream(Application.StartupPath+"\\"+filename,FileMode.OpenOrCreate);
                                fs.Write(byteBLOBData,0,byteBLOBData.Length);
                                fs.Close();          //写入当前版本号，供下次使用         
                                this.WriteInfo(filename,version);
                                MessageBox.Show("注意：系统有新版本升级结束");
                            }
                            catch (Exception ee)
                            {
                                MessageBox.Show(ee.Message);
                            }
                        }
                    }//有新版本      
                }//有文件      
                 //关闭连接     
                myConnect.Close();
            }
            catch (Exception ee)
            {     MessageBox.Show(ee.Message);
                return;
            }     //允许登录      
        }
    }
}
