namespace treelvy
{
    partial class user_manager
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
            this.tip1 = new System.Windows.Forms.Label();
            this.text_go = new System.Windows.Forms.Label();
            this.text_health = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.PictureBox();
            this.health = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.door = new System.Windows.Forms.Timer(this.components);
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.healtext = new System.Windows.Forms.TextBox();
            this.gotext = new System.Windows.Forms.TextBox();
            this.tip2 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.go)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health)).BeginInit();
            this.SuspendLayout();
            // 
            // tip1
            // 
            this.tip1.AutoSize = true;
            this.tip1.BackColor = System.Drawing.Color.Transparent;
            this.tip1.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tip1.Location = new System.Drawing.Point(163, 15);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(133, 29);
            this.tip1.TabIndex = 0;
            this.tip1.Text = "用户信息";
            // 
            // text_go
            // 
            this.text_go.AutoSize = true;
            this.text_go.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_go.ForeColor = System.Drawing.Color.Black;
            this.text_go.Location = new System.Drawing.Point(173, 568);
            this.text_go.Name = "text_go";
            this.text_go.Size = new System.Drawing.Size(100, 29);
            this.text_go.TabIndex = 1;
            this.text_go.Text = "出行码";
            // 
            // text_health
            // 
            this.text_health.AutoSize = true;
            this.text_health.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_health.ForeColor = System.Drawing.Color.Black;
            this.text_health.Location = new System.Drawing.Point(173, 265);
            this.text_health.Name = "text_health";
            this.text_health.Size = new System.Drawing.Size(100, 29);
            this.text_health.TabIndex = 1;
            this.text_health.Text = "健康码";
            // 
            // go
            // 
            this.go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.go.Location = new System.Drawing.Point(125, 360);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(200, 200);
            this.go.TabIndex = 0;
            this.go.TabStop = false;
            // 
            // health
            // 
            this.health.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.health.Location = new System.Drawing.Point(133, 54);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(200, 200);
            this.health.TabIndex = 0;
            this.health.TabStop = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.Color.DodgerBlue;
            this.back.Location = new System.Drawing.Point(184, 692);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "返回首页";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // door
            // 
            this.door.Enabled = true;
            this.door.Interval = 1000;
            this.door.Tick += new System.EventHandler(this.counttime);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT   tbl_door.*\r\nFROM      tbl_door";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=treelvy;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [tbl_door] ([door]) VALUES (@door)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@door", System.Data.SqlDbType.Int, 0, "door")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tbl_door", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("door", "door")})});
            // 
            // healtext
            // 
            this.healtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.healtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.healtext.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.healtext.ForeColor = System.Drawing.Color.White;
            this.healtext.Location = new System.Drawing.Point(23, 305);
            this.healtext.Multiline = true;
            this.healtext.Name = "healtext";
            this.healtext.ReadOnly = true;
            this.healtext.Size = new System.Drawing.Size(411, 43);
            this.healtext.TabIndex = 3;
            this.healtext.TabStop = false;
            this.healtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gotext
            // 
            this.gotext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gotext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gotext.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gotext.ForeColor = System.Drawing.Color.White;
            this.gotext.Location = new System.Drawing.Point(23, 607);
            this.gotext.Multiline = true;
            this.gotext.Name = "gotext";
            this.gotext.ReadOnly = true;
            this.gotext.Size = new System.Drawing.Size(411, 46);
            this.gotext.TabIndex = 3;
            this.gotext.TabStop = false;
            this.gotext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tip2
            // 
            this.tip2.AutoSize = true;
            this.tip2.Font = new System.Drawing.Font("宋体", 10F);
            this.tip2.ForeColor = System.Drawing.Color.White;
            this.tip2.Location = new System.Drawing.Point(122, 665);
            this.tip2.Name = "tip2";
            this.tip2.Size = new System.Drawing.Size(217, 14);
            this.tip2.TabIndex = 4;
            this.tip2.Text = "将于    秒后返回首页并重新上锁";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("宋体", 10F);
            this.count.ForeColor = System.Drawing.Color.White;
            this.count.Location = new System.Drawing.Point(156, 664);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(21, 14);
            this.count.TabIndex = 5;
            this.count.Text = "10";
            // 
            // user_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(460, 720);
            this.Controls.Add(this.count);
            this.Controls.Add(this.tip2);
            this.Controls.Add(this.gotext);
            this.Controls.Add(this.healtext);
            this.Controls.Add(this.back);
            this.Controls.Add(this.text_go);
            this.Controls.Add(this.go);
            this.Controls.Add(this.text_health);
            this.Controls.Add(this.tip1);
            this.Controls.Add(this.health);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user_manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user_manager";
            ((System.ComponentModel.ISupportInitialize)(this.go)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.Label text_go;
        private System.Windows.Forms.Label text_health;
        private System.Windows.Forms.PictureBox go;
        private System.Windows.Forms.PictureBox health;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Timer door;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.TextBox healtext;
        private System.Windows.Forms.TextBox gotext;
        private System.Windows.Forms.Label tip2;
        private System.Windows.Forms.Label count;
    }
}