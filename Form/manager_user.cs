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
using utils.Service;

namespace treelvy
{
    public partial class manager_user : Form
    {
        DBService dbIris = DBService.getInstance("Nirlvy");

        public manager_user()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        private string sql = "SELECT id AS 账号,name AS 姓名,sex AS 性别,admin AS 管理员,tele AS 电话 FROM tbl_mem";
        private string connString = "Data Source=Nirlvy;Initial Catalog=treelvy;Integrated Security=SSPI;";    

        private void admin_manager_user_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["管理员"].DefaultCellStyle.ForeColor = Color.Silver;
            dataGridView1.Columns["管理员"].ReadOnly = true;  
            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT * FROM tbl_mem");
            int count = dt.Rows.Count;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            for (int n = 1; n < count; n++)
            {
                if (dataGridView1[3, n - 1].Value.ToString() == "是")
                {
                    dataGridView1.Rows[n - 1].ReadOnly = true;
                    dataGridView1.Rows[n - 1].DefaultCellStyle.ForeColor = Color.Silver;
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id AS 账号,name AS 姓名,sex AS 性别,admin AS 管理员,tele AS 电话 FROM tbl_mem";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            new SqlCommandBuilder(da);
            da.Update(ds);
            ds.Clear();
            string name = dbIris.GetDataTableBySql(@"SELECT name FROM tbl_mem WHERE id=" + signin.ID + "").Rows[0][0].ToString();

            for (int n = 0; n <= data1.Count - 1; n++)
            {
                if(data1[n]!=data2[n])
                {
                    dbIris.ExecuteSql(@"INSERT INTO tbl_action (action,time) VALUES ('" + name + "'+'将第'+'" + data1_1[n] + "'+'行第'+'" + data1_2[n] + "'+'列的'+'" + data2[n] + "'+'修改为'+'" + data1[n] + "','" + time[n] + "')");
                    data1.Clear();
                    data1_1.Clear();
                    data1_2.Clear();
                    data2.Clear();
                    time.Clear();
                }
            }

            admin_manager_user_Load(null, null);
        }

        List<string> data1 = new List<string>();
        List<string> data1_1 = new List<string>();
        List<string> data1_2 = new List<string>();
        List<string> data2 = new List<string>();
        List<string> time =new List<string>();

        public void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {   
            for (int n = 0; n <= 4; n++)
            {
                time.Add(DateTime.Now.ToString());
                data1.Add(dataGridView1.Rows[e.RowIndex].Cells[n].Value.ToString());
                data1_1.Add((e.RowIndex + 1).ToString());
                data1_2.Add((e.ColumnIndex + 1).ToString());
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {     
            for (int n = 0; n <= 4; n++)
                data2.Add(dataGridView1.Rows[e.RowIndex].Cells[n].Value.ToString());
        }
    }
}
