namespace treelvy
{
    partial class manager
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
            this.tip1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.Panel();
            this.manage = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.Button();
            this.door = new System.Windows.Forms.Button();
            this.now = new System.Windows.Forms.Button();
            this.area = new System.Windows.Forms.Button();
            this.signin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tip1
            // 
            this.tip1.AutoSize = true;
            this.tip1.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tip1.Location = new System.Drawing.Point(149, 22);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(163, 29);
            this.tip1.TabIndex = 0;
            this.tip1.Text = "管理员页面";
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.Color.DodgerBlue;
            this.back.Location = new System.Drawing.Point(193, 688);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 5;
            this.back.Text = "返回主页";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.DimGray;
            this.background.Location = new System.Drawing.Point(24, 71);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(413, 608);
            this.background.TabIndex = 6;
            // 
            // manage
            // 
            this.manage.BackColor = System.Drawing.Color.DimGray;
            this.manage.BackgroundImage = global::treelvy.Properties.Resources.查找用户;
            this.manage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.manage.FlatAppearance.BorderSize = 0;
            this.manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manage.Location = new System.Drawing.Point(274, 90);
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(150, 150);
            this.manage.TabIndex = 4;
            this.manage.UseVisualStyleBackColor = false;
            this.manage.Click += new System.EventHandler(this.manage_Click);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.DimGray;
            this.screen.BackgroundImage = global::treelvy.Properties.Resources.折线图;
            this.screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.screen.FlatAppearance.BorderSize = 0;
            this.screen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screen.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.screen.Location = new System.Drawing.Point(274, 316);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(150, 150);
            this.screen.TabIndex = 3;
            this.screen.UseVisualStyleBackColor = false;
            this.screen.Click += new System.EventHandler(this.screen_Click);
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.DimGray;
            this.door.BackgroundImage = global::treelvy.Properties.Resources.开关门;
            this.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.door.FlatAppearance.BorderSize = 0;
            this.door.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.door.Location = new System.Drawing.Point(274, 508);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(150, 150);
            this.door.TabIndex = 2;
            this.door.UseVisualStyleBackColor = false;
            this.door.Click += new System.EventHandler(this.door_Click);
            // 
            // now
            // 
            this.now.BackColor = System.Drawing.Color.DimGray;
            this.now.BackgroundImage = global::treelvy.Properties.Resources._02菜单_高危地区人员分析;
            this.now.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.now.FlatAppearance.BorderSize = 0;
            this.now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.now.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.now.Location = new System.Drawing.Point(38, 508);
            this.now.Name = "now";
            this.now.Size = new System.Drawing.Size(150, 150);
            this.now.TabIndex = 2;
            this.now.UseVisualStyleBackColor = false;
            this.now.Click += new System.EventHandler(this.now_Click);
            // 
            // area
            // 
            this.area.BackColor = System.Drawing.Color.DimGray;
            this.area.BackgroundImage = global::treelvy.Properties.Resources.表_表格_jurassic;
            this.area.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.area.Cursor = System.Windows.Forms.Cursors.Default;
            this.area.FlatAppearance.BorderSize = 0;
            this.area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.area.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.area.Location = new System.Drawing.Point(38, 316);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(150, 150);
            this.area.TabIndex = 2;
            this.area.UseVisualStyleBackColor = false;
            this.area.Click += new System.EventHandler(this.area_Click);
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.DimGray;
            this.signin.BackgroundImage = global::treelvy.Properties.Resources.添加用户;
            this.signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signin.FlatAppearance.BorderSize = 0;
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.signin.Location = new System.Drawing.Point(38, 90);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(150, 150);
            this.signin.TabIndex = 1;
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.create_Click);
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(460, 720);
            this.Controls.Add(this.back);
            this.Controls.Add(this.manage);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.door);
            this.Controls.Add(this.now);
            this.Controls.Add(this.area);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.tip1);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button area;
        private System.Windows.Forms.Button screen;
        private System.Windows.Forms.Button manage;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button now;
        private System.Windows.Forms.Button door;
        private System.Windows.Forms.Panel background;
    }
}