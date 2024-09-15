namespace DVLD.License.International
{
    partial class frmIssueInternationalLicense
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.GbApplicationBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblInternationalExpirationDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblInternationalIssueDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblInternationalLicense = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLocalLicenseID = new System.Windows.Forms.Label();
            this.lblInternationalAppId = new System.Windows.Forms.Label();
            this.LLlicenseInfo = new System.Windows.Forms.LinkLabel();
            this.LLShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ucSearchForLicense1 = new DVLD.User_Controls.License.SearchForLicenseInfo.UcSearchForLicense();
            this.label1 = new System.Windows.Forms.Label();
            this.GbApplicationBasicInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(913, 742);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(994, 742);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(75, 32);
            this.btnIssue.TabIndex = 2;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // GbApplicationBasicInfo
            // 
            this.GbApplicationBasicInfo.Controls.Add(this.lblInternationalExpirationDate);
            this.GbApplicationBasicInfo.Controls.Add(this.label2);
            this.GbApplicationBasicInfo.Controls.Add(this.label8);
            this.GbApplicationBasicInfo.Controls.Add(this.label6);
            this.GbApplicationBasicInfo.Controls.Add(this.lblCreatedBy);
            this.GbApplicationBasicInfo.Controls.Add(this.label13);
            this.GbApplicationBasicInfo.Controls.Add(this.lblInternationalIssueDate);
            this.GbApplicationBasicInfo.Controls.Add(this.label12);
            this.GbApplicationBasicInfo.Controls.Add(this.lblAppDate);
            this.GbApplicationBasicInfo.Controls.Add(this.label11);
            this.GbApplicationBasicInfo.Controls.Add(this.lblInternationalLicense);
            this.GbApplicationBasicInfo.Controls.Add(this.label7);
            this.GbApplicationBasicInfo.Controls.Add(this.lblFees);
            this.GbApplicationBasicInfo.Controls.Add(this.label9);
            this.GbApplicationBasicInfo.Controls.Add(this.lblLocalLicenseID);
            this.GbApplicationBasicInfo.Controls.Add(this.lblInternationalAppId);
            this.GbApplicationBasicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbApplicationBasicInfo.Location = new System.Drawing.Point(12, 552);
            this.GbApplicationBasicInfo.Name = "GbApplicationBasicInfo";
            this.GbApplicationBasicInfo.Size = new System.Drawing.Size(786, 187);
            this.GbApplicationBasicInfo.TabIndex = 5;
            this.GbApplicationBasicInfo.TabStop = false;
            this.GbApplicationBasicInfo.Text = "International Application Basic Info";
            // 
            // lblInternationalExpirationDate
            // 
            this.lblInternationalExpirationDate.AutoSize = true;
            this.lblInternationalExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalExpirationDate.Location = new System.Drawing.Point(565, 133);
            this.lblInternationalExpirationDate.Name = "lblInternationalExpirationDate";
            this.lblInternationalExpirationDate.Size = new System.Drawing.Size(36, 20);
            this.lblInternationalExpirationDate.TabIndex = 25;
            this.lblInternationalExpirationDate.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Expiration Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(456, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "I.License ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "I.L.Application ID:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(211, 99);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(36, 20);
            this.lblCreatedBy.TabIndex = 22;
            this.lblCreatedBy.Text = "???";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(91, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Created By:";
            // 
            // lblInternationalIssueDate
            // 
            this.lblInternationalIssueDate.AutoSize = true;
            this.lblInternationalIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalIssueDate.Location = new System.Drawing.Point(565, 99);
            this.lblInternationalIssueDate.Name = "lblInternationalIssueDate";
            this.lblInternationalIssueDate.Size = new System.Drawing.Size(36, 20);
            this.lblInternationalIssueDate.TabIndex = 20;
            this.lblInternationalIssueDate.Text = "???";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(463, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Issue Date:";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(211, 69);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(36, 20);
            this.lblAppDate.TabIndex = 18;
            this.lblAppDate.Text = "???";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Application Date:";
            // 
            // lblInternationalLicense
            // 
            this.lblInternationalLicense.AutoSize = true;
            this.lblInternationalLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicense.Location = new System.Drawing.Point(565, 31);
            this.lblInternationalLicense.Name = "lblInternationalLicense";
            this.lblInternationalLicense.Size = new System.Drawing.Size(36, 20);
            this.lblInternationalLicense.TabIndex = 14;
            this.lblInternationalLicense.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Local License ID:";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(211, 133);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(36, 20);
            this.lblFees.TabIndex = 12;
            this.lblFees.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(134, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Fees:";
            // 
            // lblLocalLicenseID
            // 
            this.lblLocalLicenseID.AutoSize = true;
            this.lblLocalLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseID.Location = new System.Drawing.Point(565, 65);
            this.lblLocalLicenseID.Name = "lblLocalLicenseID";
            this.lblLocalLicenseID.Size = new System.Drawing.Size(36, 20);
            this.lblLocalLicenseID.TabIndex = 10;
            this.lblLocalLicenseID.Text = "???";
            // 
            // lblInternationalAppId
            // 
            this.lblInternationalAppId.AutoSize = true;
            this.lblInternationalAppId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalAppId.Location = new System.Drawing.Point(211, 31);
            this.lblInternationalAppId.Name = "lblInternationalAppId";
            this.lblInternationalAppId.Size = new System.Drawing.Size(36, 20);
            this.lblInternationalAppId.TabIndex = 8;
            this.lblInternationalAppId.Text = "???";
            // 
            // LLlicenseInfo
            // 
            this.LLlicenseInfo.AutoSize = true;
            this.LLlicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLlicenseInfo.Location = new System.Drawing.Point(299, 742);
            this.LLlicenseInfo.Name = "LLlicenseInfo";
            this.LLlicenseInfo.Size = new System.Drawing.Size(129, 18);
            this.LLlicenseInfo.TabIndex = 9;
            this.LLlicenseInfo.TabStop = true;
            this.LLlicenseInfo.Text = "Show License Info";
            this.LLlicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLlicenseInfo_LinkClicked);
            // 
            // LLShowLicenseHistory
            // 
            this.LLShowLicenseHistory.AutoSize = true;
            this.LLShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLShowLicenseHistory.Location = new System.Drawing.Point(65, 742);
            this.LLShowLicenseHistory.Name = "LLShowLicenseHistory";
            this.LLShowLicenseHistory.Size = new System.Drawing.Size(152, 18);
            this.LLShowLicenseHistory.TabIndex = 8;
            this.LLShowLicenseHistory.TabStop = true;
            this.LLShowLicenseHistory.Text = "Show License History";
            this.LLShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLShowLicenseHistory_LinkClicked);
            // 
            // ucSearchForLicense1
            // 
            this.ucSearchForLicense1.DriverID = -1;
            this.ucSearchForLicense1.ExpirationDate = new System.DateTime(((long)(0)));
            this.ucSearchForLicense1.IsActive = "";
            this.ucSearchForLicense1.IsDetained = "";
            this.ucSearchForLicense1.LicenseClassID = 0;
            this.ucSearchForLicense1.LicenseID = -1;
            this.ucSearchForLicense1.Location = new System.Drawing.Point(12, 79);
            this.ucSearchForLicense1.Name = "ucSearchForLicense1";
            this.ucSearchForLicense1.NationalNo = "";
            this.ucSearchForLicense1.Notes = null;
            this.ucSearchForLicense1.PersonId = -1;
            this.ucSearchForLicense1.Size = new System.Drawing.Size(1070, 467);
            this.ucSearchForLicense1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(379, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Issue International License";
            // 
            // frmIssueInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 775);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LLlicenseInfo);
            this.Controls.Add(this.LLShowLicenseHistory);
            this.Controls.Add(this.GbApplicationBasicInfo);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucSearchForLicense1);
            this.Name = "frmIssueInternationalLicense";
            this.Text = "Issue International License";
            this.GbApplicationBasicInfo.ResumeLayout(false);
            this.GbApplicationBasicInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.License.SearchForLicenseInfo.UcSearchForLicense ucSearchForLicense1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.GroupBox GbApplicationBasicInfo;
        private System.Windows.Forms.Label lblInternationalExpirationDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblInternationalIssueDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblInternationalLicense;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLocalLicenseID;
        private System.Windows.Forms.Label lblInternationalAppId;
        private System.Windows.Forms.LinkLabel LLlicenseInfo;
        private System.Windows.Forms.LinkLabel LLShowLicenseHistory;
        private System.Windows.Forms.Label label1;
    }
}