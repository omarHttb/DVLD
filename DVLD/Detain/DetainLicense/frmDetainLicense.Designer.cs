namespace DVLD.Detain
{
    partial class frmDetainLicense
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
            this.GbDetainInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DetainID = new System.Windows.Forms.Label();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.llLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ucSearchForLicense1 = new DVLD.User_Controls.License.SearchForLicenseInfo.UcSearchForLicense();
            this.label4 = new System.Windows.Forms.Label();
            this.GbDetainInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbDetainInfo
            // 
            this.GbDetainInfo.Controls.Add(this.label7);
            this.GbDetainInfo.Controls.Add(this.label6);
            this.GbDetainInfo.Controls.Add(this.label3);
            this.GbDetainInfo.Controls.Add(this.lblCreatedBy);
            this.GbDetainInfo.Controls.Add(this.lblLicenseID);
            this.GbDetainInfo.Controls.Add(this.lblDetainDate);
            this.GbDetainInfo.Controls.Add(this.label2);
            this.GbDetainInfo.Controls.Add(this.DetainID);
            this.GbDetainInfo.Controls.Add(this.txtFineFees);
            this.GbDetainInfo.Controls.Add(this.label1);
            this.GbDetainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDetainInfo.Location = new System.Drawing.Point(12, 531);
            this.GbDetainInfo.Name = "GbDetainInfo";
            this.GbDetainInfo.Size = new System.Drawing.Size(1061, 200);
            this.GbDetainInfo.TabIndex = 1;
            this.GbDetainInfo.TabStop = false;
            this.GbDetainInfo.Text = "Detain Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Created By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "License ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fine Fees:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(659, 81);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(36, 20);
            this.lblCreatedBy.TabIndex = 6;
            this.lblCreatedBy.Text = "???";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Location = new System.Drawing.Point(659, 34);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(36, 20);
            this.lblLicenseID.TabIndex = 5;
            this.lblLicenseID.Text = "???";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Location = new System.Drawing.Point(156, 71);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(36, 20);
            this.lblDetainDate.TabIndex = 4;
            this.lblDetainDate.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detain Date:";
            // 
            // DetainID
            // 
            this.DetainID.AutoSize = true;
            this.DetainID.Location = new System.Drawing.Point(156, 34);
            this.DetainID.Name = "DetainID";
            this.DetainID.Size = new System.Drawing.Size(36, 20);
            this.DetainID.TabIndex = 2;
            this.DetainID.Text = "???";
            // 
            // txtFineFees
            // 
            this.txtFineFees.Location = new System.Drawing.Point(160, 111);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(171, 26);
            this.txtFineFees.TabIndex = 1;
            this.txtFineFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFineFees_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detain ID:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(837, 737);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.Location = new System.Drawing.Point(918, 737);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(148, 30);
            this.btnDetain.TabIndex = 3;
            this.btnDetain.Text = "Detain License";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // llLicenseHistory
            // 
            this.llLicenseHistory.AutoSize = true;
            this.llLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLicenseHistory.Location = new System.Drawing.Point(59, 742);
            this.llLicenseHistory.Name = "llLicenseHistory";
            this.llLicenseHistory.Size = new System.Drawing.Size(161, 20);
            this.llLicenseHistory.TabIndex = 2;
            this.llLicenseHistory.TabStop = true;
            this.llLicenseHistory.Text = "Show License History";
            this.llLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLicenseHistory_LinkClicked);
            // 
            // ucSearchForLicense1
            // 
            this.ucSearchForLicense1.DriverID = -1;
            this.ucSearchForLicense1.ExpirationDate = new System.DateTime(((long)(0)));
            this.ucSearchForLicense1.IsActive = "";
            this.ucSearchForLicense1.IsDetained = "";
            this.ucSearchForLicense1.LicenseClassID = 0;
            this.ucSearchForLicense1.LicenseID = -1;
            this.ucSearchForLicense1.Location = new System.Drawing.Point(12, 65);
            this.ucSearchForLicense1.Name = "ucSearchForLicense1";
            this.ucSearchForLicense1.NationalNo = "";
            this.ucSearchForLicense1.Notes = null;
            this.ucSearchForLicense1.PersonId = -1;
            this.ucSearchForLicense1.Size = new System.Drawing.Size(1061, 460);
            this.ucSearchForLicense1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(427, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Detain License";
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 779);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.llLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.GbDetainInfo);
            this.Controls.Add(this.ucSearchForLicense1);
            this.Name = "frmDetainLicense";
            this.Text = "frmDetainLicense";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.GbDetainInfo.ResumeLayout(false);
            this.GbDetainInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.License.SearchForLicenseInfo.UcSearchForLicense ucSearchForLicense1;
        private System.Windows.Forms.GroupBox GbDetainInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.TextBox txtFineFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llLicenseHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DetainID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}