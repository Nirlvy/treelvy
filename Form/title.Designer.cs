namespace treelvy
{
    partial class title
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(title));
            this.p_weather = new System.Windows.Forms.Panel();
            this.weather_picture = new System.Windows.Forms.PictureBox();
            this.weather = new System.Windows.Forms.TextBox();
            this.time_panel = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.TextBox();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.next = new System.Windows.Forms.Panel();
            this.tip = new System.Windows.Forms.TextBox();
            this.music_off = new System.Windows.Forms.Panel();
            this.music_on = new System.Windows.Forms.Panel();
            this.timer_live2d = new System.Windows.Forms.Timer(this.components);
            this.timer_tip = new System.Windows.Forms.Timer(this.components);
            this.picture_rss = new System.Windows.Forms.PictureBox();
            this.rss = new System.Windows.Forms.TextBox();
            this.p_rss = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.p_weather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weather_picture)).BeginInit();
            this.time_panel.SuspendLayout();
            this.next.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rss)).BeginInit();
            this.p_rss.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_weather
            // 
            this.p_weather.BackColor = System.Drawing.Color.DimGray;
            this.p_weather.Controls.Add(this.weather_picture);
            this.p_weather.Location = new System.Drawing.Point(240, 20);
            this.p_weather.Name = "p_weather";
            this.p_weather.Size = new System.Drawing.Size(200, 200);
            this.p_weather.TabIndex = 2;
            this.p_weather.Click += new System.EventHandler(this.l1_click);
            // 
            // weather_picture
            // 
            this.weather_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.weather_picture.Enabled = false;
            this.weather_picture.Location = new System.Drawing.Point(25, 25);
            this.weather_picture.Name = "weather_picture";
            this.weather_picture.Size = new System.Drawing.Size(150, 150);
            this.weather_picture.TabIndex = 3;
            this.weather_picture.TabStop = false;
            this.weather_picture.Click += new System.EventHandler(this.weather_picture_Click);
            // 
            // weather
            // 
            this.weather.BackColor = System.Drawing.Color.DimGray;
            this.weather.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weather.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.weather.Location = new System.Drawing.Point(59, 193);
            this.weather.Multiline = true;
            this.weather.Name = "weather";
            this.weather.Size = new System.Drawing.Size(365, 181);
            this.weather.TabIndex = 3;
            this.weather.TabStop = false;
            this.weather.Visible = false;
            this.weather.Click += new System.EventHandler(this.weather_Click);
            // 
            // time_panel
            // 
            this.time_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(154)))), ((int)(((byte)(75)))));
            this.time_panel.Controls.Add(this.time);
            this.time_panel.Location = new System.Drawing.Point(20, 20);
            this.time_panel.Name = "time_panel";
            this.time_panel.Size = new System.Drawing.Size(200, 90);
            this.time_panel.TabIndex = 4;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(154)))), ((int)(((byte)(75)))));
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time.Location = new System.Drawing.Point(17, 23);
            this.time.Multiline = true;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Size = new System.Drawing.Size(168, 46);
            this.time.TabIndex = 0;
            this.time.TabStop = false;
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time.TextChanged += new System.EventHandler(this.time_TextChanged);
            // 
            // timer_time
            // 
            this.timer_time.Enabled = true;
            this.timer_time.Interval = 1000;
            this.timer_time.Tick += new System.EventHandler(this.time_TextChanged);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.next.Controls.Add(this.tip);
            this.next.Location = new System.Drawing.Point(240, 500);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(200, 200);
            this.next.TabIndex = 8;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.tip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tip.Font = new System.Drawing.Font("宋体", 12F);
            this.tip.ForeColor = System.Drawing.Color.White;
            this.tip.Location = new System.Drawing.Point(5, 61);
            this.tip.Multiline = true;
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            this.tip.Size = new System.Drawing.Size(192, 107);
            this.tip.TabIndex = 0;
            this.tip.TabStop = false;
            this.tip.Text = "Click Here To Continue\r\n\r\nTip: Go for it! just do it!";
            this.tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tip.Click += new System.EventHandler(this.tip_Click);
            // 
            // music_off
            // 
            this.music_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(219)))));
            this.music_off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("music_off.BackgroundImage")));
            this.music_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.music_off.ForeColor = System.Drawing.Color.Black;
            this.music_off.Location = new System.Drawing.Point(130, 130);
            this.music_off.Name = "music_off";
            this.music_off.Size = new System.Drawing.Size(90, 90);
            this.music_off.TabIndex = 6;
            this.music_off.Click += new System.EventHandler(this.music_off_Click);
            // 
            // music_on
            // 
            this.music_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(219)))));
            this.music_on.BackgroundImage = global::treelvy.Properties.Resources._24gl_volumeHigh1;
            this.music_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.music_on.Location = new System.Drawing.Point(20, 130);
            this.music_on.Name = "music_on";
            this.music_on.Size = new System.Drawing.Size(90, 90);
            this.music_on.TabIndex = 5;
            this.music_on.Click += new System.EventHandler(this.music_on_Click);
            // 
            // timer_live2d
            // 
            this.timer_live2d.Enabled = true;
            this.timer_live2d.Interval = 1;
            this.timer_live2d.Tick += new System.EventHandler(this.live2d);
            // 
            // timer_tip
            // 
            this.timer_tip.Enabled = true;
            this.timer_tip.Interval = 5000;
            this.timer_tip.Tick += new System.EventHandler(this.tipsw);
            // 
            // picture_rss
            // 
            this.picture_rss.BackgroundImage = global::treelvy.Properties.Resources.rss;
            this.picture_rss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_rss.Enabled = false;
            this.picture_rss.Location = new System.Drawing.Point(25, 26);
            this.picture_rss.Name = "picture_rss";
            this.picture_rss.Size = new System.Drawing.Size(150, 150);
            this.picture_rss.TabIndex = 0;
            this.picture_rss.TabStop = false;
            this.picture_rss.Click += new System.EventHandler(this.picture_rss_Click);
            // 
            // rss
            // 
            this.rss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.rss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rss.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rss.Location = new System.Drawing.Point(60, 344);
            this.rss.Multiline = true;
            this.rss.Name = "rss";
            this.rss.ReadOnly = true;
            this.rss.Size = new System.Drawing.Size(364, 211);
            this.rss.TabIndex = 0;
            this.rss.TabStop = false;
            this.rss.Visible = false;
            this.rss.Click += new System.EventHandler(this.rss_Click);
            // 
            // p_rss
            // 
            this.p_rss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.p_rss.Controls.Add(this.picture_rss);
            this.p_rss.Location = new System.Drawing.Point(240, 255);
            this.p_rss.Name = "p_rss";
            this.p_rss.Size = new System.Drawing.Size(200, 200);
            this.p_rss.TabIndex = 2;
            this.p_rss.Click += new System.EventHandler(this.rss_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(410, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(410, 670);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(0, 670);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 9;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(460, 720);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.next);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.p_weather);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.time_panel);
            this.Controls.Add(this.rss);
            this.Controls.Add(this.p_rss);
            this.Controls.Add(this.music_off);
            this.Controls.Add(this.music_on);
            this.Controls.Add(this.weather);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "title";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "title";
            this.Load += new System.EventHandler(this.title_Load);
            this.p_weather.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weather_picture)).EndInit();
            this.time_panel.ResumeLayout(false);
            this.time_panel.PerformLayout();
            this.next.ResumeLayout(false);
            this.next.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rss)).EndInit();
            this.p_rss.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel p_weather;
        private System.Windows.Forms.PictureBox weather_picture;
        private System.Windows.Forms.TextBox weather;
        private System.Windows.Forms.Panel time_panel;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Timer timer_time;
        private System.Windows.Forms.Panel music_on;
        private System.Windows.Forms.Panel music_off;
        private System.Windows.Forms.Panel next;
        private System.Windows.Forms.Timer timer_live2d;
        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.Timer timer_tip;
        private System.Windows.Forms.PictureBox picture_rss;
        private System.Windows.Forms.TextBox rss;
        private System.Windows.Forms.Panel p_rss;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}