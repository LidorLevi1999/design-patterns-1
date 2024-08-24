using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.userBirthday = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.Label();
            this.userGender = new System.Windows.Forms.Label();
            this.userLocation = new System.Windows.Forms.Label();
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.generalTabControl = new System.Windows.Forms.TabControl();
            this.profileTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.loginTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.generalTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(273, 91);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(168, 52);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "label11";
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 37;
            this.listBox7.Location = new System.Drawing.Point(28, 82);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(308, 226);
            this.listBox7.TabIndex = 0;
            // 
            // profileTabPage
            // 
            this.profileTabPage.AccessibleName = "profileTabPage";
            this.profileTabPage.Controls.Add(this.button2);
            this.profileTabPage.Controls.Add(this.userName);
            this.profileTabPage.Controls.Add(this.profilePictureBox);
            this.profileTabPage.Controls.Add(this.userBirthday);
            this.profileTabPage.Controls.Add(this.userEmail);
            this.profileTabPage.Controls.Add(this.userGender);
            this.profileTabPage.Controls.Add(this.userLocation);
            this.profileTabPage.Location = new System.Drawing.Point(8, 51);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(2320, 1104);
            this.profileTabPage.TabIndex = 2;
            this.profileTabPage.Text = "My Profile";
            this.profileTabPage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AccessibleName = "logoutButton";
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(2196, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 49);
            this.button2.TabIndex = 63;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(229, 45);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(41, 15);
            this.userName.TabIndex = 62;
            this.userName.Text = "Name";
            this.userName.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(20, 19);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(183, 170);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 61;
            this.profilePictureBox.TabStop = false;
            // 
            // userBirthday
            // 
            this.userBirthday.AutoSize = true;
            this.userBirthday.Location = new System.Drawing.Point(33, 215);
            this.userBirthday.Name = "userBirthday";
            this.userBirthday.Size = new System.Drawing.Size(75, 15);
            this.userBirthday.TabIndex = 57;
            this.userBirthday.Text = "userBirthday";
            // 
            // userEmail
            // 
            this.userEmail.AutoSize = true;
            this.userEmail.Location = new System.Drawing.Point(33, 255);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(63, 15);
            this.userEmail.TabIndex = 58;
            this.userEmail.Text = "userEmail";
            // 
            // userGender
            // 
            this.userGender.AutoSize = true;
            this.userGender.Location = new System.Drawing.Point(33, 296);
            this.userGender.Name = "userGender";
            this.userGender.Size = new System.Drawing.Size(72, 15);
            this.userGender.TabIndex = 59;
            this.userGender.Text = "userGender";
            // 
            // userLocation
            // 
            this.userLocation.AutoSize = true;
            this.userLocation.Location = new System.Drawing.Point(33, 343);
            this.userLocation.Name = "userLocation";
            this.userLocation.Size = new System.Drawing.Size(78, 15);
            this.userLocation.TabIndex = 60;
            this.userLocation.Text = "userLocation";
            // 
            // loginTabPage
            // 
            this.loginTabPage.AccessibleName = "loginTabPage";
            this.loginTabPage.Controls.Add(this.rememberMeCheckBox);
            this.loginTabPage.Controls.Add(this.pictureBoxProfile);
            this.loginTabPage.Controls.Add(this.buttonLogin);
            this.loginTabPage.Location = new System.Drawing.Point(10, 64);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(2316, 1089);
            this.loginTabPage.TabIndex = 0;
            this.loginTabPage.Text = "Login";
            this.loginTabPage.UseVisualStyleBackColor = true;
            this.loginTabPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Enabled = false;
            this.rememberMeCheckBox.Location = new System.Drawing.Point(646, 70);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(298, 51);
            this.rememberMeCheckBox.TabIndex = 56;
            this.rememberMeCheckBox.Text = "Remember Me";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            this.rememberMeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 96);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.Location = new System.Drawing.Point(477, 75);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(121, 57);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // generalTabControl
            // 
            this.generalTabControl.AccessibleName = "generalTabControl";
            this.generalTabControl.Controls.Add(this.loginTabPage);
            this.generalTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTabControl.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalTabControl.Location = new System.Drawing.Point(0, 0);
            this.generalTabControl.Name = "generalTabControl";
            this.generalTabControl.SelectedIndex = 0;
            this.generalTabControl.Size = new System.Drawing.Size(2336, 1163);
            this.generalTabControl.TabIndex = 54;
            this.generalTabControl.SelectedIndexChanged += new System.EventHandler(this.generalTabControl_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2336, 1163);
            this.Controls.Add(this.generalTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.profileTabPage.ResumeLayout(false);
            this.profileTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.loginTabPage.ResumeLayout(false);
            this.loginTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.generalTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void HideTab(TabPage tabPage)
        {
            if (generalTabControl.TabPages.Contains(tabPage))
            {
                generalTabControl.TabPages.Remove(tabPage);
            }
        }

        private void ShowTab(TabPage tabPage)
        {
            if (!generalTabControl.TabPages.Contains(tabPage))
            {
                generalTabControl.TabPages.Add(tabPage);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        #endregion
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label userBirthday;
        private System.Windows.Forms.Label userLocation;
        private System.Windows.Forms.Label userGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label userEmail;
        private System.Windows.Forms.TabPage profileTabPage;
        private Button button2;
        private TabPage loginTabPage;
        private TabPage feedTabPage;
        private CheckBox rememberMeCheckBox;
        private PictureBox pictureBoxProfile;
        private Button buttonLogin;
        private TabControl generalTabControl;
    }
}

