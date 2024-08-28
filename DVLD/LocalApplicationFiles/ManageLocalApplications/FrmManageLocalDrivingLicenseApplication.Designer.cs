namespace DVLD.LocalApplicationFiles.ManageLocalApplications
{
    partial class FrmManageLocalDrivingLicenseApplication
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
            System.Windows.Forms.ToolStripMenuItem MenuItemCancelApp;
            this.btnClose = new System.Windows.Forms.Button();
            this.DvgLocalDrvingLicenseApplication = new System.Windows.Forms.DataGridView();
            this.CmLDLAppMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemShowAppDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteApp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSchedualTest = new System.Windows.Forms.ToolStripMenuItem();
            this.schedualVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedualWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemIssueLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemShowLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbFilter = new System.Windows.Forms.ComboBox();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.RbNew = new System.Windows.Forms.RadioButton();
            this.RbCancelled = new System.Windows.Forms.RadioButton();
            this.rbCompleted = new System.Windows.Forms.RadioButton();
            this.BtnAddLocalApplication = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            MenuItemCancelApp = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DvgLocalDrvingLicenseApplication)).BeginInit();
            this.CmLDLAppMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuItemCancelApp
            // 
            MenuItemCancelApp.Image = global::DVLD.Properties.Resources.icons8_close_40;
            MenuItemCancelApp.Name = "MenuItemCancelApp";
            MenuItemCancelApp.Size = new System.Drawing.Size(289, 24);
            MenuItemCancelApp.Text = "Cancel Application";
            MenuItemCancelApp.Click += new System.EventHandler(this.MenuItemCancelApp_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(989, 569);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 44);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DvgLocalDrvingLicenseApplication
            // 
            this.DvgLocalDrvingLicenseApplication.AllowUserToAddRows = false;
            this.DvgLocalDrvingLicenseApplication.AllowUserToDeleteRows = false;
            this.DvgLocalDrvingLicenseApplication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DvgLocalDrvingLicenseApplication.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DvgLocalDrvingLicenseApplication.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DvgLocalDrvingLicenseApplication.ContextMenuStrip = this.CmLDLAppMenu;
            this.DvgLocalDrvingLicenseApplication.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DvgLocalDrvingLicenseApplication.Location = new System.Drawing.Point(12, 245);
            this.DvgLocalDrvingLicenseApplication.MultiSelect = false;
            this.DvgLocalDrvingLicenseApplication.Name = "DvgLocalDrvingLicenseApplication";
            this.DvgLocalDrvingLicenseApplication.ReadOnly = true;
            this.DvgLocalDrvingLicenseApplication.Size = new System.Drawing.Size(1075, 318);
            this.DvgLocalDrvingLicenseApplication.TabIndex = 25;
            // 
            // CmLDLAppMenu
            // 
            this.CmLDLAppMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmLDLAppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemShowAppDetails,
            this.toolStripSeparator1,
            this.MenuItemEditApplication,
            this.MenuItemDeleteApp,
            MenuItemCancelApp,
            this.toolStripSeparator2,
            this.MenuItemSchedualTest,
            this.toolStripSeparator3,
            this.MenuItemIssueLicenseFirstTime,
            this.toolStripSeparator5,
            this.MenuItemShowLicense,
            this.toolStripSeparator4,
            this.MenuItemShowLicenseHistory});
            this.CmLDLAppMenu.Name = "CmLDLAppMenu";
            this.CmLDLAppMenu.Size = new System.Drawing.Size(290, 248);
            this.CmLDLAppMenu.Opening += new System.ComponentModel.CancelEventHandler(this.CmLDLAppMenu_Opening);
            // 
            // MenuItemShowAppDetails
            // 
            this.MenuItemShowAppDetails.Image = global::DVLD.Properties.Resources.view_details;
            this.MenuItemShowAppDetails.Name = "MenuItemShowAppDetails";
            this.MenuItemShowAppDetails.Size = new System.Drawing.Size(289, 24);
            this.MenuItemShowAppDetails.Text = "Show Application Details";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(286, 6);
            // 
            // MenuItemEditApplication
            // 
            this.MenuItemEditApplication.Image = global::DVLD.Properties.Resources.icons8_edit_64;
            this.MenuItemEditApplication.Name = "MenuItemEditApplication";
            this.MenuItemEditApplication.Size = new System.Drawing.Size(289, 24);
            this.MenuItemEditApplication.Text = "Edit Application";
            this.MenuItemEditApplication.Click += new System.EventHandler(this.MenuItemEditApplication_Click);
            // 
            // MenuItemDeleteApp
            // 
            this.MenuItemDeleteApp.Image = global::DVLD.Properties.Resources.icons8_delete_64;
            this.MenuItemDeleteApp.Name = "MenuItemDeleteApp";
            this.MenuItemDeleteApp.Size = new System.Drawing.Size(289, 24);
            this.MenuItemDeleteApp.Text = "Delete Application";
            this.MenuItemDeleteApp.Click += new System.EventHandler(this.MenuItemDeleteApp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(286, 6);
            // 
            // MenuItemSchedualTest
            // 
            this.MenuItemSchedualTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schedualVisionTestToolStripMenuItem,
            this.schedualWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.MenuItemSchedualTest.Image = global::DVLD.Properties.Resources.application;
            this.MenuItemSchedualTest.Name = "MenuItemSchedualTest";
            this.MenuItemSchedualTest.Size = new System.Drawing.Size(289, 24);
            this.MenuItemSchedualTest.Text = "Schedule Tests";
            // 
            // schedualVisionTestToolStripMenuItem
            // 
            this.schedualVisionTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.search;
            this.schedualVisionTestToolStripMenuItem.Name = "schedualVisionTestToolStripMenuItem";
            this.schedualVisionTestToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.schedualVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.schedualVisionTestToolStripMenuItem.Click += new System.EventHandler(this.schedualVisionTestToolStripMenuItem_Click);
            // 
            // schedualWrittenTestToolStripMenuItem
            // 
            this.schedualWrittenTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.test1;
            this.schedualWrittenTestToolStripMenuItem.Name = "schedualWrittenTestToolStripMenuItem";
            this.schedualWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.schedualWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.valet;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(286, 6);
            // 
            // MenuItemIssueLicenseFirstTime
            // 
            this.MenuItemIssueLicenseFirstTime.Image = global::DVLD.Properties.Resources.license;
            this.MenuItemIssueLicenseFirstTime.Name = "MenuItemIssueLicenseFirstTime";
            this.MenuItemIssueLicenseFirstTime.Size = new System.Drawing.Size(289, 24);
            this.MenuItemIssueLicenseFirstTime.Text = "Issue Driving License (First time)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(286, 6);
            // 
            // MenuItemShowLicense
            // 
            this.MenuItemShowLicense.Image = global::DVLD.Properties.Resources.license;
            this.MenuItemShowLicense.Name = "MenuItemShowLicense";
            this.MenuItemShowLicense.Size = new System.Drawing.Size(289, 24);
            this.MenuItemShowLicense.Text = "Show License";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(286, 6);
            // 
            // MenuItemShowLicenseHistory
            // 
            this.MenuItemShowLicenseHistory.Image = global::DVLD.Properties.Resources.search_person;
            this.MenuItemShowLicenseHistory.Name = "MenuItemShowLicenseHistory";
            this.MenuItemShowLicenseHistory.Size = new System.Drawing.Size(289, 24);
            this.MenuItemShowLicenseHistory.Text = "Show Person License History";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(241, 580);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(20, 24);
            this.lblNumberOfRecords.TabIndex = 24;
            this.lblNumberOfRecords.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Number of records:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(383, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "Manage Local Driving License";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(931, 132);
            this.label3.MaximumSize = new System.Drawing.Size(150, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 40);
            this.label3.TabIndex = 30;
            this.label3.Text = "New Local Driving license application";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Filter by";
            // 
            // CbFilter
            // 
            this.CbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFilter.FormattingEnabled = true;
            this.CbFilter.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No.\t",
            "Full Name\t",
            "Status\t"});
            this.CbFilter.Location = new System.Drawing.Point(12, 211);
            this.CbFilter.Name = "CbFilter";
            this.CbFilter.Size = new System.Drawing.Size(217, 28);
            this.CbFilter.TabIndex = 31;
            this.CbFilter.SelectedIndexChanged += new System.EventHandler(this.CbFilter_SelectedIndexChanged);
            // 
            // TxtFilter
            // 
            this.TxtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFilter.Location = new System.Drawing.Point(235, 213);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(225, 26);
            this.TxtFilter.TabIndex = 33;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // RbNew
            // 
            this.RbNew.AutoSize = true;
            this.RbNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbNew.Location = new System.Drawing.Point(235, 215);
            this.RbNew.Name = "RbNew";
            this.RbNew.Size = new System.Drawing.Size(50, 19);
            this.RbNew.TabIndex = 34;
            this.RbNew.TabStop = true;
            this.RbNew.Text = "New";
            this.RbNew.UseVisualStyleBackColor = true;
            this.RbNew.Visible = false;
            this.RbNew.CheckedChanged += new System.EventHandler(this.RbNew_CheckedChanged);
            // 
            // RbCancelled
            // 
            this.RbCancelled.AutoSize = true;
            this.RbCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbCancelled.Location = new System.Drawing.Point(380, 215);
            this.RbCancelled.Name = "RbCancelled";
            this.RbCancelled.Size = new System.Drawing.Size(80, 19);
            this.RbCancelled.TabIndex = 35;
            this.RbCancelled.TabStop = true;
            this.RbCancelled.Text = "Cancelled";
            this.RbCancelled.UseVisualStyleBackColor = true;
            this.RbCancelled.Visible = false;
            this.RbCancelled.CheckedChanged += new System.EventHandler(this.RbCancelled_CheckedChanged);
            // 
            // rbCompleted
            // 
            this.rbCompleted.AutoSize = true;
            this.rbCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCompleted.Location = new System.Drawing.Point(289, 215);
            this.rbCompleted.Name = "rbCompleted";
            this.rbCompleted.Size = new System.Drawing.Size(85, 19);
            this.rbCompleted.TabIndex = 36;
            this.rbCompleted.TabStop = true;
            this.rbCompleted.Text = "Completed";
            this.rbCompleted.UseVisualStyleBackColor = true;
            this.rbCompleted.Visible = false;
            this.rbCompleted.CheckedChanged += new System.EventHandler(this.rbCompleted_CheckedChanged);
            // 
            // BtnAddLocalApplication
            // 
            this.BtnAddLocalApplication.BackgroundImage = global::DVLD.Properties.Resources.place;
            this.BtnAddLocalApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddLocalApplication.Location = new System.Drawing.Point(951, 175);
            this.BtnAddLocalApplication.Name = "BtnAddLocalApplication";
            this.BtnAddLocalApplication.Size = new System.Drawing.Size(95, 64);
            this.BtnAddLocalApplication.TabIndex = 29;
            this.BtnAddLocalApplication.UseVisualStyleBackColor = true;
            this.BtnAddLocalApplication.Click += new System.EventHandler(this.BtnAddLocalApplication_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.house;
            this.pictureBox2.Location = new System.Drawing.Point(607, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.folder;
            this.pictureBox1.Location = new System.Drawing.Point(466, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // FrmManageLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 621);
            this.Controls.Add(this.rbCompleted);
            this.Controls.Add(this.RbCancelled);
            this.Controls.Add(this.RbNew);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAddLocalApplication);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.DvgLocalDrvingLicenseApplication);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmManageLocalDrivingLicenseApplication";
            this.Text = "FrmManageLocalDrivingLicenseApplication";
            ((System.ComponentModel.ISupportInitialize)(this.DvgLocalDrvingLicenseApplication)).EndInit();
            this.CmLDLAppMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView DvgLocalDrvingLicenseApplication;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnAddLocalApplication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbFilter;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.RadioButton RbNew;
        private System.Windows.Forms.RadioButton RbCancelled;
        private System.Windows.Forms.RadioButton rbCompleted;
        private System.Windows.Forms.ContextMenuStrip CmLDLAppMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemShowAppDetails;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditApplication;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteApp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSchedualTest;
        private System.Windows.Forms.ToolStripMenuItem MenuItemIssueLicenseFirstTime;
        private System.Windows.Forms.ToolStripMenuItem MenuItemShowLicense;
        private System.Windows.Forms.ToolStripMenuItem MenuItemShowLicenseHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem schedualVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedualWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}