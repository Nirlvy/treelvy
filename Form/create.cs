using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TencentCloudExamples;
using utils.Service;

namespace treelvy
{
    public partial class create : Form
    {
        static Random I = new Random();
        static string i1 = I.Next(100000, 999999).ToString();
        string[] i = new string[] { i1 };
        int voice;

        public Dictionary<int, Dictionary<string, string>> userInfo = new Dictionary<int, Dictionary<string, string>>();
        DBService dbIris = DBService.getInstance("Nirlvy");

        public create()
        {
            InitializeComponent();

            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT id FROM [treelvy].[dbo].[tbl_mem] ORDER BY id DESC");
            int id = (int)dt.Rows[0][0] + 1;
            textid.Text = id.ToString();
            voice = 0;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            common.create = null;
            common.getManagerForm().Show();
        }

        private void get_Click(object sender, EventArgs e)
        {
            if ((textid.Text !="") && (textname.Text != "") && (textnumber.Text != "") && (textpassword.Text == "") && (textcode.Text == "") || 
                (textid.Text != "") && (textname.Text != "") && (textnumber.Text != "") && (textpassword.Text != "") && (textcode.Text != ""))
            {
                string code;
                DataTable dt;
                if (textcode.Text != "")
                {
                    string password = textpassword.Text;
                    int len = password.Length;
                    if(len>=6&&len<=20)
                    {
                        code = textcode.Text;
                        dt = dbIris.GetDataTableBySql(@"SELECT id FROM [treelvy].[dbo].[tbl_admincode] where admincode='" + code + "'");
                        int n = dt.Rows.Count;
                        if (n == 0)
                            MessageBox.Show("没有此识别码！！！");
                        else
                        {
                            string id = dt.Rows[0][0].ToString();
                            if (id != "")
                            {
                                MessageBox.Show("此识别码已被使用！！！请更换识别码！！！");
                            }
                            else
                            {
                                string num = textnumber.Text;
                                SendSms.Message(num, 1169712, i);
                                correct.Visible = true;
                            }
                        }                    
                    }
                    else
                    {
                        MessageBox.Show("请输入正确的密码格式！！！");
                    }
                }
                else
                {
                    string num = textnumber.Text;
                    SendSms.Message(num, 1169712, i);
                    correct.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("请确认已经填好所有信息并且已经验证！！！确认完请重新获取验证码");
            }  
        }

        private void correct_Click(object sender, EventArgs e)
        {
            if (i[0].ToString() == textnumcode.Text)
            {
                eye.Visible = true;
                tip6.Visible = true;
                axIris.Visible = false;
            }
            else
                MessageBox.Show("验证码错误！");
        }

        private void eye_Click(object sender, EventArgs e)
        {   
            axIris.Visible = true;
            axIris.ModuleLoad(220);
            axIris.ModulePropSet(1, 1);
            axIris.ModulePropSet(4, 2);
            InitUserInfo();
            if (textid.Text.Length > 0)
            {
                int enrollUser = Convert.ToInt32(textid.Text);
                axIris.Enroll(enrollUser);
            }
        }

        private void textname_DoubleClick(object sender, EventArgs e)
        {
            textname.Text = "";
            string name = record.Voice(voice);
            if (voice == 1)
            {
                textname.Text = name;
                pictureBox1.Visible = false;
                voice = 0;
                textnumber.Enabled = true;
                textnumcode.Enabled = true;
                textpassword.Enabled = true;
                textcode.Enabled = true;
            }
            else
            {
                voice++;
                pictureBox1.Visible = true;
                textnumber.Enabled = false;
                textnumcode.Enabled = false;
                textpassword.Enabled = false;
                textcode.Enabled = false;
            }
        }

        private void textnumber_DoubleClick(object sender, EventArgs e)
        {
            textnumber.Text = "";
            string name = record.Voice(voice);
            if (voice == 1)
            {
                textnumber.Text = name;
                pictureBox2.Visible = false;
                voice = 0;
                textname.Enabled = true;
                textnumcode.Enabled = true;
                textpassword.Enabled = true;
                textcode.Enabled = true;
            }
            else
            {
                voice++;
                pictureBox2.Visible = true;
                textname.Enabled = false;
                textnumcode.Enabled = false;
                textpassword.Enabled = false;
                textcode.Enabled = false;
            }
        }

        private void textnumcode_DoubleClick(object sender, EventArgs e)
        {
            textnumcode.Text = "";
            string name = record.Voice(voice);
            if (voice == 1)
            {
                textnumcode.Text = name;
                pictureBox3.Visible = false;
                voice = 0;
                textnumber.Enabled = true;
                textname.Enabled = true;
                textpassword.Enabled = true;
                textcode.Enabled = true;
            }
            else
            {
                voice++;
                pictureBox3.Visible = true;
                textnumber.Enabled = false;
                textname.Enabled = false;
                textpassword.Enabled = false;
                textcode.Enabled = false;
            }
        }

        private void complete_Click(object sender, EventArgs e)
        {
            this.Close();
            common.signin = null;
            common.getUser_managerForm().Show();
        }

        int text = 0;        
        private void textpassword_Click(object sender, EventArgs e)
        {
            text = 1;
            LocationAlter();
            button();
            if (num.Visible == false)
            {
                textnumber.Enabled = true;
                textname.Enabled = true;
                textnumcode.Enabled = true;
                textcode.Enabled = true;
            }
            else
            {
                textnumber.Enabled = false;
                textname.Enabled = false;
                textnumcode.Enabled = false;
                textcode.Enabled = false;
            }
        }

        private void textnumber_Click(object sender, EventArgs e)
        {
            text = 3;
            LocationAlter();
            button();
            if (num.Visible == false)
            {
                textnumcode.Enabled = true;
                textname.Enabled = true;
                textpassword.Enabled = true;
                textcode.Enabled = true;
            }
            else
            {
                textnumcode.Enabled = false;
                textname.Enabled = false;
                textpassword.Enabled = false;
                textcode.Enabled = false;
            }
        }

        private void textnumcode_Click(object sender, EventArgs e)
        {
            text = 4;
            LocationAlter();
            button();
            if (num.Visible == false)
            {
                textnumber.Enabled = true;
                textname.Enabled = true;
                textpassword.Enabled = true;
                textcode.Enabled = true;
            }
            else
            {
                textnumber.Enabled = false;
                textname.Enabled = false;
                textpassword.Enabled = false;
                textcode.Enabled = false;
            }
        }

        private void textcode_Click(object sender, EventArgs e)
        {
            text = 2;
            LocationAlter();
            button();
            if (num.Visible == false)
            {
                textnumber.Enabled = true;
                textname.Enabled = true;
                textpassword.Enabled = true;
                textnumcode.Enabled = true;
            }
            else
            {
                textnumber.Enabled = false;
                textname.Enabled = false;
                textpassword.Enabled = false;
                textnumcode.Enabled = false;
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (text == 1)
                textpassword.Text += 0;
            else if (text == 2)
                textcode.Text += 0;
            else if (text == 3)
                textnumber.Text += 0;
            else if (text == 4)
                textnumcode.Text += 0;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (text == 1)
                textpassword.Text += 1;
            else if (text == 2)
                textcode.Text += 1;
            else if (text == 3)
                textnumber.Text += 1;
            else if (text == 4)
                textnumcode.Text += 1;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (text == 1)
                textpassword.Text += 2;
            else if (text == 2)
                textcode.Text += 2;
            else if (text == 3)
                textnumber.Text += 2;
            else if (text == 4)
                textnumcode.Text += 2;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (text == 1)
                textpassword.Text += 3;
            else if (text == 2)
                textcode.Text += 3;
            else if (text == 3)
                textnumber.Text += 3;
            else if (text == 4)
                textnumcode.Text += 3;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (text == 1)
                textpassword.Text += 4;
            else if (text == 2)
                textcode.Text += 4;
            else if (text == 3)
                textnumber.Text += 4;
            else if (text == 4)
                textnumcode.Text += 4;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (text == 1)
                textpassword.Text += 5;
            else if (text == 2)
                textcode.Text += 5;
            else if (text == 3)
                textnumber.Text += 5;
            else if (text == 4)
                textnumcode.Text += 5;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (text == 1)
                textpassword.Text += 6;
            else if (text == 2)
                textcode.Text += 6;
            else if (text == 3)
                textnumber.Text += 6;
            else if (text == 4)
                textnumcode.Text += 6;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (text == 1)
                textpassword.Text += 7;
            else if (text == 2)
                textcode.Text += 7;
            else if (text == 3)
                textnumber.Text += 7;
            else if (text == 4)
                textnumcode.Text += 7;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (text == 1)
                textpassword.Text += 8;
            else if (text == 2)
                textcode.Text += 8;
            else if (text == 3)
                textnumber.Text += 8;
            else if (text == 4)
                textnumcode.Text += 8;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (text == 1)
                textpassword.Text += 9;
            else if (text == 2)
                textcode.Text += 9;
            else if (text == 3)
                textnumber.Text += 9;
            else if (text == 4)
                textnumcode.Text += 9;
        }

        private void bac_Click(object sender, EventArgs e)
        {
            if (text == 1)
                textpassword.Text = "";
            else if (text == 2)
                textcode.Text = "";
            else if (text == 3)
                textnumber.Text = "";
            else if (text == 4)
                textnumcode.Text = "";
        }

        private void bb_Click(object sender, EventArgs e)
        {
            button();
            LocationAlter();
            textpassword.Enabled = true;
            textcode.Enabled = true;
            textname.Enabled = true;
            textnumber.Enabled = true;
            textnumcode.Enabled = true;
        }

        public void LocationAlter()
        {
            if (num.Visible == false)
            {
                num.Visible = true;
                tip5.Visible = false;
                tip7.Visible = false;
                back.Visible = false;
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
                tip5.Visible = true;
                tip7.Visible = true;
                back.Visible = true;
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

        private void OnEnroll(object sender, AxIRISINGFRAMEWORKLib._DIrisingFrameworkEvents_EnrollStateCallbackEvent e)
        {
            long irisLength = this.axIris.IRISCODELENGTH;
            long irisCode = e.irisCode;
            long irisImage = e.irisImage;
            long enrollUser = e.enrollUser;
            long responseState = e.responseState;
            long camIndex = responseState / 65535;   //取高16位,0表示左眼，1表示右眼
            responseState = responseState % 65535;   //取低16位
            long enrollIndex = responseState / 256;  //取高8位，0表示没有注册,1表示曾注册过
            responseState = responseState % 256;     //取低8位，表示注册质量
            //注册失败直接返回
            if (enrollUser < 0)
            {
                axIris.Visible = false;
                return;
            }
            else if (0 < enrollIndex)
            {
                axIris.Visible = false;
                MessageBox.Show("该用户已经注册过虹膜");
                return;
            }
            unsafe
            {
                byte* irisCodePtr = (byte*)irisCode;        //irisCode的值实际上就是虹膜的内存地址
                byte[] irisArr = new byte[irisLength];
                for (int i = 0; i < irisLength; i++)
                {
                    irisArr[i] = irisCodePtr[i];
                }
                string id = textid.Text;
                string admincode = textcode.Text;
                string name = textname.Text;
                string sex = "男";
                if (man.Checked)
                    sex = "男";
                else if (woman.Checked)
                    sex = "女";
                string admin = "是";
                if (textcode.Text != null)
                    admin = "否";
                string tele = this.textnumber.Text;

                dbIris.ExecuteSql(@"INSERT INTO tbl_mem(id,name,sex,admin,tele) VALUES (" + id + ",'" + name + "','" + sex + "','" + admin + "','" + tele + "')");

                if(textcode.Text != "")
                {
                    string password = textpassword.Text;
                    password = treelvy.password.Encode(password);
                    dbIris.ExecuteSql(@"INSERT INTO tbl_admin(id,password,admincode) VALUES (" + id + ",'" + password + "','" + admincode + "')");
                    dbIris.ExecuteSql(@"UPDATE tbl_admincode SET id=" + id + " WHERE admincode=" + admincode + ";");
                }

                string date = DateTime.Now.ToString("yyyy/MM/dd").ToString();
                string area1 = "上海电力大学";
                string area2 = "上海市";
                string color1 = dbIris.GetDataTableBySql(@"SELECT color FROM treelvy.dbo.tbl_area_healthcolor WHERE area='" + area1 + "'").Rows[0][0].ToString();
                string color2 = dbIris.GetDataTableBySql(@"SELECT color FROM treelvy.dbo.tbl_area_gocolor WHERE area='" + area2 + "'").Rows[0][0].ToString();
                string time = DateTime.Now.ToString();
                dbIris.ExecuteSql(@"INSERT INTO tbl_mem_now(id,nowdate,nowhealtharea,nowgoarea,nowhealthcolor,nowgocolor)VALUES(" + id + ",'" + date + "','" + area1 + "','" + area2 + "','" + color1 + "','" + color2 + "')");
                dbIris.ExecuteSql(@"INSERT INTO tbl_mem_area(id,healtharea,goarea,date,healthcolor,gocolor)VALUES(" + id + ",'" + area1 + "','" + area2 + "','" + date + "','" + color1 + "','" + color2 + "')");
                SqlParameter[] paras = new SqlParameter[]{new SqlParameter("@irisArr", irisArr)};
                dbIris.ExecuteSql("INSERT INTO tbl_eye(id,eyecode) VALUES (" + id + ",@irisArr)",paras);
                dbIris.ExecuteSql(@"INSERT INTO tbl_pass(id,passtime) VALUES (" + id + ",'" + time + "')");
                string name_a = dbIris.GetDataTableBySql(@"SELECT name FROM tbl_mem WHERE id=" + signin.ID + "").Rows[0][0].ToString();
                dbIris.ExecuteSql(@"INSERT INTO tbl_action (action,time) VALUES ('" + name_a + "'+'注册了'+'" + id + "','" + time + "')");

                axIris.Visible = false;
                signin.ID=int.Parse(id);
                getcode.code(int.Parse(id), color1, color2);
                MessageBox.Show("注册完成！！！请点击下一步进入个人信息或者返回上一步");
                complete.Visible = true;
                back.Location = new Point(186, 522);
            }
        }

        public void InitUserInfo()
        {
            userInfo.Clear();
            DataTable dt;
            dt = dbIris.GetDataTableBySql(@"SELECT tbl_mem.id,tbl_mem.name,tbl_eye.eyecode FROM [treelvy].[dbo].[tbl_mem], [treelvy].[dbo].[tbl_eye] where tbl_mem.id=tbl_eye.id ORDER BY tbl_mem.id");
            int count = dt.Rows.Count;
            int codeLength = axIris.IRISCODELENGTH;
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
    }
}
