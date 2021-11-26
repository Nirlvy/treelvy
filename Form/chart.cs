using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using utils.Service;

namespace treelvy
{
    public partial class chart : Form
    {
        DBService dbIris = DBService.getInstance("Nirlvy");

        public chart()
        {
            InitializeComponent();

            month_SelectedIndexChanged(null, null);
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(month.Text=="")
            {
                string year = DateTime.Now.Year.ToString();
                List<int> yData = new List<int>();
                List<int> yData2 = new List<int>();
                List<int> yData3 = new List<int>();
                List<int> yData4 = new List<int>();
                for (int n = 1; n <= 12; n++)
                {
                    string time = year + "-" + n + "-";
                    yData.Add(dbIris.GetDataTableBySql(@"SELECT * FROM tbl_mem_now WHERE nowhealthcolor='绿' AND nowgocolor='绿' AND nowdate LIKE '%" + time + "%'").Rows.Count);
                    yData2.Add((dbIris.GetDataTableBySql(@"SELECT * FROM tbl_mem_now WHERE nowdate LIKE '%" + time + "%' ").Rows.Count) - yData[n - 1]);
                    yData3.Add(dbIris.GetDataTableBySql(@"SELECT * FROM tbl_mem_now WHERE nowhealthcolor='绿' AND nowgocolor='绿' AND nowgoarea='上海市' AND nowdate LIKE '%" + time + "%'").Rows.Count);
                    yData4.Add(dbIris.GetDataTableBySql(@"SELECT * FROM tbl_mem_now WHERE nowgoarea='上海市' AND nowdate LIKE '%" + time + "%'").Rows.Count - yData3[n - 1]);
                }

                List<string> xData = new List<string>() { "1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月" };
                chart1.Titles.Clear();
                chart1.Titles.Add(year + "年每月疫情情况统计");

                chart1.Series[0].Points.DataBindXY(xData, yData);
                chart1.Series[0].Color = Color.Red;
                chart1.Series[0].ToolTip = "全国两码为绿人数：#VAL人";

                chart1.Series[1].Points.DataBindXY(xData, yData2);
                chart1.Series[1].Color = Color.Green;
                chart1.Series[1].ToolTip = "全国两码不全为绿人数：#VAL人";

                chart1.Series[2].Points.DataBindXY(xData, yData3);
                chart1.Series[2].Color = Color.Blue;
                chart1.Series[2].ToolTip = "上海两码为绿人数：#VAL人";

                chart1.Series[3].Points.DataBindXY(xData, yData4);
                chart1.Series[3].Color = Color.Pink;
                chart1.Series[3].ToolTip = "上海两码不全为绿人数：#VAL人";

                yData = new List<int>();
                for (int n = 1; n <= 12; n++)
                {
                    string time = year + "-" + n + "-";
                    yData.Add(dbIris.GetDataTableBySql(@"SELECT * FROM tbl_pass WHERE convert(varchar(10),passtime,121) LIKE '%" + time + "%'").Rows.Count);
                }
                chart2.Titles.Clear();
                chart2.Titles.Add(year + "年每月通过情况统计");

                chart2.Series[0].Points.DataBindXY(xData, yData);
                chart2.Series[0].ToolTip = "该月通过人数：#VAL人";
            }
            else
            {
                string year = DateTime.Now.Year.ToString();
                string mon = month.Text;
                int day = DateTime.DaysInMonth(int.Parse(year), int.Parse(mon));

                List<string> xData = new List<string>();
                List<int> yData = new List<int>();
                List<int> yData2 = new List<int>();
                List<int> yData3 = new List<int>();
                List<int> yData4 = new List<int>();
                for (int n = 1; n <= day; n++)
                {
                    string time = year + "-" + mon + "-" + n;
                    xData.Add(n + "天");
                    yData.Add(dbIris.GetDataTableBySql(@"SELECT * FROM tbl_mem_now WHERE nowhealthcolor='绿' AND nowgocolor='绿' AND nowdate='" + time + "'").Rows.Count);
                    yData2.Add((dbIris.GetDataTableBySql(@"SELECT * FROM tbl_mem_now WHERE nowdate='" + time + "'").Rows.Count) - yData[n - 1]);
                    yData3.Add(dbIris.GetDataTableBySql(@"SELECT * FROM tbl_mem_now WHERE nowhealthcolor='绿' AND nowgocolor='绿' AND nowgoarea='上海市' AND nowdate='" + time + "'").Rows.Count);
                    yData4.Add(dbIris.GetDataTableBySql(@"SELECT * FROM tbl_mem_now WHERE nowgoarea='上海市' AND nowdate='" + time + "'").Rows.Count - yData3[n - 1]);
                }

                chart1.Titles.Clear();
                chart1.Titles.Add(year + "年" + mon + "每日疫情情况统计");

                chart1.Series[0].Points.DataBindXY(xData, yData);
                chart1.Series[0].Color = Color.Red;
                chart1.Series[0].ToolTip = "全国两码为绿人数：#VAL人";

                chart1.Series[1].Points.DataBindXY(xData, yData2);
                chart1.Series[1].Color = Color.Green;
                chart1.Series[1].ToolTip = "全国两码不全为绿人数：#VAL人";

                chart1.Series[2].Points.DataBindXY(xData, yData3);
                chart1.Series[2].Color = Color.Blue;
                chart1.Series[2].ToolTip = "上海两码为绿人数：#VAL人";

                chart1.Series[3].Points.DataBindXY(xData, yData4);
                chart1.Series[3].Color = Color.Pink;
                chart1.Series[3].ToolTip = "上海两码不全为绿人数：#VAL人";

                yData = new List<int>();
                for (int n = 1; n <= day; n++)
                {
                    string time = year + "-" + mon + "-" + n;
                    yData.Add(dbIris.GetDataTableBySql(@"SELECT * FROM tbl_pass WHERE convert(varchar(10),passtime,121)='" + time + "'").Rows.Count);
                }
                chart2.Titles.Clear();
                chart2.Titles.Add(year + "年" + mon + "每日通过情况统计");

                chart2.Series[0].Points.DataBindXY(xData, yData);
                chart2.Series[0].ToolTip = "该日通过人数：#VAL人";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            common.chart = null;
            common.getManagerForm().Show();
        }
    }
}
