
namespace treelvy
{
    partial class now
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tip1 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.provience = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tip1
            // 
            this.tip1.AutoSize = true;
            this.tip1.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tip1.Location = new System.Drawing.Point(140, 20);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(133, 29);
            this.tip1.TabIndex = 1;
            this.tip1.Text = "地区人员";
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataView.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.GridColor = System.Drawing.Color.DimGray;
            this.dataView.Location = new System.Drawing.Point(12, 73);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowTemplate.Height = 23;
            this.dataView.Size = new System.Drawing.Size(390, 335);
            this.dataView.TabIndex = 2;
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.White;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "北京市",
            "天津市",
            "上海市",
            "重庆市",
            "河北省",
            "河南省",
            "云南省",
            "辽宁省",
            "黑龙江省",
            "湖南省",
            "安徽省",
            "山东省",
            "新疆维吾尔自治区",
            "江苏省",
            "浙江省",
            "江西省",
            "湖北省",
            "广西壮族自治区",
            "甘肃省",
            "山西省",
            "内蒙古自治区",
            "陕西省",
            "吉林省",
            "福建省",
            "贵州省",
            "广东省",
            "青海省",
            "西藏自治区",
            "四川省",
            "宁夏回族自治区",
            "海南省",
            "台湾省",
            "香港特别行政区",
            "澳门特别行政区"});
            this.comboBox.Location = new System.Drawing.Point(176, 439);
            this.comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(152, 20);
            this.comboBox.TabIndex = 5;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.alter);
            // 
            // provience
            // 
            this.provience.AutoSize = true;
            this.provience.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.provience.ForeColor = System.Drawing.Color.White;
            this.provience.Location = new System.Drawing.Point(81, 442);
            this.provience.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.provience.Name = "provience";
            this.provience.Size = new System.Drawing.Size(80, 16);
            this.provience.TabIndex = 4;
            this.provience.Text = "查询省份:";
            // 
            // chart
            // 
            this.chart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(12, 479);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(390, 157);
            this.chart.TabIndex = 7;
            this.chart.Text = "chart1";
            this.chart.Visible = false;
            // 
            // now
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(414, 648);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.provience);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.tip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "now";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "now";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label provience;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}