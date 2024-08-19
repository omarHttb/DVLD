namespace DVLD
{
    public partial class FrmAddUpdatePerson
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
            this.EpAddUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbAddUpdatePerson = new System.Windows.Forms.GroupBox();
            this.LlRemoveImage = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.PbPerson = new System.Windows.Forms.PictureBox();
            this.LlSetImage = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.RbMale = new System.Windows.Forms.RadioButton();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddNewPerson = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EpAddUpdate)).BeginInit();
            this.GbAddUpdatePerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // EpAddUpdate
            // 
            this.EpAddUpdate.ContainerControl = this;
            // 
            // GbAddUpdatePerson
            // 
            this.GbAddUpdatePerson.Controls.Add(this.LlRemoveImage);
            this.GbAddUpdatePerson.Controls.Add(this.btnSave);
            this.GbAddUpdatePerson.Controls.Add(this.PbPerson);
            this.GbAddUpdatePerson.Controls.Add(this.LlSetImage);
            this.GbAddUpdatePerson.Controls.Add(this.label12);
            this.GbAddUpdatePerson.Controls.Add(this.btnClose);
            this.GbAddUpdatePerson.Controls.Add(this.cbCountry);
            this.GbAddUpdatePerson.Controls.Add(this.label11);
            this.GbAddUpdatePerson.Controls.Add(this.txtPhone);
            this.GbAddUpdatePerson.Controls.Add(this.label7);
            this.GbAddUpdatePerson.Controls.Add(this.DtpDateOfBirth);
            this.GbAddUpdatePerson.Controls.Add(this.label3);
            this.GbAddUpdatePerson.Controls.Add(this.txtAddress);
            this.GbAddUpdatePerson.Controls.Add(this.RbFemale);
            this.GbAddUpdatePerson.Controls.Add(this.RbMale);
            this.GbAddUpdatePerson.Controls.Add(this.TxtEmail);
            this.GbAddUpdatePerson.Controls.Add(this.txtNationalNo);
            this.GbAddUpdatePerson.Controls.Add(this.txtLastName);
            this.GbAddUpdatePerson.Controls.Add(this.txtThirdName);
            this.GbAddUpdatePerson.Controls.Add(this.txtSecondName);
            this.GbAddUpdatePerson.Controls.Add(this.txtFirstName);
            this.GbAddUpdatePerson.Controls.Add(this.label10);
            this.GbAddUpdatePerson.Controls.Add(this.label9);
            this.GbAddUpdatePerson.Controls.Add(this.lblName);
            this.GbAddUpdatePerson.Controls.Add(this.label8);
            this.GbAddUpdatePerson.Controls.Add(this.label5);
            this.GbAddUpdatePerson.Controls.Add(this.lblFirstName);
            this.GbAddUpdatePerson.Controls.Add(this.label4);
            this.GbAddUpdatePerson.Controls.Add(this.label6);
            this.GbAddUpdatePerson.Location = new System.Drawing.Point(90, 68);
            this.GbAddUpdatePerson.Name = "GbAddUpdatePerson";
            this.GbAddUpdatePerson.Size = new System.Drawing.Size(822, 407);
            this.GbAddUpdatePerson.TabIndex = 40;
            this.GbAddUpdatePerson.TabStop = false;
            // 
            // LlRemoveImage
            // 
            this.LlRemoveImage.AutoSize = true;
            this.LlRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlRemoveImage.Location = new System.Drawing.Point(656, 317);
            this.LlRemoveImage.Name = "LlRemoveImage";
            this.LlRemoveImage.Size = new System.Drawing.Size(117, 20);
            this.LlRemoveImage.TabIndex = 33;
            this.LlRemoveImage.TabStop = true;
            this.LlRemoveImage.Text = "Remove Image";
            this.LlRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlRemoveImage_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(480, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // PbPerson
            // 
            this.PbPerson.Image = global::DVLD.Properties.Resources._360_F_65772719_A1UV5kLi5nCEWI0BNLLiFaBPEkUbv5Fv;
            this.PbPerson.Location = new System.Drawing.Point(624, 96);
            this.PbPerson.Name = "PbPerson";
            this.PbPerson.Size = new System.Drawing.Size(163, 177);
            this.PbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbPerson.TabIndex = 29;
            this.PbPerson.TabStop = false;
            // 
            // LlSetImage
            // 
            this.LlSetImage.AutoSize = true;
            this.LlSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlSetImage.Location = new System.Drawing.Point(669, 285);
            this.LlSetImage.Name = "LlSetImage";
            this.LlSetImage.Size = new System.Drawing.Size(83, 20);
            this.LlSetImage.TabIndex = 12;
            this.LlSetImage.TabStop = true;
            this.LlSetImage.Text = "Set Image";
            this.LlSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlSetImage_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(366, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Country :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(399, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(465, 182);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(130, 28);
            this.cbCountry.Sorted = true;
            this.cbCountry.TabIndex = 11;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(375, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Phone :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(465, 143);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 26);
            this.txtPhone.TabIndex = 10;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(331, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Date of Birth :";
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOfBirth.Location = new System.Drawing.Point(465, 97);
            this.DtpDateOfBirth.MaxDate = new System.DateTime(2024, 7, 28, 0, 0, 0, 0);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(117, 26);
            this.DtpDateOfBirth.TabIndex = 9;
            this.DtpDateOfBirth.Value = new System.DateTime(2024, 7, 28, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Address : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(141, 223);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(452, 131);
            this.txtAddress.TabIndex = 8;
            // 
            // RbFemale
            // 
            this.RbFemale.AutoSize = true;
            this.RbFemale.Location = new System.Drawing.Point(210, 143);
            this.RbFemale.Name = "RbFemale";
            this.RbFemale.Size = new System.Drawing.Size(80, 24);
            this.RbFemale.TabIndex = 6;
            this.RbFemale.TabStop = true;
            this.RbFemale.Text = "Female";
            this.RbFemale.UseVisualStyleBackColor = true;
            // 
            // RbMale
            // 
            this.RbMale.AutoSize = true;
            this.RbMale.Checked = true;
            this.RbMale.Location = new System.Drawing.Point(143, 143);
            this.RbMale.Name = "RbMale";
            this.RbMale.Size = new System.Drawing.Size(61, 24);
            this.RbMale.TabIndex = 5;
            this.RbMale.TabStop = true;
            this.RbMale.Text = "Male";
            this.RbMale.UseVisualStyleBackColor = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(141, 179);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(130, 26);
            this.TxtEmail.TabIndex = 7;
            this.TxtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating_1);
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Location = new System.Drawing.Point(143, 99);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(128, 26);
            this.txtNationalNo.TabIndex = 4;
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(624, 54);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(128, 26);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point(465, 54);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(128, 26);
            this.txtThirdName.TabIndex = 2;
            this.txtThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.txtThirdName_Validating_1);
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(302, 54);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(132, 26);
            this.txtSecondName.TabIndex = 1;
            this.txtSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSecondName_Validating_1);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(141, 54);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(130, 26);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(647, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Last name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(476, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Third name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(38, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Second name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender : ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(141, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 20);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "first name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "National No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email : ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(231, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 20);
            this.lblId.TabIndex = 39;
            this.lblId.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Person ID: ";
            // 
            // lblAddNewPerson
            // 
            this.lblAddNewPerson.AutoSize = true;
            this.lblAddNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewPerson.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAddNewPerson.Location = new System.Drawing.Point(409, 9);
            this.lblAddNewPerson.Name = "lblAddNewPerson";
            this.lblAddNewPerson.Size = new System.Drawing.Size(231, 31);
            this.lblAddNewPerson.TabIndex = 37;
            this.lblAddNewPerson.Text = "Add New Person";
            // 
            // FrmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 507);
            this.Controls.Add(this.GbAddUpdatePerson);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddNewPerson);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAddUpdatePerson";
            this.Text = "add and update person";
            this.Load += new System.EventHandler(this.FrmAddUpdatePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EpAddUpdate)).EndInit();
            this.GbAddUpdatePerson.ResumeLayout(false);
            this.GbAddUpdatePerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider EpAddUpdate;
        private System.Windows.Forms.GroupBox GbAddUpdatePerson;
        private System.Windows.Forms.LinkLabel LlSetImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddNewPerson;
        private System.Windows.Forms.LinkLabel LlRemoveImage;
        public  System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ComboBox cbCountry;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.RadioButton RbFemale;
        public System.Windows.Forms.RadioButton RbMale;
        public System.Windows.Forms.TextBox TxtEmail;
        public System.Windows.Forms.TextBox txtNationalNo;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtThirdName;
        public System.Windows.Forms.TextBox txtSecondName;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblFirstName;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox PbPerson;
    }
}