namespace RentalManagement
{
    partial class Rental
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FeesTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RentDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CarRegCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RentDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.CustCb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1532, 139);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentalManagement.Properties.Resources.bugattiCar;
            this.pictureBox1.Location = new System.Drawing.Point(31, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1479, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(537, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(491, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // FeesTb
            // 
            this.FeesTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesTb.Location = new System.Drawing.Point(278, 558);
            this.FeesTb.Name = "FeesTb";
            this.FeesTb.Size = new System.Drawing.Size(234, 42);
            this.FeesTb.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(71, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 31);
            this.label5.TabIndex = 63;
            this.label5.Text = "Fees";
            // 
            // RentDGV
            // 
            this.RentDGV.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.RentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentDGV.Location = new System.Drawing.Point(677, 214);
            this.RentDGV.Name = "RentDGV";
            this.RentDGV.RowHeadersVisible = false;
            this.RentDGV.RowHeadersWidth = 72;
            this.RentDGV.RowTemplate.Height = 31;
            this.RentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RentDGV.Size = new System.Drawing.Size(685, 427);
            this.RentDGV.TabIndex = 62;
            this.RentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentDGV_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(681, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 31);
            this.label6.TabIndex = 61;
            this.label6.Text = "Cars on Rent";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(278, 611);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 67);
            this.button4.TabIndex = 60;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(50, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 67);
            this.button1.TabIndex = 57;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IdTb
            // 
            this.IdTb.BackColor = System.Drawing.Color.White;
            this.IdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTb.Location = new System.Drawing.Point(275, 167);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(234, 42);
            this.IdTb.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(72, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 31);
            this.label4.TabIndex = 55;
            this.label4.Text = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(68, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 31);
            this.label8.TabIndex = 52;
            this.label8.Text = "Rental Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(71, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 31);
            this.label7.TabIndex = 51;
            this.label7.Text = "CustId";
            // 
            // CarRegCb
            // 
            this.CarRegCb.ForeColor = System.Drawing.Color.OrangeRed;
            this.CarRegCb.FormattingEnabled = true;
            this.CarRegCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CarRegCb.Location = new System.Drawing.Point(275, 242);
            this.CarRegCb.Name = "CarRegCb";
            this.CarRegCb.Size = new System.Drawing.Size(234, 33);
            this.CarRegCb.TabIndex = 65;
            this.CarRegCb.SelectedIndexChanged += new System.EventHandler(this.CarRegCb_SelectedIndexChanged);
            this.CarRegCb.SelectionChangeCommitted += new System.EventHandler(this.CarRegCb_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(68, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 31);
            this.label9.TabIndex = 66;
            this.label9.Text = "CarReg";
            // 
            // CustNameTb
            // 
            this.CustNameTb.BackColor = System.Drawing.Color.White;
            this.CustNameTb.Enabled = false;
            this.CustNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTb.Location = new System.Drawing.Point(275, 376);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(234, 42);
            this.CustNameTb.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(72, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 31);
            this.label10.TabIndex = 68;
            this.label10.Text = "Name";
            // 
            // RentDate
            // 
            this.RentDate.CalendarTitleBackColor = System.Drawing.Color.OrangeRed;
            this.RentDate.Location = new System.Drawing.Point(278, 446);
            this.RentDate.Name = "RentDate";
            this.RentDate.Size = new System.Drawing.Size(234, 31);
            this.RentDate.TabIndex = 69;
            // 
            // ReturnDate
            // 
            this.ReturnDate.CalendarTitleBackColor = System.Drawing.Color.OrangeRed;
            this.ReturnDate.Location = new System.Drawing.Point(275, 506);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(234, 31);
            this.ReturnDate.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Location = new System.Drawing.Point(68, 504);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 31);
            this.label11.TabIndex = 70;
            this.label11.Text = "Return Date";
            // 
            // CustCb
            // 
            this.CustCb.ForeColor = System.Drawing.Color.OrangeRed;
            this.CustCb.FormattingEnabled = true;
            this.CustCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CustCb.Location = new System.Drawing.Point(275, 309);
            this.CustCb.Name = "CustCb";
            this.CustCb.Size = new System.Drawing.Size(234, 33);
            this.CustCb.TabIndex = 72;
            this.CustCb.SelectionChangeCommitted += new System.EventHandler(this.CustCb_SelectionChangeCommitted);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 757);
            this.Controls.Add(this.CustCb);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RentDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CustNameTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CarRegCb);
            this.Controls.Add(this.FeesTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RentDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FeesTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView RentDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CarRegCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker RentDate;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CustCb;
    }
}