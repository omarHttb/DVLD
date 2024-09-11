namespace DVLD.Tests.VisionTest
{
    partial class FrmTestAppoinment
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
            this.PbTestPicture = new System.Windows.Forms.PictureBox();
            this.lblTestTypeAppointment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvTestAppointments = new System.Windows.Forms.DataGridView();
            this.CmTestMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnScheduleTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfRecord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.ucApplicationInfo1 = new DVLD.Application_Info_user_control.UcApplicationLocalLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.PbTestPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTestAppointments)).BeginInit();
            this.CmTestMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbTestPicture
            // 
            this.PbTestPicture.Location = new System.Drawing.Point(366, 12);
            this.PbTestPicture.Name = "PbTestPicture";
            this.PbTestPicture.Size = new System.Drawing.Size(157, 84);
            this.PbTestPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbTestPicture.TabIndex = 3;
            this.PbTestPicture.TabStop = false;
            // 
            // lblTestTypeAppointment
            // 
            this.lblTestTypeAppointment.AutoSize = true;
            this.lblTestTypeAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTypeAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTestTypeAppointment.Location = new System.Drawing.Point(198, 99);
            this.lblTestTypeAppointment.Name = "lblTestTypeAppointment";
            this.lblTestTypeAppointment.Size = new System.Drawing.Size(0, 42);
            this.lblTestTypeAppointment.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Appointments:";
            // 
            // DgvTestAppointments
            // 
            this.DgvTestAppointments.AllowUserToAddRows = false;
            this.DgvTestAppointments.AllowUserToDeleteRows = false;
            this.DgvTestAppointments.AllowUserToOrderColumns = true;
            this.DgvTestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTestAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvTestAppointments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTestAppointments.ContextMenuStrip = this.CmTestMenu;
            this.DgvTestAppointments.GridColor = System.Drawing.SystemColors.Control;
            this.DgvTestAppointments.Location = new System.Drawing.Point(49, 574);
            this.DgvTestAppointments.MultiSelect = false;
            this.DgvTestAppointments.Name = "DgvTestAppointments";
            this.DgvTestAppointments.ReadOnly = true;
            this.DgvTestAppointments.Size = new System.Drawing.Size(740, 174);
            this.DgvTestAppointments.TabIndex = 6;
            // 
            // CmTestMenu
            // 
            this.CmTestMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.CmTestMenu.Name = "CmTestMenu";
            this.CmTestMenu.Size = new System.Drawing.Size(134, 56);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_edit_64;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.test;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.takeTestToolStripMenuItem.Text = "TakeTest";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // BtnScheduleTest
            // 
            this.BtnScheduleTest.BackgroundImage = global::DVLD.Properties.Resources.test;
            this.BtnScheduleTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnScheduleTest.Location = new System.Drawing.Point(701, 509);
            this.BtnScheduleTest.Name = "BtnScheduleTest";
            this.BtnScheduleTest.Size = new System.Drawing.Size(59, 41);
            this.BtnScheduleTest.TabIndex = 7;
            this.BtnScheduleTest.UseVisualStyleBackColor = true;
            this.BtnScheduleTest.Click += new System.EventHandler(this.BtnScheduleTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Schedule A Test";
            // 
            // lblNumberOfRecord
            // 
            this.lblNumberOfRecord.AutoSize = true;
            this.lblNumberOfRecord.Location = new System.Drawing.Point(239, 763);
            this.lblNumberOfRecord.Name = "lblNumberOfRecord";
            this.lblNumberOfRecord.Size = new System.Drawing.Size(16, 18);
            this.lblNumberOfRecord.TabIndex = 9;
            this.lblNumberOfRecord.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 763);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number Of Records: ";
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(716, 751);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(73, 42);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ucApplicationInfo1
            // 
            this.ucApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucApplicationInfo1.FullName = null;
            this.ucApplicationInfo1.LicenseClass = null;
            this.ucApplicationInfo1.Location = new System.Drawing.Point(1, 145);
            this.ucApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ucApplicationInfo1.Name = "ucApplicationInfo1";
            this.ucApplicationInfo1.PassedTest = 0;
            this.ucApplicationInfo1.Size = new System.Drawing.Size(810, 365);
            this.ucApplicationInfo1.TabIndex = 12;
            // 
            // FrmTestAppoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 796);
            this.Controls.Add(this.ucApplicationInfo1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumberOfRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnScheduleTest);
            this.Controls.Add(this.DgvTestAppointments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTestTypeAppointment);
            this.Controls.Add(this.PbTestPicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTestAppoinment";
            this.Text = "VisionTestAppoinment";
            this.Load += new System.EventHandler(this.FrmVisionTestAppoinment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbTestPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTestAppointments)).EndInit();
            this.CmTestMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbTestPicture;
        private System.Windows.Forms.Label lblTestTypeAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvTestAppointments;
        private System.Windows.Forms.Button BtnScheduleTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnClose;
        private Application_Info_user_control.UcApplicationLocalLicenseInfo ucApplicationInfo1;
        private System.Windows.Forms.ContextMenuStrip CmTestMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}