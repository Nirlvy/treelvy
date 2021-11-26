using CefSharp;
using CefSharp.WinForms;
using SHDocVw;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml;

namespace treelvy
{
    public partial class title : Form
    {
        public title()
        {
            InitializeComponent();
        }

        private void l1_click(object sender, EventArgs e)
        {
            int h = p_weather.Height;
            if (h == 200 && (p_rss.Height == 200))
            {
                kill();

                p_weather.BringToFront();
                int h1 = 1;
                int locate = 240;
                for (; h <= 400; h += h1, locate -= h1, h1++)
                {
                    p_weather.Size = new Size(h, h);
                    p_weather.Location = new Point(locate, 20);
                    System.Threading.Thread.Sleep(1);
                }
                weather.Visible = true;
                weather.BringToFront();
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
            else if(h != 200 && (p_rss.Height == 200))
            {
                live2d(null, null);

                weather.Visible = false;
                p_weather.BringToFront();
                int h1 = 1;
                int locate = 40;
                for (; h >= 200; h -= h1, locate += h1, h1++)
                {
                    p_weather.Size = new Size(h, h);
                    p_weather.Location = new Point(locate, 20);
                    System.Threading.Thread.Sleep(1);
                }
                p_weather.Size = new System.Drawing.Size(200, 200);
                p_weather.Location = new Point(240, 20);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        private void time_TextChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            time.Text = dt.GetDateTimeFormats('r')[0].ToString();
            time.TabStop = false;
        }

        private void music_off_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.Stop();
        }

        private void music_on_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.SoundLocation = @"E:\OneDrive\study\vs2015\treelvy\Picture\V.wav";
            sp.PlayLooping();
        }

        private void next_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.Stop();

            kill();
            this.Hide();
            common.getSigninForm().Show();
        }

        private void p_rss_Click(object sender, EventArgs e)
        {
            kill();

            int h = p_rss.Height;
            if (h == 200&& (p_weather.Height == 200))
            {
                p_rss.BringToFront();
                int h1 = 1;
                int locate = 240;
                int locate1 = 262;
                for (; h <= 400; h += h1, locate -= h1, locate1 -= (h1 / 2), h1++)
                {
                    p_rss.Size = new Size(h, h);
                    p_rss.Location = new Point(locate, locate1);
                    System.Threading.Thread.Sleep(1);
                }
                rss.Visible = true;
                rss.BringToFront();
            }
            else if(h != 200 && (p_weather.Height == 200))
            {
                live2d(null, null);

                rss.Visible = false;
                p_rss.BringToFront();
                int h1 = 1;
                int locate = 50;
                int locate1 = 160;
                for (; h >= 200; h -= h1, locate += h1, locate1 += (h1 / 2), h1++)
                {
                    p_rss.Size = new System.Drawing.Size(h, h);
                    p_rss.Location = new Point(locate, locate1);
                    System.Threading.Thread.Sleep(1);
                }
                p_rss.Size = new Size(200, 200);
                p_rss.Location = new Point(240, 262);
            }
        }

        [DllImport("USER32.DLL")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        public void live2d(object sender, EventArgs e)
        {
            timer_live2d.Enabled = true;
            string pName = "Demo";//要启动的进程名称，可以在任务管理器里查看，一般是不带.exe后缀的;
            Process[] temp = Process.GetProcessesByName(pName);//在所有已启动的进程中查找需要的进程；
            if (temp.Length > 0)//如果查找到
            {
                IntPtr handle = temp[0].MainWindowHandle;
                SwitchToThisWindow(handle, true);    // 激活，显示在最前
            }
            else
            {
                Process.Start(pName + ".exe");//否则启动进程
            }
        }

        private void kill()
        {
            timer_live2d.Enabled = false;
            Process[] myProcess = Process.GetProcessesByName("Demo");
            foreach (Process process in myProcess)
            {
                process.Kill();
            }
        }

        private void tip_Click(object sender, EventArgs e)
        {
            next_Click(null, null);
        }

        private void picture_rss_Click(object sender, EventArgs e)
        {
            p_rss_Click(null, null);
        }

        private void weather_picture_Click(object sender, EventArgs e)
        {
            l1_click(null, null);
        }

        private void tipsw(object sender, EventArgs e)
        {
            string[] txt = { "Go for it! just do it!", "better late than never.", "Don't give up and don't give in.", "One today is worth two tomorrows.", "A bold attempt is half success.",
                            "Do what you say,say what you do.", "Zero in your target,and go for it.", "Never, never, never, never give up.", "There is only one me in this world.",
                            "When it has is lost, brave to give up.", "Youth means limitless possibilities.", "I know that my future is not just a dream. ",
                            "Real dream is the other shore of reality.", "Say goodbye to the depravation of yesterday.", "If you get tired, learn to rest, not to quit.",
                            "You are not brave, no one for you to be strong.", "Quitters never win and winners never quit.", "Victory won't come to me unless I go to it.",
                            "Try your best when you are young.Never regret.", "Youth gives you light please don't let it down." , "Achievement provides the only real pleasure in life."};

            Random I = new Random();
            int i = I.Next(0, 20);
            tip.Text ="Click Here To Continue\r\n\r\n"+ "Tip:"+txt[i];
        }

        private void weather_Click(object sender, EventArgs e)
        {
            l1_click(null, null);
        }

        private void rss_Click(object sender, EventArgs e)
        {
            p_rss_Click(null, null);
        }

        int flag = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 0)
                flag++;
            else
                flag = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                flag++;
            else
                flag = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == 2)
                flag++;
            else
                flag = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 3)
            {
                flag = 0;
                web();
            }
            else
                flag = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cef.Shutdown();
            Application.Restart();
        }

        public void web()
        {
            var browser = new ChromiumWebBrowser("https://zrtech.org/tkk");
            Controls.Add(browser);
            Dock = DockStyle.Fill;
            browser.FrameLoadEnd += webbrowser_FrameLoadEnd;
            browser.BringToFront();
            button5.Visible = true;
            button5.BringToFront();
        }
        void webbrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            ChromiumWebBrowser browser = (ChromiumWebBrowser)sender;
            browser.SetZoomLevel(-4);
        }

        private void title_Load(object sender, EventArgs e)
        {
            signin.ID = 0;
            SyndicationFeed sf = SyndicationFeed.Load(XmlReader.Create("http://www.cctv.com/program/rss/02/01/index.xml"));
            rss.Text = sf.Title.Text + "\r\n";
            int count = 0;
            foreach (SyndicationItem it in sf.Items)
            {
                if (count > 3)
                    break;
                rss.Text += "\r\n---------------------------------------------\r\n";
                rss.Text += it.Title.Text + "\r\n";
                count++;
                Application.DoEvents();
            }

            cn.com.webxml.www1.WeatherWebService w = new cn.com.webxml.www1.WeatherWebService();
            string[] r = w.getWeatherbyCityName("上海");
            weather.Text += r[1] + ":\r\n";
            for (int i = 5; i < 8; i++)
            {
                weather.Text += r[i] + " \r\n";
            }
            weather.Text += r[10] + "\r\n";
            weather_picture.BackgroundImage = new Bitmap(@".\Picture\weather\" + r[8] + ".png");
            common.title = this;
            live2d(null, null);

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.SoundLocation = @".\Picture\V.wav";
            sp.PlayLooping();
        }
    }
}
