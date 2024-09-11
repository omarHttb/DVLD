namespace DVLD.User_Controls.License.SearchForLicenseInfo
{
    partial class UcSearchForLicense
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
            this.GbFIlter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDriverLicenseInfo = new System.Windows.Forms.GroupBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDriverID = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblIsDetained = new System.Windows.Forms.Label();
            this.lblIssueReason = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.PbPerson = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GbFIlter.SuspendLayout();
            this.gbDriverLicenseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // GbFIlter
            // 
            this.GbFIlter.Controls.Add(this.btnSearch);
            this.GbFIlter.Controls.Add(this.txtFilter);
            this.GbFIlter.Controls.Add(this.label1);
            this.GbFIlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbFIlter.Location = new System.Drawing.Point(160, 3);
            this.GbFIlter.Name = "GbFIlter";
            this.GbFIlter.Size = new System.Drawing.Size(762, 102);
            this.GbFIlter.TabIndex = 0;
            this.GbFIlter.TabStop = false;
            this.GbFIlter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSearch.BackgroundImage = global::DVLD.Properties.Resources.searchLicense;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(549, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 49);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(245, 46);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(284, 26);
            this.txtFilter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID:";
            // 
            // gbDriverLicenseInfo
            // 
            this.gbDriverLicenseInfo.Controls.Add(this.lblIsActive);
            this.gbDriverLicenseInfo.Controls.Add(this.label19);
            this.gbDriverLicenseInfo.Controls.Add(this.lblDriverID);
            this.gbDriverLicenseInfo.Controls.Add(this.label17);
            this.gbDriverLicenseInfo.Controls.Add(this.lblDateOfBirth);
            this.gbDriverLicenseInfo.Controls.Add(this.label15);
            this.gbDriverLicenseInfo.Controls.Add(this.lblNotes);
            this.gbDriverLicenseInfo.Controls.Add(this.label13);
            this.gbDriverLicenseInfo.Controls.Add(this.lblLicenseID);
            this.gbDriverLicenseInfo.Controls.Add(this.label134);
            this.gbDriverLicenseInfo.Controls.Add(this.lblExpirationDate);
            this.gbDriverLicenseInfo.Controls.Add(this.lblIsDetained);
            this.gbDriverLicenseInfo.Controls.Add(this.lblIssueReason);
            this.gbDriverLicenseInfo.Controls.Add(this.lblIssueDate);
            this.gbDriverLicenseInfo.Controls.Add(this.lblGender);
            this.gbDriverLicenseInfo.Controls.Add(this.lblNationalNo);
            this.gbDriverLicenseInfo.Controls.Add(this.lblFullName);
            this.gbDriverLicenseInfo.Controls.Add(this.lblClass);
            this.gbDriverLicenseInfo.Controls.Add(this.PbPerson);
            this.gbDriverLicenseInfo.Controls.Add(this.label8);
            this.gbDriverLicenseInfo.Controls.Add(this.label7);
            this.gbDriverLicenseInfo.Controls.Add(this.label6);
            this.gbDriverLicenseInfo.Controls.Add(this.label5);
            this.gbDriverLicenseInfo.Controls.Add(this.label4);
            this.gbDriverLicenseInfo.Controls.Add(this.label3);
            this.gbDriverLicenseInfo.Controls.Add(this.label2);
            this.gbDriverLicenseInfo.Controls.Add(this.label10);
            this.gbDriverLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDriverLicenseInfo.Location = new System.Drawing.Point(3, 111);
            this.gbDriverLicenseInfo.Name = "gbDriverLicenseInfo";
            this.gbDriverLicenseInfo.Size = new System.Drawing.Size(1055, 345);
            this.gbDriverLicenseInfo.TabIndex = 3;
            this.gbDriverLicenseInfo.TabStop = false;
            this.gbDriverLicenseInfo.Text = "Driver License Info";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(625, 48);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(36, 20);
            this.lblIsActive.TabIndex = 49;
            this.lblIsActive.Text = "???";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(521, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 20);
            this.label19.TabIndex = 48;
            this.label19.Text = "is Active :";
            // 
            // lblDriverID
            // 
            this.lblDriverID.AutoSize = true;
            this.lblDriverID.Location = new System.Drawing.Point(625, 118);
            this.lblDriverID.Name = "lblDriverID";
            this.lblDriverID.Size = new System.Drawing.Size(36, 20);
            this.lblDriverID.TabIndex = 47;
            this.lblDriverID.Text = "???";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(470, 188);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 20);
            this.label17.TabIndex = 46;
            this.label17.Text = "Expiration Date :";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(625, 83);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(36, 20);
            this.lblDateOfBirth.TabIndex = 45;
            this.lblDateOfBirth.Text = "???";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(517, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 44;
            this.label15.Text = "Driver ID :";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(133, 277);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(36, 20);
            this.lblNotes.TabIndex = 43;
            this.lblNotes.Text = "???";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Notes :";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Location = new System.Drawing.Point(133, 122);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(36, 20);
            this.lblLicenseID.TabIndex = 41;
            this.lblLicenseID.Text = "???";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(38, 122);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(89, 20);
            this.label134.TabIndex = 40;
            this.label134.Text = "LicenseID :";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(625, 190);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(36, 20);
            this.lblExpirationDate.TabIndex = 38;
            this.lblExpirationDate.Text = "???";
            // 
            // lblIsDetained
            // 
            this.lblIsDetained.AutoSize = true;
            this.lblIsDetained.Location = new System.Drawing.Point(625, 225);
            this.lblIsDetained.Name = "lblIsDetained";
            this.lblIsDetained.Size = new System.Drawing.Size(36, 20);
            this.lblIsDetained.TabIndex = 37;
            this.lblIsDetained.Text = "???";
            // 
            // lblIssueReason
            // 
            this.lblIssueReason.AutoSize = true;
            this.lblIssueReason.Location = new System.Drawing.Point(133, 236);
            this.lblIssueReason.Name = "lblIssueReason";
            this.lblIssueReason.Size = new System.Drawing.Size(36, 20);
            this.lblIssueReason.TabIndex = 36;
            this.lblIssueReason.Text = "???";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(625, 153);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(36, 20);
            this.lblIssueDate.TabIndex = 35;
            this.lblIssueDate.Text = "???";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(133, 198);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(36, 20);
            this.lblGender.TabIndex = 34;
            this.lblGender.Text = "???";
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.AutoSize = true;
            this.lblNationalNo.Location = new System.Drawing.Point(133, 160);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(36, 20);
            this.lblNationalNo.TabIndex = 33;
            this.lblNationalNo.Text = "???";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(133, 84);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(36, 20);
            this.lblFullName.TabIndex = 32;
            this.lblFullName.Text = "???";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(133, 46);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(36, 20);
            this.lblClass.TabIndex = 31;
            this.lblClass.Text = "???";
            // 
            // PbPerson
            // 
            this.PbPerson.Image = global::DVLD.Properties.Resources._360_F_65772719_A1UV5kLi5nCEWI0BNLLiFaBPEkUbv5Fv;
            this.PbPerson.InitialImage = global::DVLD.Properties.Resources._360_F_65772719_A1UV5kLi5nCEWI0BNLLiFaBPEkUbv5Fv;
            this.PbPerson.Location = new System.Drawing.Point(833, 59);
            this.PbPerson.Name = "PbPerson";
            this.PbPerson.Size = new System.Drawing.Size(201, 184);
            this.PbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbPerson.TabIndex = 29;
            this.PbPerson.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Is Detained :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Date of birth :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Issue Reason :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Issue Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "National No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Full name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Class :";
            // 
            // UcSearchForLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDriverLicenseInfo);
            this.Controls.Add(this.GbFIlter);
            this.Name = "UcSearchForLicense";
            this.Size = new System.Drawing.Size(1061, 470);
            this.GbFIlter.ResumeLayout(false);
            this.GbFIlter.PerformLayout();
            this.gbDriverLicenseInfo.ResumeLayout(false);
            this.gbDriverLicenseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbFIlter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDriverLicenseInfo;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblIsDetained;
        private System.Windows.Forms.Label lblIssueReason;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.PictureBox PbPerson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDriverID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label label15;
    }
}
