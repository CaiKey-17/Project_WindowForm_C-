namespace Project_CNPM
{
    partial class BS_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BS_Appointment));
            this.dateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.doctor = new Guna.UI2.WinForms.Guna2Button();
            this.ca = new Guna.UI2.WinForms.Guna2ComboBox();
            this.benhnhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDone = new Guna.UI2.WinForms.Guna2Button();
            this.lbDoctor = new System.Windows.Forms.Label();
            this.lbWork = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbPatient = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSTT = new System.Windows.Forms.Panel();
            this.lbForm = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelSTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.Checked = true;
            this.dateTime.FillColor = System.Drawing.Color.White;
            this.dateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTime.Location = new System.Drawing.Point(82, 75);
            this.dateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(182, 36);
            this.dateTime.TabIndex = 13;
            this.dateTime.Value = new System.DateTime(2024, 4, 20, 16, 55, 55, 544);
            // 
            // doctor
            // 
            this.doctor.BackColor = System.Drawing.Color.White;
            this.doctor.BorderThickness = 1;
            this.doctor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.doctor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.doctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.doctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.doctor.FillColor = System.Drawing.Color.White;
            this.doctor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.doctor.ForeColor = System.Drawing.Color.Black;
            this.doctor.Location = new System.Drawing.Point(82, 164);
            this.doctor.Name = "doctor";
            this.doctor.PressedColor = System.Drawing.Color.White;
            this.doctor.Size = new System.Drawing.Size(182, 32);
            this.doctor.TabIndex = 12;
            this.doctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ca
            // 
            this.ca.BackColor = System.Drawing.Color.Transparent;
            this.ca.BorderColor = System.Drawing.Color.Black;
            this.ca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ca.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ca.ItemHeight = 30;
            this.ca.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ca.Location = new System.Drawing.Point(82, 122);
            this.ca.Name = "ca";
            this.ca.Size = new System.Drawing.Size(182, 36);
            this.ca.TabIndex = 11;
            // 
            // benhnhan
            // 
            this.benhnhan.BackColor = System.Drawing.Color.White;
            this.benhnhan.BorderThickness = 1;
            this.benhnhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.benhnhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.benhnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.benhnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.benhnhan.FillColor = System.Drawing.Color.White;
            this.benhnhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.benhnhan.ForeColor = System.Drawing.Color.Black;
            this.benhnhan.Location = new System.Drawing.Point(82, 37);
            this.benhnhan.Name = "benhnhan";
            this.benhnhan.PressedColor = System.Drawing.Color.White;
            this.benhnhan.Size = new System.Drawing.Size(182, 32);
            this.benhnhan.TabIndex = 10;
            this.benhnhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.benhnhan.Click += new System.EventHandler(this.benhnhan_Click);
            // 
            // btnDone
            // 
            this.btnDone.BorderRadius = 7;
            this.btnDone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(173)))), ((int)(((byte)(84)))));
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(173, 198);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(92, 34);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "XÁC NHẬN";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lbDoctor
            // 
            this.lbDoctor.AutoSize = true;
            this.lbDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoctor.Location = new System.Drawing.Point(12, 171);
            this.lbDoctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDoctor.Name = "lbDoctor";
            this.lbDoctor.Size = new System.Drawing.Size(40, 15);
            this.lbDoctor.TabIndex = 4;
            this.lbDoctor.Text = "Bác sĩ:";
            // 
            // lbWork
            // 
            this.lbWork.AutoSize = true;
            this.lbWork.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWork.Location = new System.Drawing.Point(13, 127);
            this.lbWork.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWork.Name = "lbWork";
            this.lbWork.Size = new System.Drawing.Size(23, 15);
            this.lbWork.TabIndex = 3;
            this.lbWork.Text = "Ca:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(13, 86);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(38, 15);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Ngày:";
            // 
            // lbPatient
            // 
            this.lbPatient.AutoSize = true;
            this.lbPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatient.Location = new System.Drawing.Point(13, 44);
            this.lbPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPatient.Name = "lbPatient";
            this.lbPatient.Size = new System.Drawing.Size(67, 15);
            this.lbPatient.TabIndex = 1;
            this.lbPatient.Text = "Bệnh nhân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "STT";
            // 
            // panelSTT
            // 
            this.panelSTT.BackColor = System.Drawing.Color.White;
            this.panelSTT.Controls.Add(this.dateTime);
            this.panelSTT.Controls.Add(this.doctor);
            this.panelSTT.Controls.Add(this.ca);
            this.panelSTT.Controls.Add(this.benhnhan);
            this.panelSTT.Controls.Add(this.btnDone);
            this.panelSTT.Controls.Add(this.lbDoctor);
            this.panelSTT.Controls.Add(this.lbWork);
            this.panelSTT.Controls.Add(this.lbDate);
            this.panelSTT.Controls.Add(this.lbPatient);
            this.panelSTT.Controls.Add(this.label2);
            this.panelSTT.Location = new System.Drawing.Point(133, 103);
            this.panelSTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSTT.Name = "panelSTT";
            this.panelSTT.Size = new System.Drawing.Size(274, 235);
            this.panelSTT.TabIndex = 13;
            // 
            // lbForm
            // 
            this.lbForm.AutoSize = true;
            this.lbForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.lbForm.Location = new System.Drawing.Point(9, 7);
            this.lbForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbForm.Name = "lbForm";
            this.lbForm.Size = new System.Drawing.Size(199, 32);
            this.lbForm.TabIndex = 12;
            this.lbForm.Text = "THÊM LỊCH HẸN";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(550, 417);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // BS_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 417);
            this.Controls.Add(this.panelSTT);
            this.Controls.Add(this.lbForm);
            this.Controls.Add(this.guna2PictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 456);
            this.MinimumSize = new System.Drawing.Size(566, 456);
            this.Name = "BS_Appointment";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm lịch hẹn";
            this.Load += new System.EventHandler(this.BS_Appointment_Load);
            this.panelSTT.ResumeLayout(false);
            this.panelSTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTime;
        private Guna.UI2.WinForms.Guna2Button doctor;
        private Guna.UI2.WinForms.Guna2ComboBox ca;
        private Guna.UI2.WinForms.Guna2Button benhnhan;
        private Guna.UI2.WinForms.Guna2Button btnDone;
        private System.Windows.Forms.Label lbDoctor;
        private System.Windows.Forms.Label lbWork;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSTT;
        private System.Windows.Forms.Label lbForm;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}