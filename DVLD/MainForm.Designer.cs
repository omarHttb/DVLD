namespace DVLD
{
    partial class MainForm
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
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.lblPeople = new System.Windows.Forms.Label();
            this.BtnPeopleManagement = new System.Windows.Forms.Button();
            this.PnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.DimGray;
            this.PnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMenu.Controls.Add(this.lblPeople);
            this.PnlMenu.Controls.Add(this.BtnPeopleManagement);
            this.PnlMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlMenu.Location = new System.Drawing.Point(-4, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(1159, 608);
            this.PnlMenu.TabIndex = 0;
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Location = new System.Drawing.Point(70, 134);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(98, 31);
            this.lblPeople.TabIndex = 1;
            this.lblPeople.Text = "People";
            // 
            // BtnPeopleManagement
            // 
            this.BtnPeopleManagement.Image = global::DVLD.Properties.Resources.download1;
            this.BtnPeopleManagement.Location = new System.Drawing.Point(64, 38);
            this.BtnPeopleManagement.Name = "BtnPeopleManagement";
            this.BtnPeopleManagement.Size = new System.Drawing.Size(115, 93);
            this.BtnPeopleManagement.TabIndex = 0;
            this.BtnPeopleManagement.UseVisualStyleBackColor = true;
            this.BtnPeopleManagement.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1150, 606);
            this.Controls.Add(this.PnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnPeopleManagement;
        private System.Windows.Forms.Label lblPeople;
    }
}

