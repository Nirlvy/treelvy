using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utils.Service;
using Zen.Barcode;

namespace treelvy
{
    public partial class user_manager : Form
    {
        DBService dbIris = DBService.getInstance("Nirlvy");

        public user_manager()
        {
            InitializeComponent();

            health.Image = Image.FromFile(@".\Picture\code\health2.png");
            go.Image = Image.FromFile(@".\Picture\code\go1.png");

            int id = signin.ID;

            string time = DateTime.Now.AddDays(-14).ToString("yyyy/MM/dd").ToString();
            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT DISTINCT healtharea FROM [treelvy].[dbo].[tbl_mem_area] where id=" + id + "  AND date > '" + time + "'");
            int count = dt.Rows.Count;
            string healarea = "14天内经过的区域:";
            for(count--;count>=0;count--)
                healarea +=" "+dt.Rows[count][0].ToString();
            healtext.Text = healarea;

            dt = dbIris.GetDataTableBySql(@"SELECT DISTINCT goarea FROM [treelvy].[dbo].[tbl_mem_area] where id=" + id + "  AND date > '" + time + "'");
            count = dt.Rows.Count;
            string goarea = "14天内经过的区域:";
            for (count--; count >= 0; count--)
                goarea += " " + dt.Rows[count][0].ToString();
            gotext.Text = goarea;

            dt = dbIris.GetDataTableBySql(@"SELECT nowhealthcolor,nowgocolor FROM [treelvy].[dbo].[tbl_mem_now] where id=" + id + "");
            string healthcolor = dt.Rows[0][0].ToString();
            string gocolor = dt.Rows[0][1].ToString();
            if(!(healthcolor=="绿"&&gocolor=="绿"))
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                sp.SoundLocation = @".\Picture\warning.wav";
                sp.PlayLooping();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            dbIris.ExecuteSql(@"UPDATE tbl_door SET door=0 WHERE door=1;");

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.Stop();

            this.Close();
            common.user_manager = null;
            common.getTitleForm().Show();
            common.getTitleForm().live2d(null, null);
        }

        private void counttime(object sender, EventArgs e)
        {
            int time = int.Parse(count.Text);
            time--;
            if (time > 0)
            {
                count.Text = time.ToString();
            }
            else
                back_Click(null,null) ;
        }
    }
}
