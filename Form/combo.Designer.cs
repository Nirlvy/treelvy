
namespace treelvy
{
    partial class combo
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
            this.panel = new System.Windows.Forms.Panel();
            this.manager_user = new System.Windows.Forms.Button();
            this.area = new System.Windows.Forms.Button();
            this.sift = new System.Windows.Forms.Button();
            this.now = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DimGray;
            this.panel.Location = new System.Drawing.Point(23, 46);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(414, 648);
            this.panel.TabIndex = 0;
            // 
            // manager_user
            // 
            this.manager_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.manager_user.FlatAppearance.BorderSize = 0;
            this.manager_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager_user.ForeColor = System.Drawing.Color.Gainsboro;
            this.manager_user.Location = new System.Drawing.Point(23, 23);
            this.manager_user.Name = "manager_user";
            this.manager_user.Size = new System.Drawing.Size(75, 23);
            this.manager_user.TabIndex = 1;
            this.manager_user.Text = "用户管理";
            this.manager_user.UseVisualStyleBackColor = false;
            this.manager_user.Click += new System.EventHandler(this.manager_user_Click);
            // 
            // area
            // 
            this.area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.area.FlatAppearance.BorderSize = 0;
            this.area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.area.ForeColor = System.Drawing.Color.Gainsboro;
            this.area.Location = new System.Drawing.Point(98, 23);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(75, 23);
            this.area.TabIndex = 1;
            this.area.Text = "地区情况";
            this.area.UseVisualStyleBackColor = false;
            this.area.Click += new System.EventHandler(this.area_Click);
            // 
            // sift
            // 
            this.sift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sift.FlatAppearance.BorderSize = 0;
            this.sift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sift.ForeColor = System.Drawing.Color.Gainsboro;
            this.sift.Location = new System.Drawing.Point(173, 23);
            this.sift.Name = "sift";
            this.sift.Size = new System.Drawing.Size(75, 23);
            this.sift.TabIndex = 1;
            this.sift.Text = "流调筛查";
            this.sift.UseVisualStyleBackColor = false;
            this.sift.Click += new System.EventHandler(this.sift_Click);
            // 
            // now
            // 
            this.now.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.now.FlatAppearance.BorderSize = 0;
            this.now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.now.ForeColor = System.Drawing.Color.Gainsboro;
            this.now.Location = new System.Drawing.Point(248, 23);
            this.now.Name = "now";
            this.now.Size = new System.Drawing.Size(75, 23);
            this.now.TabIndex = 1;
            this.now.Text = "地区人员";
            this.now.UseVisualStyleBackColor = false;
            this.now.Click += new System.EventHandler(this.now_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.Color.Gainsboro;
            this.back.Location = new System.Drawing.Point(323, 23);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(460, 720);
            this.Controls.Add(this.back);
            this.Controls.Add(this.now);
            this.Controls.Add(this.sift);
            this.Controls.Add(this.area);
            this.Controls.Add(this.manager_user);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "combo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "combo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button manager_user;
        private System.Windows.Forms.Button area;
        private System.Windows.Forms.Button sift;
        private System.Windows.Forms.Button now;
        private System.Windows.Forms.Button back;
    }
}