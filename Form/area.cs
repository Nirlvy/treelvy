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
using TencentCloudExamples;
using utils.Service;

namespace treelvy
{
    public partial class area : Form
    {
        public Dictionary<int, Dictionary<string, string>> userInfo = new Dictionary<int, Dictionary<string, string>>();
        DBService dbIris = DBService.getInstance("Nirlvy");

        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        private string health_sql = "SELECT area AS 地区,color AS 颜色 From [treelvy].[dbo].[tbl_area_healthcolor]";
        private string go_sql = "SELECT area AS 地区,color AS 颜色 From [treelvy].[dbo].[tbl_area_gocolor]";
        private string connString = "Data Source=Nirlvy;Initial Catalog=treelvy;Integrated Security=SSPI;";
        int n = 0;

        public area()
        {
            InitializeComponent();
            health_Click(null, null);
        }

        private void health_Click(object sender, EventArgs e)
        {
            ds.Clear();
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter da = new SqlDataAdapter(health_sql, conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            n = 0;
        }

        private void go_Click(object sender, EventArgs e)
        {
            ds.Clear();
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter da = new SqlDataAdapter(go_sql, conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            n = 1;
        }

        List<string> location = new List<string>();
        List<string> color = new List<string>();
        List<string> color_r = new List<string>();
        List<string> time1 = new List<string>();

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            time1.Add(DateTime.Now.ToString());
            color_r.Add(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            location.Add(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            color.Add(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void alter()
        {
            for (int n = 0; n <= location.Count - 1; n++)
            {
                if(color_r[n]!=color[n])
                {
                    string name = dbIris.GetDataTableBySql(@"SELECT name FROM tbl_mem WHERE id=" + signin.ID + "").Rows[0][0].ToString();
                    dbIris.ExecuteSql(@"INSERT INTO tbl_action (action,time) VALUES ('" + name + "'+'将'+'" + location[n] + "'+'地区的颜色从'+'" + color_r[n] + "'+'色改成'+'" + color[n] + "'+'色','" + time1[n] + "')");
                }
            }

            string time = DateTime.Now.AddDays(-14).ToString("yyyy/MM/dd").ToString();
            List<string> id = new List<string>();

            for (int i, m = 0; m < location.Count; m++)
            {
                if (n == 0)
                {
                    DataTable dt;
                    dt = dbIris.GetDataTableBySql(@"SELECT id,healthcolor,date=convert(varchar(12),date,111) FROM treelvy.dbo.tbl_mem_area WHERE healtharea='" + location[m] + "' AND date >'" + time + "' AND healthcolor!='" + color[m] + "';");
                    int count = dt.Rows.Count;
                    for (i = 0; i <= count - 1; i++)
                    {
                        dbIris.ExecuteSql(@"UPDATE treelvy.dbo.tbl_mem_area SET healthcolor='" + color[m] + "' WHERE healtharea='" + location[m] + "' AND healthcolor='" + dt.Rows[i][1].ToString() + "' AND date='" + dt.Rows[i][2].ToString() + "'");

                        int on = 0;
                        for (int num = 0; num <= id.Count - 1; num++)
                        {
                            if (dt.Rows[i][0].ToString() == id[num])
                            {
                                on = 1;
                                break;
                            }
                        }
                        if (on == 0)
                        {
                            id.Add(dt.Rows[i][0].ToString());
                        }
                    }
                }
                else if (n == 1)
                {
                    DataTable dt;
                    dt = dbIris.GetDataTableBySql(@"SELECT id,gocolor,date=convert(varchar(12),date,111) FROM treelvy.dbo.tbl_mem_area WHERE goarea='" + location[m] + "' AND date >'" + time + "' AND gocolor!='" + color[m] + "';");
                    int count = dt.Rows.Count;
                    for (i = 0; i <= count - 1; i++)
                    {
                        dbIris.ExecuteSql(@"UPDATE treelvy.dbo.tbl_mem_area SET gocolor='" + color[m] + "' WHERE goarea='" + location[m] + "' AND gocolor='" + dt.Rows[i][1].ToString() + "' AND date='" + dt.Rows[i][2].ToString() + "'");

                        int on = 0;
                        for (int num = 0; num <= id.Count - 1; num++)
                        {
                            if (dt.Rows[i][0].ToString() == id[num])
                            {
                                on = 1;
                                break;
                            }
                        }
                        if (on == 0)
                        {
                            id.Add(dt.Rows[i][0].ToString());
                        }
                    }
                }
                for (int n = 0; n < id.Count; n++)
                {
                    if (id[n] == null)
                        break;

                    string healthcolor1 = "绿";
                    string gocolor1 = "绿";
                    DataTable dt;

                    dt = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_area] where id=" + id[n] + " AND date > '" + time + "' AND healthcolor = '黄' ");
                    if (dt.Rows.Count > 0)
                        healthcolor1 = "黄";
                    dt = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_area] where id=" + id[n] + " AND date > '" + time + "' AND healthcolor = '红' ");
                    if (dt.Rows.Count > 0)
                        healthcolor1 = "红";
                    dt = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_area] where id=" + id[n] + " AND date > '" + time + "' AND gocolor = '黄' ");
                    if (dt.Rows.Count > 0)
                        gocolor1 = "黄";
                    dt = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_area] where id=" + id[n] + " AND date > '" + time + "' AND gocolor = '红' ");
                    if (dt.Rows.Count > 0)
                        gocolor1 = "红";

                    dbIris.ExecuteSql(@"UPDATE treelvy.dbo.tbl_mem_now SET nowhealthcolor='" + healthcolor1 + "',nowgocolor='" + gocolor1 + "' WHERE id=" + id[n] + "");

                    dt = dbIris.GetDataTableBySql(@"SELECT tele FROM [treelvy].[dbo].[tbl_mem] where id=" + id[n] + " ");
                    string num = dt.Rows[0][0].ToString();
                    string[] user = new string[] { location[m], color[m] + "色", healthcolor1, gocolor1 };

                    SendSms.Message(num, 1199119, user);
                }
            }       
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            cmd = conn.CreateCommand();
            if (n == 0)
                cmd.CommandText = health_sql;
            else if (n == 1)
                cmd.CommandText = go_sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            new SqlCommandBuilder(da);
            da.Update(ds);
            ds.Clear();
            alter();
            if (n == 0)
                health_Click(null, null);
            else
                go_Click(null, null);
        }
    }
}
