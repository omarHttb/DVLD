namespace DVLD.NewDrivingLicense
{
    partial class frmNewLocalDrivingLicense
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
            this.lblMode = new System.Windows.Forms.Label();
            this.TcLocalDrivingLicenseApplication = new System.Windows.Forms.TabControl();
            this.TbPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.TbLoginInfo = new System.Windows.Forms.TabPage();
            this.cbLicensesClasses = new System.Windows.Forms.ComboBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ucSearchForPerson1 = new DVLD.UserControls.UcSearchForPerson();
            this.TcLocalDrivingLicenseApplication.SuspendLayout();
            this.TbPersonInfo.SuspendLayout();
            this.TbLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMode.Location = new System.Drawing.Point(256, 11);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(689, 42);
            this.lblMode.TabIndex = 1;
            this.lblMode.Text = "New Local Driving License Application";
            // 
            // TcLocalDrivingLicenseApplication
            // 
            this.TcLocalDrivingLicenseApplication.Controls.Add(this.TbPersonInfo);
            this.TcLocalDrivingLicenseApplication.Controls.Add(this.TbLoginInfo);
            this.TcLocalDrivingLicenseApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcLocalDrivingLicenseApplication.Location = new System.Drawing.Point(26, 56);
            this.TcLocalDrivingLicenseApplication.Name = "TcLocalDrivingLicenseApplication";
            this.TcLocalDrivingLicenseApplication.SelectedIndex = 0;
            this.TcLocalDrivingLicenseApplication.Size = new System.Drawing.Size(1201, 707);
            this.TcLocalDrivingLicenseApplication.TabIndex = 3;
            // 
            // TbPersonInfo
            // 
            this.TbPersonInfo.Controls.Add(this.btnNextPage);
            this.TbPersonInfo.Controls.Add(this.ucSearchForPerson1);
            this.TbPersonInfo.Location = new System.Drawing.Point(4, 27);
            this.TbPersonInfo.Name = "TbPersonInfo";
            this.TbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TbPersonInfo.Size = new System.Drawing.Size(1193, 676);
            this.TbPersonInfo.TabIndex = 0;
            this.TbPersonInfo.Text = "Person Info";
            this.TbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(937, 613);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(126, 46);
            this.btnNextPage.TabIndex = 2;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // TbLoginInfo
            // 
            this.TbLoginInfo.Controls.Add(this.cbLicensesClasses);
            this.TbLoginInfo.Controls.Add(this.lblCreatedBy);
            this.TbLoginInfo.Controls.Add(this.lblFees);
            this.TbLoginInfo.Controls.Add(this.lblDate);
            this.TbLoginInfo.Controls.Add(this.label1);
            this.TbLoginInfo.Controls.Add(this.BtnSave);
            this.TbLoginInfo.Controls.Add(this.lblApplicationID);
            this.TbLoginInfo.Controls.Add(this.label5);
            this.TbLoginInfo.Controls.Add(this.label4);
            this.TbLoginInfo.Controls.Add(this.label3);
            this.TbLoginInfo.Controls.Add(this.label2);
            this.TbLoginInfo.Location = new System.Drawing.Point(4, 27);
            this.TbLoginInfo.Name = "TbLoginInfo";
            this.TbLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TbLoginInfo.Size = new System.Drawing.Size(1193, 676);
            this.TbLoginInfo.TabIndex = 1;
            this.TbLoginInfo.Text = "Login info";
            this.TbLoginInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicensesClasses
            // 
            this.cbLicensesClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicensesClasses.FormattingEnabled = true;
            this.cbLicensesClasses.Location = new System.Drawing.Point(336, 204);
            this.cbLicensesClasses.Name = "cbLicensesClasses";
            this.cbLicensesClasses.Size = new System.Drawing.Size(281, 26);
            this.cbLicensesClasses.TabIndex = 13;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(332, 304);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(40, 24);
            this.lblCreatedBy.TabIndex = 12;
            this.lblCreatedBy.Text = "???";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(332, 254);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(30, 24);
            this.lblFees.TabIndex = 11;
            this.lblFees.Text = "15";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(332, 154);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(83, 24);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date ???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Created by:";
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(995, 579);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(126, 46);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(332, 104);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(40, 24);
            this.lblApplicationID.TabIndex = 4;
            this.lblApplicationID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Application fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Licenses class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L.Application ID:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1100, 765);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucSearchForPerson1
            // 
            this.ucSearchForPerson1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSearchForPerson1.Location = new System.Drawing.Point(7, 14);
            this.ucSearchForPerson1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSearchForPerson1.Name = "ucSearchForPerson1";
            this.ucSearchForPerson1.Size = new System.Drawing.Size(1157, 592);
            this.ucSearchForPerson1.TabIndex = 2;
            // 
            // frmNewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 809);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TcLocalDrivingLicenseApplication);
            this.Controls.Add(this.lblMode);
            this.Name = "frmNewLocalDrivingLicense";
            this.Text = "Local driving License";
            this.TcLocalDrivingLicenseApplication.ResumeLayout(false);
            this.TbPersonInfo.ResumeLayout(false);
            this.TbLoginInfo.ResumeLayout(false);
            this.TbLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TabControl TcLocalDrivingLicenseApplication;
        private System.Windows.Forms.TabPage TbPersonInfo;
        private System.Windows.Forms.Button btnNextPage;
        private UserControls.UcSearchForPerson ucSearchForPerson1;
        private System.Windows.Forms.TabPage TbLoginInfo;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLicensesClasses;
    }
}