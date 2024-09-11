namespace DVLD.License.Driver_License_Info
{
    partial class frmDriverLicenseInfo
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
            this.ucPersonDetails1 = new DVLD.UserControls.UcPersonDetails();
            this.ucLicenseInfo1 = new DVLD.User_Controls.LicenseInfo.ucLicenseInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucPersonDetails1
            // 
            this.ucPersonDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPersonDetails1.Location = new System.Drawing.Point(13, 14);
            this.ucPersonDetails1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPersonDetails1.Name = "ucPersonDetails1";
            this.ucPersonDetails1.Size = new System.Drawing.Size(903, 394);
            this.ucPersonDetails1.TabIndex = 0;
            // 
            // ucLicenseInfo1
            // 
            this.ucLicenseInfo1.Location = new System.Drawing.Point(13, 416);
            this.ucLicenseInfo1.Name = "ucLicenseInfo1";
            this.ucLicenseInfo1.personID = 0;
            this.ucLicenseInfo1.Size = new System.Drawing.Size(902, 255);
            this.ucLicenseInfo1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(813, 677);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDriverLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 725);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucLicenseInfo1);
            this.Controls.Add(this.ucPersonDetails1);
            this.Name = "frmDriverLicenseInfo";
            this.Text = "frmDriverLicenseInfo";
            this.Load += new System.EventHandler(this.frmDriverLicenseInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UcPersonDetails ucPersonDetails1;
        private User_Controls.LicenseInfo.ucLicenseInfo ucLicenseInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}