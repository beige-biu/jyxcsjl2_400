using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.IO;

namespace jyxcsjl2
{
    public partial class soft_upload : Form
    {
        private DataSet m_DataSet = new DataSet();
        private string m_TableName = "t_autoupdate";
        public soft_upload()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog myForm = new OpenFileDialog();
            myForm.Filter = "应用程序(*.exe)|*.exe|所有程序(*.*)|*.*";
            if (myForm.ShowDialog() == DialogResult.OK)
            {
                this.txtFileName.Text = myForm.FileName;
            }
        }
        private string GetFileNameFromPath(string p_Path)
        {
            string strResult = "";
            int nStart = p_Path.LastIndexOf("\\");
            if (nStart > 0)
            {
                strResult = p_Path.Substring(nStart + 1, p_Path.Length - nStart - 1);
            }
            return strResult;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal.Parse(this.txtVersion.Text);
            }
            catch
            {
                MessageBox.Show("无效的版本号!");
                this.txtVersion.Focus();
                this.txtVersion.SelectAll();
                return;
            }
            if (this.txtFileName.Text.Trim().Length > 0)
            {     //检查文件是否存在      
                if (!File.Exists(this.txtFileName.Text.Trim()))
                {
                    MessageBox.Show("文件不存在！");
                    return;
                }
                //连接数据库      
             
               OracleConnection myConnect=new OracleConnection(cls_public_main.RZW9DB_CONSTR);
               OracleCommand myCommand=new OracleCommand("select * from t_autoupdate", myConnect);
               OracleDataAdapter myDataAdapter = new OracleDataAdapter();
               myDataAdapter.SelectCommand=myCommand;
               OracleCommandBuilder myCommandBuilder=new OracleCommandBuilder(myDataAdapter);
               myConnect.Open();
                //获取已有的数据      
                m_DataSet =new DataSet();
                try
                {
                    myDataAdapter.Fill(m_DataSet,this.m_TableName);
                    //如果是首次上传，则增加一条记录       
                    if (m_DataSet.Tables[m_TableName].Rows.Count==0)
                    {
                        DataRow newrow=m_DataSet.Tables[m_TableName].NewRow(); 
                        newrow["id"] = "1";
                        m_DataSet.Tables[m_TableName].Rows.Add(newrow);
                     }
                    DataRow row = m_DataSet.Tables[m_TableName].Rows[0];   //填入去掉路径的文件名称      
                            row["file_name"] =this.GetFileNameFromPath(this.txtFileName.Text.Trim());       //填入版本号       
                            row["ver_sn"] =this.txtVersion.Text.Trim();       //将实际文件存入记录中      
                            FileStream fs=new  FileStream(this.txtFileName.Text.Trim(),FileMode.Open);
                            byte [] myData = new Byte [fs.Length ];
                            fs.Position = 0;
                            fs.Read (myData,0,Convert.ToInt32 (fs.Length ));
                            row["file_content"] = myData;
                            fs.Close();//关闭文件       
                            myDataAdapter.Update(this.m_DataSet,this.m_TableName);  //更新数据库
                            myConnect.Close();
                            MessageBox.Show("系统更新成功！");
                            this.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("请输入文件名");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
