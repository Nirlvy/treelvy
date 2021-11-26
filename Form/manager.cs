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
    public partial class manager : Form
    {
        public Dictionary<int, Dictionary<string, string>> userInfo = new Dictionary<int, Dictionary<string, string>>();
        DBService dbIris = DBService.getInstance("Nirlvy");

        public manager()
        {
            InitializeComponent();

            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT door FROM [treelvy].[dbo].[tbl_door]");
            int door_oc = (int)dt.Rows[0][0];
            if (door_oc == 0)
            {
                door.BackgroundImage = new Bitmap(@".\Resources\开关门-关-正常无底.png");
            }
            else
            {
                door.BackgroundImage = new Bitmap(@".\Resources\开关门.png");
            }
        }

        private void area_Click(object sender, EventArgs e)
        {
            excel.DataTableToExcel(dbIris.GetDataTableBySql(@"SELECT area AS 地区,color AS 颜色 FROM tbl_area_healthcolor"), "健康码地区");
            excel.DataTableToExcel(dbIris.GetDataTableBySql(@"SELECT area AS 地区,color AS 颜色 FROM tbl_area_gocolor"), "出行码地区");
            excel.DataTableToExcel(dbIris.GetDataTableBySql(@"SELECT id AS 账号,name AS 名字,sex AS 性别,admin AS 管理员,tele AS 电话 FROM tbl_mem"), "人员信息");
            excel.DataTableToExcel(dbIris.GetDataTableBySql(@"SELECT No AS 序号,id AS 账号,healtharea AS 健康码地区,goarea AS 出行码地区,date AS 日期,healthcolor AS 健康码颜色,gocolor AS 出行码颜色 FROM tbl_mem_area"), "人员流动");
            excel.DataTableToExcel(dbIris.GetDataTableBySql(@"SELECT id AS 账号,nowdate AS 当前日期,nowhealtharea AS 当前健康码地区,nowgoarea AS 当前出行码地区,nowhealthcolor AS 当前健康码颜色,nowgocolor AS 当前出行码颜色 FROM tbl_mem_now"), "当前人员情况");
            excel.DataTableToExcel(dbIris.GetDataTableBySql(@"SELECT No AS 序号,id AS 账号,passtime AS 通过时间 FROM tbl_pass"), "通过记录");
            MessageBox.Show("Excel已生成");
        }

        private void back_Click(object sender, EventArgs e)
        {
            dbIris.ExecuteSql(@"UPDATE tbl_door SET door=0 WHERE door=1;");
            this.Close();
            common.manager = null;
            common.getTitleForm().Show();
            common.getTitleForm().live2d(null, null);

        }

        private void create_Click(object sender, EventArgs e)
        {
            this.Close();
            common.manager = null;
            common.getCreateForm().Show();
        }

        private void manage_Click(object sender, EventArgs e)
        {
            this.Close();
            common.manager = null;
            common.getComboForm().Show();
        }

        private void screen_Click(object sender, EventArgs e)
        {
            this.Close();
            common.manager = null;
            common.getChartForm().Show();
        }

        private void now_Click(object sender, EventArgs e)
        {
            this.Close();
            common.manager = null;
            common.getUser_managerForm().Show();
        }

        private void door_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();
            string name = dbIris.GetDataTableBySql(@"SELECT name FROM tbl_mem WHERE id=" + treelvy.signin.ID + "").Rows[0][0].ToString();
            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT door FROM [treelvy].[dbo].[tbl_door]");
            int door_oc = (int)dt.Rows[0][0];
            if (door_oc == 1)
            {
                dbIris.ExecuteSql(@"UPDATE tbl_door SET door=0 WHERE door=1;");
                dbIris.ExecuteSql(@"INSERT INTO tbl_action (action,time) VALUES ('" + name + "关闭了门','" + time + "')");
                door.BackgroundImage = new Bitmap(@".\Resources\开关门-关-正常无底.png");
            }
            else
            {
                dbIris.ExecuteSql(@"UPDATE tbl_door SET door=1 WHERE door=0;");
                dbIris.ExecuteSql(@"INSERT INTO tbl_action (action,time) VALUES ('" + name + "开启了门','" + time + "')");
                door.BackgroundImage = new Bitmap(@".\Resources\开关门.png");
            }
        }  
    }
}
