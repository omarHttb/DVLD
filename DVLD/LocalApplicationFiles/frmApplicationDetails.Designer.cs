namespace DVLD.ManageApplicationTypes
{
    partial class frmApplicationDetails
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
            this.ucApplicationInfo1 = new DVLD.Application_Info_user_control.UcApplicationLocalLicenseInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucApplicationInfo1
            // 
            this.ucApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucApplicationInfo1.FullName = null;
            this.ucApplicationInfo1.LicenseClass = null;
            this.ucApplicationInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ucApplicationInfo1.Name = "ucApplicationInfo1";
            this.ucApplicationInfo1.PassedTest = 0;
            this.ucApplicationInfo1.Size = new System.Drawing.Size(817, 373);
            this.ucApplicationInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(692, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 421);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucApplicationInfo1);
            this.Name = "frmApplicationDetails";
            this.Text = "frmApplicationDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private Application_Info_user_control.UcApplicationLocalLicenseInfo ucApplicationInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}