namespace DVLD.Users
{
    partial class frmUserDetails
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
            this.btnClose = new System.Windows.Forms.Button();
            this.ucPersonDetails1 = new DVLD.UserControls.UcPersonDetails();
            this.ucUserDetails1 = new DVLD.UserControls.UcUserDetails();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(798, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucPersonDetails1
            // 
            this.ucPersonDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPersonDetails1.Location = new System.Drawing.Point(13, 14);
            this.ucPersonDetails1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPersonDetails1.Name = "ucPersonDetails1";
            this.ucPersonDetails1.Size = new System.Drawing.Size(903, 398);
            this.ucPersonDetails1.TabIndex = 1;
            // 
            // ucUserDetails1
            // 
            this.ucUserDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUserDetails1.Location = new System.Drawing.Point(108, 399);
            this.ucUserDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.ucUserDetails1.Name = "ucUserDetails1";
            this.ucUserDetails1.Size = new System.Drawing.Size(710, 142);
            this.ucUserDetails1.TabIndex = 0;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 594);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucPersonDetails1);
            this.Controls.Add(this.ucUserDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUserDetails";
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UcUserDetails ucUserDetails1;
        private UserControls.UcPersonDetails ucPersonDetails1;
        private System.Windows.Forms.Button btnClose;
    }
}