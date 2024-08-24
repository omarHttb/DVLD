namespace DVLD.Users
{
    partial class frmUsersManagement
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
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbFilter = new System.Windows.Forms.ComboBox();
            this.lblPeopleManagement = new System.Windows.Forms.Label();
            this.DgvAllUsers = new System.Windows.Forms.DataGridView();
            this.CmUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumberOfUsers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVLDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVLDDataSet = new DVLD.DVLDDataSet();
            this.peopleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new DVLD.DVLDDataSetTableAdapters.PeopleTableAdapter();
            this.usersTableAdapter = new DVLD.DVLDDataSetTableAdapters.UsersTableAdapter();
            this.rbIsActive = new System.Windows.Forms.RadioButton();
            this.rbNotActive = new System.Windows.Forms.RadioButton();
            this.RbActiveAndNotActive = new System.Windows.Forms.RadioButton();
            this.PbAddNewUser = new System.Windows.Forms.PictureBox();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllUsers)).BeginInit();
            this.CmUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVLDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVLDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddNewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(305, 226);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(201, 26);
            this.txtFilter.TabIndex = 17;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Filter by";
            // 
            // CbFilter
            // 
            this.CbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFilter.FormattingEnabled = true;
            this.CbFilter.Items.AddRange(new object[] {
            "None",
            "User ID",
            "User Name",
            "PersonID",
            "Full Name",
            "is Active\t"});
            this.CbFilter.Location = new System.Drawing.Point(70, 226);
            this.CbFilter.Name = "CbFilter";
            this.CbFilter.Size = new System.Drawing.Size(217, 28);
            this.CbFilter.TabIndex = 15;
            this.CbFilter.SelectedIndexChanged += new System.EventHandler(this.CbFilter_SelectedIndexChanged);
            // 
            // lblPeopleManagement
            // 
            this.lblPeopleManagement.AutoSize = true;
            this.lblPeopleManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleManagement.Location = new System.Drawing.Point(403, 182);
            this.lblPeopleManagement.Name = "lblPeopleManagement";
            this.lblPeopleManagement.Size = new System.Drawing.Size(250, 31);
            this.lblPeopleManagement.TabIndex = 14;
            this.lblPeopleManagement.Text = "Users Management";
            // 
            // DgvAllUsers
            // 
            this.DgvAllUsers.AllowUserToAddRows = false;
            this.DgvAllUsers.AllowUserToDeleteRows = false;
            this.DgvAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAllUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DgvAllUsers.ContextMenuStrip = this.CmUsers;
            this.DgvAllUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvAllUsers.Location = new System.Drawing.Point(70, 260);
            this.DgvAllUsers.MultiSelect = false;
            this.DgvAllUsers.Name = "DgvAllUsers";
            this.DgvAllUsers.ReadOnly = true;
            this.DgvAllUsers.Size = new System.Drawing.Size(930, 344);
            this.DgvAllUsers.TabIndex = 12;
            // 
            // CmUsers
            // 
            this.CmUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.CmUsers.Name = "CmUsers";
            this.CmUsers.Size = new System.Drawing.Size(169, 92);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoToolStripMenuItem.Image = global::DVLD.Properties.Resources.view_details;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_edit_64;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_delete_64;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_change_password_58;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // lblNumberOfUsers
            // 
            this.lblNumberOfUsers.AutoSize = true;
            this.lblNumberOfUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfUsers.Location = new System.Drawing.Point(365, 608);
            this.lblNumberOfUsers.Name = "lblNumberOfUsers";
            this.lblNumberOfUsers.Size = new System.Drawing.Size(29, 31);
            this.lblNumberOfUsers.TabIndex = 18;
            this.lblNumberOfUsers.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 607);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Number of records :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(912, 610);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 36);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(884, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Add User";
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.dVLDDataSetBindingSource;
            // 
            // dVLDDataSetBindingSource
            // 
            this.dVLDDataSetBindingSource.DataSource = this.dVLDDataSet;
            this.dVLDDataSetBindingSource.Position = 0;
            // 
            // dVLDDataSet
            // 
            this.dVLDDataSet.DataSetName = "DVLDDataSet";
            this.dVLDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleBindingSource1
            // 
            this.peopleBindingSource1.DataMember = "People";
            this.peopleBindingSource1.DataSource = this.dVLDDataSetBindingSource;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dVLDDataSetBindingSource;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // rbIsActive
            // 
            this.rbIsActive.AutoSize = true;
            this.rbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIsActive.Location = new System.Drawing.Point(305, 226);
            this.rbIsActive.Name = "rbIsActive";
            this.rbIsActive.Size = new System.Drawing.Size(65, 22);
            this.rbIsActive.TabIndex = 23;
            this.rbIsActive.TabStop = true;
            this.rbIsActive.Text = "Active";
            this.rbIsActive.UseVisualStyleBackColor = true;
            this.rbIsActive.Visible = false;
            this.rbIsActive.CheckedChanged += new System.EventHandler(this.rbIsActive_CheckedChanged);
            // 
            // rbNotActive
            // 
            this.rbNotActive.AutoSize = true;
            this.rbNotActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotActive.Location = new System.Drawing.Point(398, 226);
            this.rbNotActive.Name = "rbNotActive";
            this.rbNotActive.Size = new System.Drawing.Size(93, 22);
            this.rbNotActive.TabIndex = 24;
            this.rbNotActive.TabStop = true;
            this.rbNotActive.Text = "Not Active";
            this.rbNotActive.UseVisualStyleBackColor = true;
            this.rbNotActive.Visible = false;
            this.rbNotActive.CheckedChanged += new System.EventHandler(this.rbNotActive_CheckedChanged);
            // 
            // RbActiveAndNotActive
            // 
            this.RbActiveAndNotActive.AutoSize = true;
            this.RbActiveAndNotActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbActiveAndNotActive.Location = new System.Drawing.Point(512, 226);
            this.RbActiveAndNotActive.Name = "RbActiveAndNotActive";
            this.RbActiveAndNotActive.Size = new System.Drawing.Size(45, 22);
            this.RbActiveAndNotActive.TabIndex = 25;
            this.RbActiveAndNotActive.TabStop = true;
            this.RbActiveAndNotActive.Text = "All ";
            this.RbActiveAndNotActive.UseVisualStyleBackColor = true;
            this.RbActiveAndNotActive.Visible = false;
            this.RbActiveAndNotActive.CheckedChanged += new System.EventHandler(this.RbActiveAndNotActive_CheckedChanged);
            // 
            // PbAddNewUser
            // 
            this.PbAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbAddNewUser.Image = global::DVLD.Properties.Resources.add_user;
            this.PbAddNewUser.Location = new System.Drawing.Point(877, 182);
            this.PbAddNewUser.Name = "PbAddNewUser";
            this.PbAddNewUser.Size = new System.Drawing.Size(123, 72);
            this.PbAddNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAddNewUser.TabIndex = 21;
            this.PbAddNewUser.TabStop = false;
            this.PbAddNewUser.Click += new System.EventHandler(this.PbAddNewUser_Click);
            // 
            // pbPeople
            // 
            this.pbPeople.Image = global::DVLD.Properties.Resources.user;
            this.pbPeople.Location = new System.Drawing.Point(398, 12);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(258, 159);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 13;
            this.pbPeople.TabStop = false;
            // 
            // frmUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 655);
            this.Controls.Add(this.RbActiveAndNotActive);
            this.Controls.Add(this.rbNotActive);
            this.Controls.Add(this.rbIsActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PbAddNewUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumberOfUsers);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbFilter);
            this.Controls.Add(this.lblPeopleManagement);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.DgvAllUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmUsersManagement";
            this.Text = "Users Management";
            this.Load += new System.EventHandler(this.frmUsersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllUsers)).EndInit();
            this.CmUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVLDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVLDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddNewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbFilter;
        private System.Windows.Forms.Label lblPeopleManagement;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.DataGridView DgvAllUsers;
        private System.Windows.Forms.Label lblNumberOfUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PbAddNewUser;
        private System.Windows.Forms.BindingSource dVLDDataSetBindingSource;
        private DVLDDataSet dVLDDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private DVLDDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.BindingSource peopleBindingSource1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DVLDDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.RadioButton rbIsActive;
        private System.Windows.Forms.RadioButton rbNotActive;
        private System.Windows.Forms.RadioButton RbActiveAndNotActive;
        private System.Windows.Forms.ContextMenuStrip CmUsers;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}