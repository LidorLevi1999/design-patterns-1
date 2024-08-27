using System;

namespace BasicFacebookFeatures
{
    partial class ProfilePageTab
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
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.Label();
            this.userGender = new System.Windows.Forms.Label();
            this.userBirthday = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.releationshipStatus = new System.Windows.Forms.Label();
            this.newStatusTextbox = new System.Windows.Forms.TextBox();
            this.postNewStatusLabel = new System.Windows.Forms.Label();
            this.postNewStatusButton = new System.Windows.Forms.Button();
            this.createMemeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // profileImage
            // 
            this.profileImage.Location = new System.Drawing.Point(10, 20);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(100, 120);
            this.profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImage.TabIndex = 0;
            this.profileImage.TabStop = false;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(120, 20);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(35, 13);
            this.userName.TabIndex = 1;
            this.userName.Text = "Name";
            // 
            // userEmail
            // 
            this.userEmail.AutoSize = true;
            this.userEmail.Location = new System.Drawing.Point(120, 45);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(32, 13);
            this.userEmail.TabIndex = 2;
            this.userEmail.Text = "Email";
            // 
            // userGender
            // 
            this.userGender.AutoSize = true;
            this.userGender.Location = new System.Drawing.Point(120, 70);
            this.userGender.Name = "userGender";
            this.userGender.Size = new System.Drawing.Size(42, 13);
            this.userGender.TabIndex = 3;
            this.userGender.Text = "Gender";
            // 
            // userBirthday
            // 
            this.userBirthday.AutoSize = true;
            this.userBirthday.Location = new System.Drawing.Point(120, 95);
            this.userBirthday.Name = "userBirthday";
            this.userBirthday.Size = new System.Drawing.Size(45, 13);
            this.userBirthday.TabIndex = 4;
            this.userBirthday.Text = "Birthday";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(405, 20);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // releationshipStatus
            // 
            this.releationshipStatus.AutoSize = true;
            this.releationshipStatus.Location = new System.Drawing.Point(120, 120);
            this.releationshipStatus.Name = "releationshipStatus";
            this.releationshipStatus.Size = new System.Drawing.Size(98, 13);
            this.releationshipStatus.TabIndex = 6;
            this.releationshipStatus.Text = "Relationship Status";
            // 
            // newStatusTextbox
            // 
            this.newStatusTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newStatusTextbox.Location = new System.Drawing.Point(10, 184);
            this.newStatusTextbox.Name = "newStatusTextbox";
            this.newStatusTextbox.Size = new System.Drawing.Size(150, 20);
            this.newStatusTextbox.TabIndex = 7;
            this.newStatusTextbox.Text = "Whats on your mind ?";
            this.newStatusTextbox.TextChanged += new System.EventHandler(this.newStatusTextbox_TextChanged);
            // 
            // postNewStatusLabel
            // 
            this.postNewStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postNewStatusLabel.AutoSize = true;
            this.postNewStatusLabel.Location = new System.Drawing.Point(7, 168);
            this.postNewStatusLabel.Name = "postNewStatusLabel";
            this.postNewStatusLabel.Size = new System.Drawing.Size(91, 13);
            this.postNewStatusLabel.TabIndex = 8;
            this.postNewStatusLabel.Text = "Post a new status";
            // 
            // postNewStatusButton
            // 
            this.postNewStatusButton.Location = new System.Drawing.Point(10, 210);
            this.postNewStatusButton.Name = "postNewStatusButton";
            this.postNewStatusButton.Size = new System.Drawing.Size(150, 25);
            this.postNewStatusButton.TabIndex = 9;
            this.postNewStatusButton.Text = "Post";
            this.postNewStatusButton.UseVisualStyleBackColor = true;
            this.postNewStatusButton.Click += new System.EventHandler(this.postNewStatusButton_Click);
            // 
            // createMemeButton
            // 
            this.createMemeButton.Location = new System.Drawing.Point(187, 210);
            this.createMemeButton.Name = "createMemeButton";
            this.createMemeButton.Size = new System.Drawing.Size(150, 25);
            this.createMemeButton.TabIndex = 10;
            this.createMemeButton.Text = "Create a Meme";
            this.createMemeButton.UseVisualStyleBackColor = true;
            this.createMemeButton.Click += new System.EventHandler(this.createMemeButton_Click);
            // 
            // ProfilePageTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createMemeButton);
            this.Controls.Add(this.postNewStatusButton);
            this.Controls.Add(this.postNewStatusLabel);
            this.Controls.Add(this.newStatusTextbox);
            this.Controls.Add(this.releationshipStatus);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.userBirthday);
            this.Controls.Add(this.userGender);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.profileImage);
            this.Name = "ProfilePageTab";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox profileImage;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userEmail;
        private System.Windows.Forms.Label userGender;
        private System.Windows.Forms.Label userBirthday;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label releationshipStatus;
        private System.Windows.Forms.TextBox newStatusTextbox;
        private System.Windows.Forms.Label postNewStatusLabel;
        private System.Windows.Forms.Button postNewStatusButton;
        private System.Windows.Forms.Button createMemeButton;
    }
}
