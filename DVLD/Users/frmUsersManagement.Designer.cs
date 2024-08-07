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
            this.lblNumberOfUsers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVLDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVLDDataSet = new DVLD.DVLDDataSet();
            this.peopleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new DVLD.DVLDDataSetTableAdapters.PeopleTableAdapter();
            this.usersTableAdapter = new DVLD.DVLDDataSetTableAdapters.UsersTableAdapter();
            this.rbIsActive = new System.Windows.Forms.RadioButton();
            this.rbNotActive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVLDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVLDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(509, 226);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(201, 26);
            this.txtFilter.TabIndex = 17;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 203);
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
            this.CbFilter.Location = new System.Drawing.Point(274, 226);
            this.CbFilter.Name = "CbFilter";
            this.CbFilter.Size = new System.Drawing.Size(217, 28);
            this.CbFilter.TabIndex = 15;
            this.CbFilter.SelectedIndexChanged += new System.EventHandler(this.CbFilter_SelectedIndexChanged);
            // 
            // lblPeopleManagement
            // 
            this.lblPeopleManagement.AutoSize = true;
            this.lblPeopleManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleManagement.Location = new System.Drawing.Point(376, 182);
            this.lblPeopleManagement.Name = "lblPeopleManagement";
            this.lblPeopleManagement.Size = new System.Drawing.Size(262, 31);
            this.lblPeopleManagement.TabIndex = 14;
            this.lblPeopleManagement.Text = "People Management";
            // 
            // DgvAllUsers
            // 
            this.DgvAllUsers.AllowUserToAddRows = false;
            this.DgvAllUsers.AllowUserToDeleteRows = false;
            this.DgvAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAllUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DgvAllUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvAllUsers.Location = new System.Drawing.Point(70, 260);
            this.DgvAllUsers.MultiSelect = false;
            this.DgvAllUsers.Name = "DgvAllUsers";
            this.DgvAllUsers.ReadOnly = true;
            this.DgvAllUsers.Size = new System.Drawing.Size(930, 344);
            this.DgvAllUsers.TabIndex = 12;
            // 
            // lblNumberOfUsers
            // 
            this.lblNumberOfUsers.AutoSize = true;
            this.lblNumberOfUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfUsers.Location = new System.Drawing.Point(355, 606);
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
            this.btnClose.Location = new System.Drawing.Point(916, 612);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 32);
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
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.add_user;
            this.pictureBox1.Location = new System.Drawing.Point(877, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbPeople
            // 
            this.pbPeople.Image = global::DVLD.Properties.Resources.user;
            this.pbPeople.Location = new System.Drawing.Point(371, 12);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(258, 159);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 13;
            this.pbPeople.TabStop = false;
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
            this.rbIsActive.Location = new System.Drawing.Point(509, 226);
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
            this.rbNotActive.Location = new System.Drawing.Point(602, 226);
            this.rbNotActive.Name = "rbNotActive";
            this.rbNotActive.Size = new System.Drawing.Size(93, 22);
            this.rbNotActive.TabIndex = 24;
            this.rbNotActive.TabStop = true;
            this.rbNotActive.Text = "Not Active";
            this.rbNotActive.UseVisualStyleBackColor = true;
            this.rbNotActive.Visible = false;
            this.rbNotActive.CheckedChanged += new System.EventHandler(this.rbNotActive_CheckedChanged);
            // 
            // frmUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 646);
            this.Controls.Add(this.rbNotActive);
            this.Controls.Add(this.rbIsActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumberOfUsers);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbFilter);
            this.Controls.Add(this.lblPeopleManagement);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.DgvAllUsers);
            this.Name = "frmUsersManagement";
            this.Text = "frmUsersManagement";
            this.Load += new System.EventHandler(this.frmUsersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVLDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVLDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource dVLDDataSetBindingSource;
        private DVLDDataSet dVLDDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private DVLDDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.BindingSource peopleBindingSource1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DVLDDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.RadioButton rbIsActive;
        private System.Windows.Forms.RadioButton rbNotActive;
    }
}