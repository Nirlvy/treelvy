
namespace treelvy
{
    partial class area
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.health = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tip1
            // 
            this.tip1.AutoSize = true;
            this.tip1.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tip1.Location = new System.Drawing.Point(142, 19);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(133, 29);
            this.tip1.TabIndex = 0;
            this.tip1.Text = "地区情况";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(390, 509);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // health
            // 
            this.health.FlatAppearance.BorderSize = 0;
            this.health.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.health.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.health.ForeColor = System.Drawing.Color.DodgerBlue;
            this.health.Location = new System.Drawing.Point(28, 616);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(75, 23);
            this.health.TabIndex = 2;
            this.health.Text = "健康码";
            this.health.UseVisualStyleBackColor = true;
            this.health.Click += new System.EventHandler(this.health_Click);
            // 
            // go
            // 
            this.go.FlatAppearance.BorderSize = 0;
            this.go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.go.ForeColor = System.Drawing.Color.DodgerBlue;
            this.go.Location = new System.Drawing.Point(313, 616);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 3;
            this.go.Text = "出行码";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // save
            // 
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.ForeColor = System.Drawing.Color.DodgerBlue;
            this.save.Location = new System.Drawing.Point(171, 616);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 5;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(414, 648);
            this.Controls.Add(this.save);
            this.Controls.Add(this.go);
            this.Controls.Add(this.health);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "area";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "area";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button health;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button save;
    }
}