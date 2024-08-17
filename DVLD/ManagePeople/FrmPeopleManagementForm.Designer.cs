namespace DVLD
{
    partial class FrmPeopleManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeopleManagementForm));
            this.DGVAllPeople = new System.Windows.Forms.DataGridView();
            this.CmsRecords = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuViewInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPeopleManagement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNumberOfPeople = new System.Windows.Forms.Label();
            this.CbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllPeople)).BeginInit();
            this.CmsRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAllPeople
            // 
            this.DGVAllPeople.AllowUserToAddRows = false;
            this.DGVAllPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAllPeople.ContextMenuStrip = this.CmsRecords;
            this.DGVAllPeople.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVAllPeople.Location = new System.Drawing.Point(0, 205);
            this.DGVAllPeople.Name = "DGVAllPeople";
            this.DGVAllPeople.Size = new System.Drawing.Size(1160, 344);
            this.DGVAllPeople.TabIndex = 0;
            // 
            // CmsRecords
            // 
            this.CmsRecords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuViewInfo,
            this.editToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.CmsRecords.Name = "CmsRecords";
            this.CmsRecords.Size = new System.Drawing.Size(139, 76);
            // 
            // toolStripMenuViewInfo
            // 
            this.toolStripMenuViewInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuViewInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuViewInfo.Image = global::DVLD.Properties.Resources.view_details;
            this.toolStripMenuViewInfo.Name = "toolStripMenuViewInfo";
            this.toolStripMenuViewInfo.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuViewInfo.Text = "View Info";
            this.toolStripMenuViewInfo.Click += new System.EventHandler(this.toolStripMenuViewInfo_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_delete_64;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // lblPeopleManagement
            // 
            this.lblPeopleManagement.AutoSize = true;
            this.lblPeopleManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleManagement.Location = new System.Drawing.Point(8, 171);
            this.lblPeopleManagement.Name = "lblPeopleManagement";
            this.lblPeopleManagement.Size = new System.Drawing.Size(262, 31);
            this.lblPeopleManagement.TabIndex = 2;
            this.lblPeopleManagement.Text = "People Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1026, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of people : ";
            // 
            // LblNumberOfPeople
            // 
            this.LblNumberOfPeople.AutoSize = true;
            this.LblNumberOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberOfPeople.Location = new System.Drawing.Point(192, 554);
            this.LblNumberOfPeople.Name = "LblNumberOfPeople";
            this.LblNumberOfPeople.Size = new System.Drawing.Size(18, 20);
            this.LblNumberOfPeople.TabIndex = 7;
            this.LblNumberOfPeople.Text = "0";
            // 
            // CbFilter
            // 
            this.CbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFilter.FormattingEnabled = true;
            this.CbFilter.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "Nationalitiy No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name ",
            "Nationality",
            "Phone",
            "Email"});
            this.CbFilter.Location = new System.Drawing.Point(280, 174);
            this.CbFilter.Name = "CbFilter";
            this.CbFilter.Size = new System.Drawing.Size(217, 28);
            this.CbFilter.TabIndex = 8;
            this.CbFilter.SelectedIndexChanged += new System.EventHandler(this.CbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter by";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(1031, 551);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 32);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(503, 176);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(201, 26);
            this.txtFilter.TabIndex = 11;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.person_add_icon_2048x2048_8zmguv5l;
            this.pictureBox1.Location = new System.Drawing.Point(1027, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbPeople
            // 
            this.pbPeople.Image = global::DVLD.Properties.Resources.download;
            this.pbPeople.Location = new System.Drawing.Point(12, 12);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(258, 159);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPeople.TabIndex = 1;
            this.pbPeople.TabStop = false;
            // 
            // FrmPeopleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1163, 583);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbFilter);
            this.Controls.Add(this.LblNumberOfPeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPeopleManagement);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.DGVAllPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPeopleManagementForm";
            this.Text = "Manage people";
            this.Load += new System.EventHandler(this.PeopleManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllPeople)).EndInit();
            this.CmsRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAllPeople;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.Label lblPeopleManagement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip CmsRecords;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblNumberOfPeople;
        private System.Windows.Forms.ComboBox CbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuViewInfo;
    }
}