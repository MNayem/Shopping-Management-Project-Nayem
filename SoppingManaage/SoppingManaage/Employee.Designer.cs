namespace SoppingManaage
{
    partial class Employee
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
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Emname = new System.Windows.Forms.TextBox();
            this.txt_Emid = new System.Windows.Forms.TextBox();
            this.txt_Emqulification = new System.Windows.Forms.TextBox();
            this.txt_Emaddress = new System.Windows.Forms.TextBox();
            this.txt_Empost = new System.Windows.Forms.TextBox();
            this.txt_Emsalary = new System.Windows.Forms.TextBox();
            this.employeePicture = new System.Windows.Forms.PictureBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.txt_Emjoindate = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightGreen;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(969, 484);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(79, 34);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emplopyee id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee Qualiofication : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Employee Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Employee Post :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Employe Joim Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Employee Salary :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(252, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(512, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Add New Employee and View the Profile of Employee";
            // 
            // txt_Emname
            // 
            this.txt_Emname.Location = new System.Drawing.Point(200, 149);
            this.txt_Emname.Multiline = true;
            this.txt_Emname.Name = "txt_Emname";
            this.txt_Emname.Size = new System.Drawing.Size(200, 26);
            this.txt_Emname.TabIndex = 10;
            // 
            // txt_Emid
            // 
            this.txt_Emid.Location = new System.Drawing.Point(200, 104);
            this.txt_Emid.Multiline = true;
            this.txt_Emid.Name = "txt_Emid";
            this.txt_Emid.Size = new System.Drawing.Size(132, 26);
            this.txt_Emid.TabIndex = 11;
            // 
            // txt_Emqulification
            // 
            this.txt_Emqulification.Location = new System.Drawing.Point(200, 193);
            this.txt_Emqulification.Multiline = true;
            this.txt_Emqulification.Name = "txt_Emqulification";
            this.txt_Emqulification.Size = new System.Drawing.Size(200, 26);
            this.txt_Emqulification.TabIndex = 12;
            // 
            // txt_Emaddress
            // 
            this.txt_Emaddress.Location = new System.Drawing.Point(200, 239);
            this.txt_Emaddress.Multiline = true;
            this.txt_Emaddress.Name = "txt_Emaddress";
            this.txt_Emaddress.Size = new System.Drawing.Size(200, 26);
            this.txt_Emaddress.TabIndex = 13;
            // 
            // txt_Empost
            // 
            this.txt_Empost.Location = new System.Drawing.Point(200, 284);
            this.txt_Empost.Multiline = true;
            this.txt_Empost.Name = "txt_Empost";
            this.txt_Empost.Size = new System.Drawing.Size(200, 26);
            this.txt_Empost.TabIndex = 15;
            // 
            // txt_Emsalary
            // 
            this.txt_Emsalary.Location = new System.Drawing.Point(200, 388);
            this.txt_Emsalary.Multiline = true;
            this.txt_Emsalary.Name = "txt_Emsalary";
            this.txt_Emsalary.Size = new System.Drawing.Size(132, 26);
            this.txt_Emsalary.TabIndex = 16;
            // 
            // employeePicture
            // 
            this.employeePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeePicture.Location = new System.Drawing.Point(714, 104);
            this.employeePicture.Name = "employeePicture";
            this.employeePicture.Size = new System.Drawing.Size(191, 206);
            this.employeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeePicture.TabIndex = 18;
            this.employeePicture.TabStop = false;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.LightGreen;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Location = new System.Drawing.Point(714, 323);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(191, 39);
            this.btn_browse.TabIndex = 19;
            this.btn_browse.Text = "Browse Picture";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LightGreen;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(714, 375);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 39);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.LightGreen;
            this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(814, 375);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(91, 39);
            this.btn_show.TabIndex = 21;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // txt_Emjoindate
            // 
            this.txt_Emjoindate.Location = new System.Drawing.Point(200, 337);
            this.txt_Emjoindate.Multiline = true;
            this.txt_Emjoindate.Name = "txt_Emjoindate";
            this.txt_Emjoindate.Size = new System.Drawing.Size(200, 26);
            this.txt_Emjoindate.TabIndex = 22;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightGreen;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(768, 420);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 37);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1053, 521);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_Emjoindate);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.employeePicture);
            this.Controls.Add(this.txt_Emsalary);
            this.Controls.Add(this.txt_Empost);
            this.Controls.Add(this.txt_Emaddress);
            this.Controls.Add(this.txt_Emqulification);
            this.Controls.Add(this.txt_Emid);
            this.Controls.Add(this.txt_Emname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.employeePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Emname;
        private System.Windows.Forms.TextBox txt_Emid;
        private System.Windows.Forms.TextBox txt_Emqulification;
        private System.Windows.Forms.TextBox txt_Emaddress;
        private System.Windows.Forms.TextBox txt_Empost;
        private System.Windows.Forms.TextBox txt_Emsalary;
        private System.Windows.Forms.PictureBox employeePicture;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox txt_Emjoindate;
        private System.Windows.Forms.Button btn_delete;
    }
}