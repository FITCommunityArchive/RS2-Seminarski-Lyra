﻿namespace Lyra.WinUI.UserControls.Administrator.User
{
    partial class ucUserEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.clbRoles = new System.Windows.Forms.CheckedListBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbRoles = new System.Windows.Forms.GroupBox();
            this.errorProviderFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.gbRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 620);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(301, 101);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(188, 22);
            this.txtFirstName.TabIndex = 25;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.FirstName_Validating);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(298, 85);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 26;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(534, 85);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 28;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(537, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(188, 22);
            this.txtLastName.TabIndex = 27;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.LastName_Validating);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(298, 146);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 30;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(301, 162);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(188, 22);
            this.txtUsername.TabIndex = 29;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.Username_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(534, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(537, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 22);
            this.txtEmail.TabIndex = 31;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(298, 206);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(75, 13);
            this.lblPhoneNumber.TabIndex = 34;
            this.lblPhoneNumber.Text = "PhoneNumber";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(301, 222);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(188, 22);
            this.txtPhoneNumber.TabIndex = 33;
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneNumber_Validating);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(51, 291);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(188, 23);
            this.btnUploadImage.TabIndex = 58;
            this.btnUploadImage.Text = "Change image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // pbUserImage
            // 
            this.pbUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUserImage.Location = new System.Drawing.Point(51, 85);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(188, 184);
            this.pbUserImage.TabIndex = 57;
            this.pbUserImage.TabStop = false;
            // 
            // clbRoles
            // 
            this.clbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbRoles.FormattingEnabled = true;
            this.clbRoles.Location = new System.Drawing.Point(23, 36);
            this.clbRoles.Name = "clbRoles";
            this.clbRoles.Size = new System.Drawing.Size(673, 148);
            this.clbRoles.TabIndex = 61;
            // 
            // gbInfo
            // 
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(28, 41);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(719, 296);
            this.gbInfo.TabIndex = 62;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // gbRoles
            // 
            this.gbRoles.Controls.Add(this.clbRoles);
            this.gbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoles.Location = new System.Drawing.Point(28, 367);
            this.gbRoles.Name = "gbRoles";
            this.gbRoles.Size = new System.Drawing.Size(719, 224);
            this.gbRoles.TabIndex = 63;
            this.gbRoles.TabStop = false;
            this.gbRoles.Text = "Roles";
            // 
            // errorProviderFirstName
            // 
            this.errorProviderFirstName.ContainerControl = this;
            // 
            // errorProviderLastName
            // 
            this.errorProviderLastName.ContainerControl = this;
            // 
            // errorProviderUsername
            // 
            this.errorProviderUsername.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderPhoneNumber
            // 
            this.errorProviderPhoneNumber.ContainerControl = this;
            // 
            // ucUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.pbUserImage);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbRoles);
            this.Name = "ucUserEdit";
            this.Size = new System.Drawing.Size(796, 690);
            this.Load += new System.EventHandler(this.ucUserEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.gbRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhoneNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.CheckedListBox clbRoles;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbRoles;
        private System.Windows.Forms.ErrorProvider errorProviderFirstName;
        private System.Windows.Forms.ErrorProvider errorProviderLastName;
        private System.Windows.Forms.ErrorProvider errorProviderUsername;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderPhoneNumber;
    }
}
