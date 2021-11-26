using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using utils.Service;

namespace treelvy
{
    public partial class sift : Form
    {
        public Dictionary<int, Dictionary<string, string>> userInfo = new Dictionary<int, Dictionary<string, string>>();
        DBService dbIris = DBService.getInstance("Nirlvy");

        public sift()
        {
            InitializeComponent();
            button_search_Click(null, null);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string area = comboBox.Text;
            string time = textBox.Text;
            DataTable dt;
            if ((area == "任意" || area == "")&&time!="")
                dt = dbIris.GetDataTableBySql(@"SELECT No AS 序号,id AS 账号,healtharea AS 健康码城市,goarea AS 行程码城市,date AS 日期,healthcolor AS 健康码颜色,gocolor AS 行程码颜色 
                                          FROM [treelvy].[dbo].[tbl_mem_area] WHERE date='" + time + "'");
            else if((area != "任意" && area != "") && time == "")
                dt = dbIris.GetDataTableBySql(@"SELECT No AS 序号,id AS 账号,healtharea AS 健康码城市,goarea AS 行程码城市,date AS 日期,healthcolor AS 健康码颜色,gocolor AS 行程码颜色 
                                          FROM [treelvy].[dbo].[tbl_mem_area] WHERE goarea='" + area + "'");
            else if ((area == "任意" || area == "") && time == "")
                dt = dbIris.GetDataTableBySql(@"SELECT No AS 序号,id AS 账号,healtharea AS 健康码城市,goarea AS 行程码城市,date AS 日期,healthcolor AS 健康码颜色,gocolor AS 行程码颜色 
                                          FROM [treelvy].[dbo].[tbl_mem_area]");
            else
                dt = dbIris.GetDataTableBySql(@"SELECT No AS 序号,id AS 账号,healtharea AS 健康码城市,goarea AS 行程码城市,date AS 日期,healthcolor AS 健康码颜色,gocolor AS 行程码颜色 
                                              FROM [treelvy].[dbo].[tbl_mem_area] WHERE goarea='" + area + "' AND date='" + time + "'");
            dataView.DataSource = dt;
        }

        private void date(object sender, EventArgs e)
        {
            monthCalendar.Visible = true;
        }

        private void select(object sender, DateRangeEventArgs e)
        {
            textBox.Text = monthCalendar.SelectionStart.ToString("yyyy-MM-dd");
            monthCalendar.Visible = false;
        }
    }
}
