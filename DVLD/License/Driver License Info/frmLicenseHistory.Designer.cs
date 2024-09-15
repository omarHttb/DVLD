namespace DVLD.License.Driver_License_Info
{
    partial class frmLicenseHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.DgvAllLocalLicense = new System.Windows.Forms.DataGridView();
            this.CmLocalLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TcLicenseHistory = new System.Windows.Forms.TabControl();
            this.TpLocal = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.TpInternational = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInternationalLicenseRecord = new System.Windows.Forms.Label();
            this.DgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.CmGlobalLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ucSearchForPerson1 = new DVLD.UserControls.UcSearchForPerson();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllLocalLicense)).BeginInit();
            this.CmLocalLicense.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TcLicenseHistory.SuspendLayout();
            this.TpLocal.SuspendLayout();
            this.TpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInternationalLicenses)).BeginInit();
            this.CmGlobalLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(491, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "License History";
            // 
            // DgvAllLocalLicense
            // 
            this.DgvAllLocalLicense.AllowUserToAddRows = false;
            this.DgvAllLocalLicense.AllowUserToDeleteRows = false;
            this.DgvAllLocalLicense.AllowUserToOrderColumns = true;
            this.DgvAllLocalLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAllLocalLicense.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DgvAllLocalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAllLocalLicense.ContextMenuStrip = this.CmLocalLicense;
            this.DgvAllLocalLicense.Location = new System.Drawing.Point(0, 0);
            this.DgvAllLocalLicense.Name = "DgvAllLocalLicense";
            this.DgvAllLocalLicense.Size = new System.Drawing.Size(1139, 183);
            this.DgvAllLocalLicense.TabIndex = 2;
            // 
            // CmLocalLicense
            // 
            this.CmLocalLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.CmLocalLicense.Name = "contextMenuStrip1";
            this.CmLocalLicense.Size = new System.Drawing.Size(195, 28);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.searchLicense;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TcLicenseHistory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 622);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 268);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver License";
            // 
            // TcLicenseHistory
            // 
            this.TcLicenseHistory.Controls.Add(this.TpLocal);
            this.TcLicenseHistory.Controls.Add(this.TpInternational);
            this.TcLicenseHistory.Location = new System.Drawing.Point(6, 23);
            this.TcLicenseHistory.Name = "TcLicenseHistory";
            this.TcLicenseHistory.SelectedIndex = 0;
            this.TcLicenseHistory.Size = new System.Drawing.Size(1147, 239);
            this.TcLicenseHistory.TabIndex = 4;
            // 
            // TpLocal
            // 
            this.TpLocal.Controls.Add(this.label3);
            this.TpLocal.Controls.Add(this.lblRecords);
            this.TpLocal.Controls.Add(this.DgvAllLocalLicense);
            this.TpLocal.Location = new System.Drawing.Point(4, 27);
            this.TpLocal.Name = "TpLocal";
            this.TpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.TpLocal.Size = new System.Drawing.Size(1139, 208);
            this.TpLocal.TabIndex = 0;
            this.TpLocal.Text = "Local";
            this.TpLocal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "# Records:";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(110, 185);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(36, 20);
            this.lblRecords.TabIndex = 3;
            this.lblRecords.Text = "???";
            // 
            // TpInternational
            // 
            this.TpInternational.Controls.Add(this.label2);
            this.TpInternational.Controls.Add(this.lblInternationalLicenseRecord);
            this.TpInternational.Controls.Add(this.DgvInternationalLicenses);
            this.TpInternational.Location = new System.Drawing.Point(4, 27);
            this.TpInternational.Name = "TpInternational";
            this.TpInternational.Padding = new System.Windows.Forms.Padding(3);
            this.TpInternational.Size = new System.Drawing.Size(1139, 208);
            this.TpInternational.TabIndex = 1;
            this.TpInternational.Text = "International";
            this.TpInternational.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "# Records:";
            // 
            // lblInternationalLicenseRecord
            // 
            this.lblInternationalLicenseRecord.AutoSize = true;
            this.lblInternationalLicenseRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicenseRecord.Location = new System.Drawing.Point(110, 186);
            this.lblInternationalLicenseRecord.Name = "lblInternationalLicenseRecord";
            this.lblInternationalLicenseRecord.Size = new System.Drawing.Size(36, 20);
            this.lblInternationalLicenseRecord.TabIndex = 6;
            this.lblInternationalLicenseRecord.Text = "???";
            // 
            // DgvInternationalLicenses
            // 
            this.DgvInternationalLicenses.AllowUserToAddRows = false;
            this.DgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.DgvInternationalLicenses.AllowUserToOrderColumns = true;
            this.DgvInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInternationalLicenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInternationalLicenses.ContextMenuStrip = this.CmGlobalLicense;
            this.DgvInternationalLicenses.Location = new System.Drawing.Point(0, 1);
            this.DgvInternationalLicenses.Name = "DgvInternationalLicenses";
            this.DgvInternationalLicenses.Size = new System.Drawing.Size(1139, 183);
            this.DgvInternationalLicenses.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1080, 896);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CmGlobalLicense
            // 
            this.CmGlobalLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.CmGlobalLicense.Name = "contextMenuStrip1";
            this.CmGlobalLicense.Size = new System.Drawing.Size(195, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::DVLD.Properties.Resources.searchLicense;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 24);
            this.toolStripMenuItem1.Text = "Show License Info";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ucSearchForPerson1
            // 
            this.ucSearchForPerson1.Age = 0;
            this.ucSearchForPerson1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSearchForPerson1.Location = new System.Drawing.Point(5, 32);
            this.ucSearchForPerson1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSearchForPerson1.Name = "ucSearchForPerson1";
            this.ucSearchForPerson1.NationalNo = null;
            this.ucSearchForPerson1.Size = new System.Drawing.Size(1158, 596);
            this.ucSearchForPerson1.TabIndex = 1;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 932);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucSearchForPerson1);
            this.Name = "frmLicenseHistory";
            this.Text = "frmLicenseHistory";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllLocalLicense)).EndInit();
            this.CmLocalLicense.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.TcLicenseHistory.ResumeLayout(false);
            this.TpLocal.ResumeLayout(false);
            this.TpLocal.PerformLayout();
            this.TpInternational.ResumeLayout(false);
            this.TpInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInternationalLicenses)).EndInit();
            this.CmGlobalLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UserControls.UcSearchForPerson ucSearchForPerson1;
        private System.Windows.Forms.DataGridView DgvAllLocalLicense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl TcLicenseHistory;
        private System.Windows.Forms.TabPage TpLocal;
        private System.Windows.Forms.TabPage TpInternational;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInternationalLicenseRecord;
        private System.Windows.Forms.DataGridView DgvInternationalLicenses;
        private System.Windows.Forms.ContextMenuStrip CmLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CmGlobalLicense;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}