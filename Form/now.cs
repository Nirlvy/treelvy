using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using utils.Service;

namespace treelvy
{
    public partial class now : Form
    {
        public Dictionary<int, Dictionary<string, string>> userInfo = new Dictionary<int, Dictionary<string, string>>();
        DBService dbIris = DBService.getInstance("Nirlvy");

        public now()
        {
            InitializeComponent();
        }

        private void alter(object sender, EventArgs e)
        {
            string area = comboBox.Text;
            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT temp.id AS 账号,name AS 姓名,healtharea AS 健康码城市,goarea AS 行程码城市,temp.MDATE AS 日期,healthcolor AS 健康码颜色,gocolor AS 行程码颜色,
            nowhealtharea AS 当前健康码城市,nowgoarea AS 当前行程码城市,nowdate AS 当前日期,nowhealthcolor AS 当前健康码颜色,nowgocolor AS 当前行程码颜色 
            From [treelvy].[dbo].[tbl_mem_area],[treelvy].[dbo].[tbl_mem],[treelvy].[dbo].[tbl_mem_now],(SELECT id ,max(date) AS MDATE FROM [treelvy].[dbo].[tbl_mem_area] group by id) as temp
            WHERE goarea LIKE '%" + area + "%' AND tbl_mem.id=tbl_mem_area.id  AND tbl_mem_now.id=tbl_mem_area.id AND tbl_mem.id =temp.id AND date=MDATE ORDER BY tbl_mem.id");
            dataView.DataSource = dt;
            int count = dt.Rows.Count;
            for (int n = 0; n < count; n++)
            {
                if (dt.Rows[n][5].ToString() == "黄" || dt.Rows[n][6].ToString() == "黄" || dt.Rows[n][10].ToString() == "黄" || dt.Rows[n][11].ToString() == "黄")
                    dataView.Rows[n].DefaultCellStyle.ForeColor = Color.Gold;
                if (dt.Rows[n][5].ToString() == "红" || dt.Rows[n][6].ToString() == "红" || dt.Rows[n][10].ToString() == "红" || dt.Rows[n][11].ToString() == "红")
                    dataView.Rows[n].DefaultCellStyle.ForeColor = Color.Red;
            }

            int data, data1, data2, data3;
            data = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_now] WHERE nowgoarea LIKE '%" + area + "%' AND nowhealthcolor = '绿' AND nowgocolor = '绿'").Rows.Count;
            data1 = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_now] WHERE nowgoarea LIKE '%" + area + "%'").Rows.Count - data;
            data2 = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_now] WHERE nowhealthcolor = '绿' AND nowgocolor = '绿'").Rows.Count - data;
            data3 = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_now]").Rows.Count - data1 - data2;

            chart.ChartAreas.Clear();
            chart.Titles.Clear();
            chart.Series.Clear();
            chart.Legends.Clear();

            chart.ChartAreas.Add(new ChartArea("chartArea"));
            chart.ChartAreas["chartArea"].AxisX.IsMarginVisible = false;
            chart.ChartAreas["chartArea"].Area3DStyle.Enable3D = false;
            chart.Titles.Add("区域人数筛查");
            chart.Titles[0].Font = new Font("宋体", 15);
            chart.Series.Add("data");
            chart.Series["data"].ChartType = SeriesChartType.Pie;
            chart.Series["data"]["PieLabelStyle"] = "Inside";
            chart.Series["data"]["PieLineColor"] = "Black";
            chart.Legends.Add(new Legend("legend"));
            chart.Palette = ChartColorPalette.BrightPastel;            

            if (data != 0)
            {
                int idxA = chart.Series["data"].Points.AddY(data);
                DataPoint pointA = chart.Series["data"].Points[idxA];
                pointA.Label = "在此全为绿码";
                pointA.LegendText = "#LABEL(#VAL) #PERCENT{P2}";
            }

            if (data1 != 0)
            {
                int idxB = chart.Series["data"].Points.AddY(data1);
                DataPoint pointB = chart.Series["data"].Points[idxB];
                pointB.Label = "在此不全为绿码";
                pointB.LegendText = "#LABEL(#VAL) #PERCENT{P2}";
            }

            if (data2 != 0)
            {
                int idxC = chart.Series["data"].Points.AddY(data2);
                DataPoint pointC = chart.Series["data"].Points[idxC];
                pointC.Label = "不在此全为绿码";
                pointC.LegendText = "#LABEL(#VAL) #PERCENT{P2}";
            }

            if (data3 != 0)
            {
                int idxD = chart.Series["data"].Points.AddY(data3);
                DataPoint pointD = chart.Series["data"].Points[idxD];
                pointD.Label = "不在此不全为绿码";
                pointD.LegendText = "#LABEL(#VAL) #PERCENT{P2}";
            }

            chart.Visible = true;
        }
    }
}
