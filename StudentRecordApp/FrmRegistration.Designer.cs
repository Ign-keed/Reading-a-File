namespace StudentRecordApp
{
    partial class FrmRegistration
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.cboProgram = new System.Windows.Forms.ComboBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMI = new System.Windows.Forms.Label();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registration";
            //
            // lblStudentNo
            //
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(30, 70);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(65, 13);
            this.lblStudentNo.TabIndex = 1;
            this.lblStudentNo.Text = "Student No.";
            //
            // txtStudentNo
            //
            this.txtStudentNo.Location = new System.Drawing.Point(110, 67);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(120, 20);
            this.txtStudentNo.TabIndex = 0;
            //
            // lblProgram
            //
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(250, 70);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(49, 13);
            this.lblProgram.TabIndex = 2;
            this.lblProgram.Text = "Program";
            //
            // cboProgram
            //
            this.cboProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgram.FormattingEnabled = true;
            this.cboProgram.Location = new System.Drawing.Point(310, 67);
            this.cboProgram.Name = "cboProgram";
            this.cboProgram.Size = new System.Drawing.Size(220, 21);
            this.cboProgram.TabIndex = 1;
            //
            // lblLastName
            //
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(30, 105);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            //
            // txtLastName
            //
            this.txtLastName.Location = new System.Drawing.Point(110, 102);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(120, 20);
            this.txtLastName.TabIndex = 2;
            //
            // lblFirstName
            //
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(250, 105);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            //
            // txtFirstName
            //
            this.txtFirstName.Location = new System.Drawing.Point(310, 102);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 20);
            this.txtFirstName.TabIndex = 3;
            //
            // lblMI
            //
            this.lblMI.AutoSize = true;
            this.lblMI.Location = new System.Drawing.Point(460, 105);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(27, 13);
            this.lblMI.TabIndex = 5;
            this.lblMI.Text = "M.I.";
            //
            // txtMI
            //
            this.txtMI.Location = new System.Drawing.Point(490, 102);
            this.txtMI.MaxLength = 1;
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(40, 20);
            this.txtMI.TabIndex = 4;
            //
            // lblAge
            //
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(30, 140);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            //
            // txtAge
            //
            this.txtAge.Location = new System.Drawing.Point(110, 137);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(60, 20);
            this.txtAge.TabIndex = 5;
            //
            // lblGender
            //
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(250, 140);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender:";
            //
            // cboGender
            //
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(310, 137);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(100, 21);
            this.cboGender.TabIndex = 6;
            //
            // lblBirthday
            //
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(30, 178);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblBirthday.TabIndex = 8;
            this.lblBirthday.Text = "Birthday";
            //
            // dtpBirthday
            //
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthday.Location = new System.Drawing.Point(110, 174);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthday.TabIndex = 7;
            //
            // lblContactNo
            //
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(330, 178);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(65, 13);
            this.lblContactNo.TabIndex = 9;
            this.lblContactNo.Text = "Contact No.";
            //
            // txtContactNo
            //
            this.txtContactNo.Location = new System.Drawing.Point(400, 174);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(130, 20);
            this.txtContactNo.TabIndex = 8;
            //
            // btnRegister
            //
            this.btnRegister.Location = new System.Drawing.Point(230, 240);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(95, 30);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            //
            // btnRecords
            //
            this.btnRecords.Location = new System.Drawing.Point(435, 240);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(95, 30);
            this.btnRecords.TabIndex = 10;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            //
            // FrmRegistration
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 300);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.lblMI);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.cboProgram);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmRegistration";
            this.Text = "FrmRegistration";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox cboProgram;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRecords;
    }
}
