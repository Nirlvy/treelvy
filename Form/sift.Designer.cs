namespace treelvy
{
    partial class sift
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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.provience = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataView.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.GridColor = System.Drawing.Color.DimGray;
            this.dataView.Location = new System.Drawing.Point(9, 67);
            this.dataView.Margin = new System.Windows.Forms.Padding(2);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowTemplate.Height = 27;
            this.dataView.Size = new System.Drawing.Size(394, 347);
            this.dataView.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("??????", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.title.Location = new System.Drawing.Point(140, 19);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(133, 29);
            this.title.TabIndex = 2;
            this.title.Text = "????????????";
            // 
            // provience
            // 
            this.provience.AutoSize = true;
            this.provience.Font = new System.Drawing.Font("??????", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.provience.ForeColor = System.Drawing.Color.White;
            this.provience.Location = new System.Drawing.Point(86, 430);
            this.provience.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.provience.Name = "provience";
            this.provience.Size = new System.Drawing.Size(80, 16);
            this.provience.TabIndex = 2;
            this.provience.Text = "????????????:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("??????", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(86, 475);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(80, 16);
            this.time.TabIndex = 2;
            this.time.Text = "????????????:";
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.White;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "??????",
            "?????????",
            "?????????",
            "?????????",
            "?????????",
            "?????????",
            "?????????",
            "?????????",
            "?????????",
            "????????????",
            "?????????",
            "?????????",
            "?????????",
            "????????????????????????",
            "?????????",
            "?????????",
            "?????????",
            "?????????",
            "?????????????????????",
            "?????????",
            "?????????",
            "??????????????????",
            "?????????",
            "?????????",
            "?????????",
            "?????????",
            "?????????",
            "?????????",
            "???????????????",
            "?????????",
            "?????????????????????",
            "?????????",
            "?????????",
            "?????????????????????",
            "?????????????????????"});
            this.comboBox.Location = new System.Drawing.Point(181, 427);
            this.comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(152, 20);
            this.comboBox.TabIndex = 3;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(181, 471);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(152, 21);
            this.textBox.TabIndex = 4;
            this.textBox.Click += new System.EventHandler(this.date);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("??????", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.search.Location = new System.Drawing.Point(161, 520);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(81, 28);
            this.search.TabIndex = 0;
            this.search.Text = "????????????";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.Color.DimGray;
            this.monthCalendar.Location = new System.Drawing.Point(181, 471);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 5;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.select);
            // 
            // sift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(414, 648);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.time);
            this.Controls.Add(this.provience);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "sift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "filtrate";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label provience;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}