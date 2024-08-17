namespace DVLD.UserControls
{
    partial class UcSearchForPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GbFindPerson = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.CbSearchFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbPersonInformation = new System.Windows.Forms.GroupBox();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblPhone = new System.Windows.Forms.Label();
            this.LblCountry = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.LlEdit = new System.Windows.Forms.LinkLabel();
            this.PbPerson = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GbFindPerson.SuspendLayout();
            this.GbPersonInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // GbFindPerson
            // 
            this.GbFindPerson.Controls.Add(this.btnAddPerson);
            this.GbFindPerson.Controls.Add(this.btnSearch);
            this.GbFindPerson.Controls.Add(this.txtSearch);
            this.GbFindPerson.Controls.Add(this.CbSearchFilter);
            this.GbFindPerson.Controls.Add(this.label1);
            this.GbFindPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbFindPerson.Location = new System.Drawing.Point(13, 20);
            this.GbFindPerson.Margin = new System.Windows.Forms.Padding(4);
            this.GbFindPerson.Name = "GbFindPerson";
            this.GbFindPerson.Padding = new System.Windows.Forms.Padding(4);
            this.GbFindPerson.Size = new System.Drawing.Size(1138, 148);
            this.GbFindPerson.TabIndex = 0;
            this.GbFindPerson.TabStop = false;
            this.GbFindPerson.Text = "Find person";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImage = global::DVLD.Properties.Resources.person_add_icon_2048x2048_8zmguv5l;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.Location = new System.Drawing.Point(981, 59);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(92, 50);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::DVLD.Properties.Resources.Search_People;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(880, 59);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 50);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(452, 67);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(376, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // CbSearchFilter
            // 
            this.CbSearchFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSearchFilter.FormattingEnabled = true;
            this.CbSearchFilter.Items.AddRange(new object[] {
            "None",
            "National No",
            "Person ID"});
            this.CbSearchFilter.Location = new System.Drawing.Point(148, 64);
            this.CbSearchFilter.Margin = new System.Windows.Forms.Padding(4);
            this.CbSearchFilter.Name = "CbSearchFilter";
            this.CbSearchFilter.Size = new System.Drawing.Size(278, 28);
            this.CbSearchFilter.TabIndex = 1;
            this.CbSearchFilter.SelectedIndexChanged += new System.EventHandler(this.CbSearchFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find by :";
            // 
            // GbPersonInformation
            // 
            this.GbPersonInformation.Controls.Add(this.DtpDateOfBirth);
            this.GbPersonInformation.Controls.Add(this.lblPhone);
            this.GbPersonInformation.Controls.Add(this.LblCountry);
            this.GbPersonInformation.Controls.Add(this.lblAddress);
            this.GbPersonInformation.Controls.Add(this.lblEmail);
            this.GbPersonInformation.Controls.Add(this.lblGender);
            this.GbPersonInformation.Controls.Add(this.lblNationalNo);
            this.GbPersonInformation.Controls.Add(this.lblFullName);
            this.GbPersonInformation.Controls.Add(this.lblPersonId);
            this.GbPersonInformation.Controls.Add(this.LlEdit);
            this.GbPersonInformation.Controls.Add(this.PbPerson);
            this.GbPersonInformation.Controls.Add(this.label9);
            this.GbPersonInformation.Controls.Add(this.label8);
            this.GbPersonInformation.Controls.Add(this.label7);
            this.GbPersonInformation.Controls.Add(this.label6);
            this.GbPersonInformation.Controls.Add(this.label5);
            this.GbPersonInformation.Controls.Add(this.label4);
            this.GbPersonInformation.Controls.Add(this.label3);
            this.GbPersonInformation.Controls.Add(this.label2);
            this.GbPersonInformation.Controls.Add(this.label10);
            this.GbPersonInformation.Location = new System.Drawing.Point(82, 175);
            this.GbPersonInformation.Name = "GbPersonInformation";
            this.GbPersonInformation.Size = new System.Drawing.Size(987, 415);
            this.GbPersonInformation.TabIndex = 2;
            this.GbPersonInformation.TabStop = false;
            this.GbPersonInformation.Text = "Person information";
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Enabled = false;
            this.DtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOfBirth.Location = new System.Drawing.Point(545, 168);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(121, 24);
            this.DtpDateOfBirth.TabIndex = 19;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(573, 222);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(32, 18);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "N/A";
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.Location = new System.Drawing.Point(573, 276);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(32, 18);
            this.LblCountry.TabIndex = 17;
            this.LblCountry.Text = "N/A";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(159, 330);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(32, 18);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "N/A";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(159, 276);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 18);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "N/A";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(159, 222);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(32, 18);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "N/A";
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.AutoSize = true;
            this.lblNationalNo.Location = new System.Drawing.Point(159, 168);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(32, 18);
            this.lblNationalNo.TabIndex = 13;
            this.lblNationalNo.Text = "N/A";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(159, 114);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(32, 18);
            this.lblFullName.TabIndex = 12;
            this.lblFullName.Text = "N/A";
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Location = new System.Drawing.Point(159, 60);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(32, 18);
            this.lblPersonId.TabIndex = 11;
            this.lblPersonId.Text = "N/A";
            // 
            // LlEdit
            // 
            this.LlEdit.AutoSize = true;
            this.LlEdit.Location = new System.Drawing.Point(740, 191);
            this.LlEdit.Name = "LlEdit";
            this.LlEdit.Size = new System.Drawing.Size(113, 18);
            this.LlEdit.TabIndex = 10;
            this.LlEdit.TabStop = true;
            this.LlEdit.Text = "Edit Person Info";
            this.LlEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlEdit_LinkClicked);
            // 
            // PbPerson
            // 
            this.PbPerson.Image = global::DVLD.Properties.Resources._360_F_65772719_A1UV5kLi5nCEWI0BNLLiFaBPEkUbv5Fv;
            this.PbPerson.InitialImage = global::DVLD.Properties.Resources._360_F_65772719_A1UV5kLi5nCEWI0BNLLiFaBPEkUbv5Fv;
            this.PbPerson.Location = new System.Drawing.Point(712, 25);
            this.PbPerson.Name = "PbPerson";
            this.PbPerson.Size = new System.Drawing.Size(176, 163);
            this.PbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbPerson.TabIndex = 9;
            this.PbPerson.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Country :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phone :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date of birth :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "National No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Person ID :";
            // 
            // UcSearchForPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GbPersonInformation);
            this.Controls.Add(this.GbFindPerson);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcSearchForPerson";
            this.Size = new System.Drawing.Size(1161, 603);
            this.Load += new System.EventHandler(this.UcSearchForPerson_Load);
            this.GbFindPerson.ResumeLayout(false);
            this.GbFindPerson.PerformLayout();
            this.GbPersonInformation.ResumeLayout(false);
            this.GbPersonInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbFindPerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox CbSearchFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbPersonInformation;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.LinkLabel LlEdit;
        private System.Windows.Forms.PictureBox PbPerson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}
