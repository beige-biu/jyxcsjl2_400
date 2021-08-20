﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace jyxcsjl2
{
    public partial class hopper_ratio : UserControl
    {
        public hopper_ratio()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            
        }
        public string begin_time, end_time;

        private void hopper_ratio_Load(object sender, EventArgs e)
        {
            cls_public_main.select_time(out begin_time, out end_time);
            this.dateTimePicker1.Value = Convert.ToDateTime(begin_time);
            this.dateTimePicker2.Value = Convert.ToDateTime(end_time);
            sclect(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sclect(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string path = cls_public_main.to_path();
            if (path != "")
            {
                gridView1.ExportToXls(path);
            }
        }

        public void sclect(DateTime Begin_time, DateTime End_time)
        {
               string sql = "select * from V_MATERIAL_TEAM_RADIO where INSERT_DATE between to_date('"
                      + Begin_time.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss') and to_date('"
                      + End_time.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss')";
            // var bb = yh.T_PRODUCE_SINTERING_RADIO.Where(t => (t.INSERT_DATE >= Begin_time && t.INSERT_DATE <= End_time));
            DataTable dt = cls_public_main.ExecuteQuery("", sql);
            gridControl1.DataSource = dt;
               
        }
    }
}