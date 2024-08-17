namespace DVLD.Users
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.TcNewUser = new System.Windows.Forms.TabControl();
            this.TbPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.TbLoginInfo = new System.Windows.Forms.TabPage();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.LblUserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnCLose = new System.Windows.Forms.Button();
            this.EpAddNewUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucSearchForPerson1 = new DVLD.UserControls.UcSearchForPerson();
            this.TcNewUser.SuspendLayout();
            this.TbPersonInfo.SuspendLayout();
            this.TbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EpAddNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // TcNewUser
            // 
            this.TcNewUser.Controls.Add(this.TbPersonInfo);
            this.TcNewUser.Controls.Add(this.TbLoginInfo);
            this.TcNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcNewUser.Location = new System.Drawing.Point(12, 35);
            this.TcNewUser.Name = "TcNewUser";
            this.TcNewUser.SelectedIndex = 0;
            this.TcNewUser.Size = new System.Drawing.Size(1216, 693);
            this.TcNewUser.TabIndex = 0;
            // 
            // TbPersonInfo
            // 
            this.TbPersonInfo.Controls.Add(this.btnNextPage);
            this.TbPersonInfo.Controls.Add(this.ucSearchForPerson1);
            this.TbPersonInfo.Location = new System.Drawing.Point(4, 27);
            this.TbPersonInfo.Name = "TbPersonInfo";
            this.TbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TbPersonInfo.Size = new System.Drawing.Size(1208, 662);
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
            this.TbLoginInfo.Controls.Add(this.BtnSave);
            this.TbLoginInfo.Controls.Add(this.ChkActive);
            this.TbLoginInfo.Controls.Add(this.txtUserName);
            this.TbLoginInfo.Controls.Add(this.TxtPassword);
            this.TbLoginInfo.Controls.Add(this.TxtConfirmPassword);
            this.TbLoginInfo.Controls.Add(this.LblUserID);
            this.TbLoginInfo.Controls.Add(this.label5);
            this.TbLoginInfo.Controls.Add(this.label4);
            this.TbLoginInfo.Controls.Add(this.label3);
            this.TbLoginInfo.Controls.Add(this.label2);
            this.TbLoginInfo.Location = new System.Drawing.Point(4, 27);
            this.TbLoginInfo.Name = "TbLoginInfo";
            this.TbLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TbLoginInfo.Size = new System.Drawing.Size(1208, 662);
            this.TbLoginInfo.TabIndex = 1;
            this.TbLoginInfo.Text = "Login info";
            this.TbLoginInfo.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(1065, 591);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(126, 46);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Location = new System.Drawing.Point(336, 330);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(147, 22);
            this.ChkActive.TabIndex = 8;
            this.ChkActive.Text = "Make user active?";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(336, 164);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(176, 24);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(336, 203);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(176, 24);
            this.TxtPassword.TabIndex = 6;
            this.TxtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(336, 244);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PasswordChar = '*';
            this.TxtConfirmPassword.Size = new System.Drawing.Size(176, 24);
            this.TxtConfirmPassword.TabIndex = 7;
            this.TxtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtConfirmPassword_Validating);
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserID.Location = new System.Drawing.Point(332, 122);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(40, 24);
            this.LblUserID.TabIndex = 4;
            this.LblUserID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Confrim Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "User ID :";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMode.Location = new System.Drawing.Point(494, 9);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(259, 42);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "Add new user";
            // 
            // btnCLose
            // 
            this.btnCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.Location = new System.Drawing.Point(1081, 734);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(126, 46);
            this.btnCLose.TabIndex = 1;
            this.btnCLose.Text = "Close";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // EpAddNewUser
            // 
            this.EpAddNewUser.ContainerControl = this;
            this.EpAddNewUser.Icon = ((System.Drawing.Icon)(resources.GetObject("EpAddNewUser.Icon")));
            // 
            // ucSearchForPerson1
            // 
            this.ucSearchForPerson1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSearchForPerson1.Location = new System.Drawing.Point(16, 19);
            this.ucSearchForPerson1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSearchForPerson1.Name = "ucSearchForPerson1";
            this.ucSearchForPerson1.Size = new System.Drawing.Size(1157, 592);
            this.ucSearchForPerson1.TabIndex = 2;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 792);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.TcNewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUser";
            this.Text = "add and update users";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.TcNewUser.ResumeLayout(false);
            this.TbPersonInfo.ResumeLayout(false);
            this.TbLoginInfo.ResumeLayout(false);
            this.TbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EpAddNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TcNewUser;
        private System.Windows.Forms.TabPage TbPersonInfo;
        private System.Windows.Forms.TabPage TbLoginInfo;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnCLose;
        private UserControls.UcSearchForPerson ucSearchForPerson1;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider EpAddNewUser;
    }
}