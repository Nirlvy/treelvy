using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TencentCloudExamples;
using utils.Service;
using Zen.Barcode;

namespace treelvy
{
    public partial class signin : Form
    {
        public Dictionary<int, Dictionary<string, string>> userInfo = new Dictionary<int, Dictionary<string, string>>();
        DBService dbIris = DBService.getInstance("Nirlvy");

        public signin()
        {
            InitializeComponent();
        }
        
        public static int ID;

        private void fp(object sender, EventArgs e)
        {
            int Dev_ID = Convert.ToInt32(1);
            utils.Service.FPService.CKT_RegisterUSB(Dev_ID, 0);
            int FP_ID = identify(Dev_ID);
            ID = FP_ID;
            if (FP_ID > 0)
            {
                textid.Text = FP_ID.ToString();
                for (int i = 0; i < userInfo.Count; i++)
                {
                    if (userInfo[i]["ID"] == textid.Text)
                    {
                        name.Text = userInfo[i]["Name"];
                        break;
                    }
                }
                timIdentify.Enabled = false;

                search(FP_ID);
            }
        }

        public int identify(int Dev_ID)
        {
            int res = 0;
            int pLongRun = new int();
            int pRecCount = new int();
            int pRetCount = new int();
            int ppPersons = new int();
            int pTemp = 0;
            int tempPtr = 0;
            res = FPService.CKT_GetClockingNewRecordEx(Dev_ID, ref pLongRun);
            if (res == 1)
            {
                while (true)
                {
                    res = FPService.CKT_GetClockingRecordProgress(pLongRun, ref pRecCount, ref pRetCount, ref ppPersons);
                    if (res != 0)
                    {
                        pTemp = Marshal.SizeOf(FPService.clocking);
                        tempPtr = ppPersons;
                        for (int i = 0; i < pRetCount; i++)
                        {
                            FPService.RtlMoveMemory(ref FPService.clocking, ppPersons, pTemp);
                            ppPersons += ppPersons + pTemp;
                            if (FPService.clocking.PersonID < 0)
                            {
                                continue;
                            }
                            else
                            {
                                if (tempPtr != 0)
                                {
                                    FPService.CKT_FreeMemory(tempPtr);
                                }
                                FPService.CKT_ClearClockingRecord(Dev_ID, 0, 0);
                                return FPService.clocking.PersonID;
                            }
                        }
                    }
                    if (tempPtr != 0)
                    {
                        FPService.CKT_FreeMemory(tempPtr);
                        FPService.CKT_ClearClockingRecord(1, 0, 0);
                    }
                    if (res == 1)
                    {
                        break;
                    }
                }
            }
            return -1;
        }

        private void eyelogin_Click(object sender, EventArgs e)
        {
            axIris.Visible = true;
            cancel.Visible = true;
            timIdentify.Enabled = false;

            axIris.ModuleLoad(220);
            axIris.ModulePropSet(1, 1);
            axIris.ModulePropSet(4, 2);

            timIdentifyMatch.Enabled = true;

            InitUserInfo();
        }

        private void IdentifyMatch(object sender, EventArgs e)
        {
            axIris.IdentifyMatch();
        }

        private void OnIdentify(object sender, AxIRISINGFRAMEWORKLib._DIrisingFrameworkEvents_IdentifyStateCallbackEvent e)
        {
            timIdentifyMatch.Enabled = false;

            int userIndex = e.identifyUser;
            if (userIndex == -2)
            {
                axIris.Visible = false;
                cancel.Visible = false;
                return;
            }
            if (userIndex > -1)
            {
                axIris.Visible = false;
                cancel.Visible = false;

                textid.Text = (userInfo[userIndex]["id"]);
                ID = int.Parse(userInfo[userIndex]["id"]);
                search(int.Parse(userInfo[userIndex]["id"]));
            }
            else
            {
                axIris.Visible = false;
                cancel.Visible = false;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            axIris.ModuleUnload();
            axIris.Visible = false;
            cancel.Visible = false;
            timIdentify.Enabled = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            common.signin = null;
            common.getTitleForm().Show();
            common.getTitleForm().live2d(null, null);
        }

        private void tiptime_Click(object sender, EventArgs e)
        {
            int time = int.Parse(tiptime.Text);
            time--;
            if (time > 0)
            {
                tiptime.Text = time.ToString();
            }
            else
                login_Click(null,null);
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(textpassword.Text=="")
            {
                this.Close();
                common.signin = null;
                common.getUser_managerForm().Show();
            }
            else
            {
                this.Close();
                common.signin = null;
                common.getManagerForm().Show();
            }
        }

        private void search(int id)
        {
            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem] where id=" + id + "");
            int count = dt.Rows.Count;
            if (count == 0)
            {
                MessageBox.Show("用户注册了指纹但未注册系统！！！请尝试请其他ID注册！！！即将返回首页");
                System.Threading.Thread.Sleep(3000);
                this.Close();
                common.signin = null;
                common.getTitleForm().Show();
                common.getTitleForm().live2d(null, null);
            }
            else
            {
                if (textpassword.Text != "")
                {
                    string password = textpassword.Text;
                    dt = dbIris.GetDataTableBySql(@"SELECT password FROM [treelvy].[dbo].[tbl_admin] where id=" + id + " ");
                    string password1 = dt.Rows[0][0].ToString();
                    password1 = treelvy.password.Decode(password1);
                    if (password != password1)
                    {
                        MessageBox.Show("密码错误！！！请检查！！！即将返回首页");
                        System.Threading.Thread.Sleep(3000);
                        this.Close();
                        common.signin = null;
                        common.getTitleForm().Show();
                        common.getTitleForm().live2d(null, null);
                    }
                    else
                        searchfor(id);
                }
                else
                    searchfor(id);
            }
        }

        private void searchfor(int ID)
        {
            int id = ID;

            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT name FROM [treelvy].[dbo].[tbl_mem] where id=" + id + "");
            name.Text = dt.Rows[0][0].ToString();

            string time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss").ToString();
            dbIris.ExecuteSql(@"INSERT INTO tbl_pass(id,passtime) VALUES (" + id + ",'" + time + "')");

            string healtharea = "上海电力大学";
            dt = dbIris.GetDataTableBySql(@"SELECT color FROM [treelvy].[dbo].[tbl_area_healthcolor] where area='" + healtharea + "'");
            string healthcolor = dt.Rows[0][0].ToString();

            string goarea = "上海市";
            dt = dbIris.GetDataTableBySql(@"SELECT color FROM [treelvy].[dbo].[tbl_area_gocolor] where area='" + goarea + "'");
            string gocolor = dt.Rows[0][0].ToString();

            string time1 = DateTime.Now.ToString("yyyy/MM/dd").ToString();
            dt = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_area] where id=" + id + " AND healtharea='" + healtharea + "' AND goarea='" + goarea + "' AND date='" + time1 + "'");
            int memcount = dt.Rows.Count;
            if (memcount == 0)
                dbIris.ExecuteSql(@"INSERT INTO tbl_mem_area(id,healtharea,goarea,date,healthcolor,gocolor) VALUES (" + id + ",'" + healtharea + "','" + goarea + "','" + time1 + "','" + healthcolor + "','" + gocolor + "')");

            string healthcolor1 = "绿";
            string gocolor1 = "绿";
            string time2 = DateTime.Now.AddDays(-14).ToString("yyyy/MM/dd");
            dt = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_area] where id=" + id + " AND date > '" + time2 + "' AND healthcolor = '黄' ");
            if (dt.Rows.Count > 0)
                healthcolor1 = "黄";
            dt = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_area] where id=" + id + " AND date > '" + time2 + "' AND healthcolor = '红' ");
            if (dt.Rows.Count > 0)
                healthcolor1 = "红";
            dt = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_area] where id=" + id + " AND date > '" + time2 + "' AND gocolor = '黄' ");
            if (dt.Rows.Count > 0)
                gocolor1 = "黄";
            dt = dbIris.GetDataTableBySql(@"SELECT * FROM [treelvy].[dbo].[tbl_mem_area] where id=" + id + " AND date > '" + time2 + "' AND gocolor = '红' ");
            if (dt.Rows.Count > 0)
                gocolor1 = "红";

            dbIris.ExecuteSql(@"UPDATE treelvy.dbo.tbl_mem_now SET nowdate='" + time1 + "',nowhealtharea='" + healtharea + "',nowgoarea='" + goarea + "',nowhealthcolor='" + healthcolor1 + "',nowgocolor='" + gocolor1 + "' WHERE id='" + id + "'");

            if (!(healthcolor1 == "绿" && gocolor1 == "绿"))
            {
                dt = dbIris.GetDataTableBySql(@"SELECT tele FROM [treelvy].[dbo].[tbl_mem] where id=" + id + "");
                string num = dt.Rows[0][0].ToString();
                SendSms.Message(num, 1169708, null);
                getcode.code(id, healthcolor1, gocolor1);
            }
            else
            {
                dbIris.ExecuteSql(@"UPDATE [treelvy].dbo.tbl_door SET door=1 WHERE door=0;");   
                getcode.code(id, healthcolor1, gocolor1);
            }

            timlogin.Enabled = true;
            complete.Visible = true;
            tiptime.Visible = true;
        }

        public void InitUserInfo()
        {
            userInfo.Clear();
            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT tbl_mem.id,tbl_mem.name,tbl_eye.eyecode FROM [treelvy].[dbo].[tbl_mem], [treelvy].[dbo].[tbl_eye] where tbl_mem.id=tbl_eye.id ORDER BY tbl_mem.id");
            int count = dt.Rows.Count;
            int codeLength = this.axIris.IRISCODELENGTH;
            if (count <= 0)
            {
                return;
            }

            byte[] irisCodeArr = new byte[count * codeLength];
            byte[] irisCodeTempArr;
            irisCodeTempArr = new byte[codeLength];
            for (int i = 0; i < count; i++)
            {
                userInfo[i] = new Dictionary<string, string>(){
                    {"id",(dt.Rows[i]["id"]).ToString()},
                    {"name",(dt.Rows[i]["name"]).ToString()}
                };
                byte[] temp = (byte[])dt.Rows[i]["eyecode"];
                for (int j = 0; j < codeLength; j++)
                {
                    irisCodeArr[i * codeLength + j] = temp[j];
                }
            }
            GCHandle hin = GCHandle.Alloc(irisCodeArr, GCHandleType.Pinned);
            this.axIris.IrisCodeAttach((int)hin.AddrOfPinnedObject(), count);
            hin.Free();
        }

        private void textpassword_Click(object sender, EventArgs e)
        {
            LocationAlter();
            button();
        }

        public void LocationAlter()
        {
            if (num.Visible == false)
            {
                num.Visible = true;
                for (int s = 0; num.Width < 174; s++)
                {
                    num.Size = new Size(s, (int)(s * 1.3));
                }
            }
            else if (num.Visible == true)
            {
                for (int s = 279; num.Width > 0; s--)
                {
                    num.Size = new Size(s, (int)(s * 1.3));
                }
                num.Visible = false;
            }
        }

        private void button()
        {
            if (num.Visible == true)
            {
                b0.Visible = true;
                b1.Visible = true;
                b2.Visible = true;
                b3.Visible = true;
                b4.Visible = true;
                b5.Visible = true;
                b6.Visible = true;
                b7.Visible = true;
                b8.Visible = true;
                b9.Visible = true;
                bac.Visible = true;
                bb.Visible = true;
            }
            else
            {
                b0.Visible = false;
                b1.Visible = false;
                b2.Visible = false;
                b3.Visible = false;
                b4.Visible = false;
                b5.Visible = false;
                b6.Visible = false;
                b7.Visible = false;
                b8.Visible = false;
                b9.Visible = false;
                bac.Visible = false;
                bb.Visible = false;
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textpassword.Text += 0;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textpassword.Text += 1;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textpassword.Text += 2;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textpassword.Text += 3;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textpassword.Text += 4;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textpassword.Text += 5;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textpassword.Text += 6;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textpassword.Text += 7;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textpassword.Text += 8;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textpassword.Text += 9;
        }

        private void bac_Click(object sender, EventArgs e)
        {
            textpassword.Text = "";
        }

        private void bb_Click(object sender, EventArgs e)
        {
            LocationAlter();
        }
    }
}
