namespace SoppingManaage
{
    partial class Daily_Buy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_show_daily_buy = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_show_weekly_buy = new System.Windows.Forms.Button();
            this.btn_show_yearly_buy = new System.Windows.Forms.Button();
            this.btn_show_monthly_buy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1020, 466);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_show_daily_buy
            // 
            this.btn_show_daily_buy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_daily_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_daily_buy.Location = new System.Drawing.Point(420, 3);
            this.btn_show_daily_buy.Name = "btn_show_daily_buy";
            this.btn_show_daily_buy.Size = new System.Drawing.Size(202, 42);
            this.btn_show_daily_buy.TabIndex = 1;
            this.btn_show_daily_buy.Text = "Show Daily Buy";
            this.btn_show_daily_buy.UseVisualStyleBackColor = true;
            this.btn_show_daily_buy.Click += new System.EventHandler(this.btn_show_daily_buy_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(377, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // btn_show_weekly_buy
            // 
            this.btn_show_weekly_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_weekly_buy.Location = new System.Drawing.Point(28, 3);
            this.btn_show_weekly_buy.Name = "btn_show_weekly_buy";
            this.btn_show_weekly_buy.Size = new System.Drawing.Size(315, 42);
            this.btn_show_weekly_buy.TabIndex = 6;
            this.btn_show_weekly_buy.Text = "Show Buy betwwen Two Date";
            this.btn_show_weekly_buy.UseVisualStyleBackColor = true;
            this.btn_show_weekly_buy.Click += new System.EventHandler(this.btn_show_weekly_buy_Click);
            // 
            // btn_show_yearly_buy
            // 
            this.btn_show_yearly_buy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_yearly_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_yearly_buy.Location = new System.Drawing.Point(830, 3);
            this.btn_show_yearly_buy.Name = "btn_show_yearly_buy";
            this.btn_show_yearly_buy.Size = new System.Drawing.Size(202, 42);
            this.btn_show_yearly_buy.TabIndex = 7;
            this.btn_show_yearly_buy.Text = "Show Yearly Buy";
            this.btn_show_yearly_buy.UseVisualStyleBackColor = true;
            // 
            // btn_show_monthly_buy
            // 
            this.btn_show_monthly_buy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_monthly_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_monthly_buy.Location = new System.Drawing.Point(625, 3);
            this.btn_show_monthly_buy.Name = "btn_show_monthly_buy";
            this.btn_show_monthly_buy.Size = new System.Drawing.Size(202, 42);
            this.btn_show_monthly_buy.TabIndex = 8;
            this.btn_show_monthly_buy.Text = "Show Monthly Buy";
            this.btn_show_monthly_buy.UseVisualStyleBackColor = true;
            this.btn_show_monthly_buy.Click += new System.EventHandler(this.btn_show_monthly_buy_Click);
            // 
            // Daily_Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1032, 559);
            this.Controls.Add(this.btn_show_monthly_buy);
            this.Controls.Add(this.btn_show_yearly_buy);
            this.Controls.Add(this.btn_show_weekly_buy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_show_daily_buy);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Daily_Buy";
            this.Text = "Daily_Buy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_show_daily_buy;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_show_weekly_buy;
        private System.Windows.Forms.Button btn_show_yearly_buy;
        private System.Windows.Forms.Button btn_show_monthly_buy;
    }
}