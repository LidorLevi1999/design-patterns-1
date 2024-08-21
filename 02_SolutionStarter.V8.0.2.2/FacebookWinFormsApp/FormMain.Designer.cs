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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.generalTabControl = new System.Windows.Forms.TabControl();
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.feedTabPage = new System.Windows.Forms.TabPage();
            this.likedPagesGroup = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.likedPagesLabel = new System.Windows.Forms.Label();
            this.likedPagesListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.postsGroup = new System.Windows.Forms.GroupBox();
            this.postsLabel = new System.Windows.Forms.Label();
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.favouriteTeamsGroup = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.favouriteTeamsLabel = new System.Windows.Forms.Label();
            this.favouriteTeamsListBox = new System.Windows.Forms.ListBox();
            this.calendarEnd = new System.Windows.Forms.MonthCalendar();
            this.calendarStart = new System.Windows.Forms.MonthCalendar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.userName = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.userBirthday = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.Label();
            this.userGender = new System.Windows.Forms.Label();
            this.userLocation = new System.Windows.Forms.Label();
            this.logoutTabPage = new System.Windows.Forms.TabPage();
            this.generalTabControl.SuspendLayout();
            this.loginTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.feedTabPage.SuspendLayout();
            this.likedPagesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.postsGroup.SuspendLayout();
            this.favouriteTeamsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.profileTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.Location = new System.Drawing.Point(477, 75);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(101, 48);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
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
            // loginTabPage
            // 
            this.loginTabPage.AccessibleName = "loginTabPage";
            this.loginTabPage.Controls.Add(this.rememberMeCheckBox);
            this.loginTabPage.Controls.Add(this.pictureBoxProfile);
            this.loginTabPage.Controls.Add(this.buttonLogin);
            this.loginTabPage.Location = new System.Drawing.Point(8, 51);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(2320, 1104);
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
            this.rememberMeCheckBox.Size = new System.Drawing.Size(246, 42);
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
            // 
            // feedTabPage
            // 
            this.feedTabPage.AccessibleName = "feedTabPage";
            this.feedTabPage.Controls.Add(this.likedPagesGroup);
            this.feedTabPage.Controls.Add(this.groupBox4);
            this.feedTabPage.Controls.Add(this.postsGroup);
            this.feedTabPage.Controls.Add(this.favouriteTeamsGroup);
            this.feedTabPage.Controls.Add(this.calendarEnd);
            this.feedTabPage.Controls.Add(this.calendarStart);
            this.feedTabPage.Controls.Add(this.pictureBox2);
            this.feedTabPage.Controls.Add(this.pictureBox1);
            this.feedTabPage.Location = new System.Drawing.Point(8, 51);
            this.feedTabPage.Name = "feedTabPage";
            this.feedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.feedTabPage.Size = new System.Drawing.Size(2320, 1104);
            this.feedTabPage.TabIndex = 1;
            this.feedTabPage.Text = "My Feed";
            this.feedTabPage.UseVisualStyleBackColor = true;
            // 
            // likedPagesGroup
            // 
            this.likedPagesGroup.AccessibleName = "likedPagesGroup";
            this.likedPagesGroup.Controls.Add(this.pictureBox3);
            this.likedPagesGroup.Controls.Add(this.likedPagesLabel);
            this.likedPagesGroup.Controls.Add(this.likedPagesListBox);
            this.likedPagesGroup.Location = new System.Drawing.Point(53, 28);
            this.likedPagesGroup.Name = "likedPagesGroup";
            this.likedPagesGroup.Size = new System.Drawing.Size(408, 339);
            this.likedPagesGroup.TabIndex = 72;
            this.likedPagesGroup.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(267, 245);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 63);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // likedPagesLabel
            // 
            this.likedPagesLabel.AccessibleName = "LikedPages";
            this.likedPagesLabel.AutoSize = true;
            this.likedPagesLabel.Location = new System.Drawing.Point(21, 41);
            this.likedPagesLabel.Name = "likedPagesLabel";
            this.likedPagesLabel.Size = new System.Drawing.Size(174, 38);
            this.likedPagesLabel.TabIndex = 1;
            this.likedPagesLabel.Text = "Liked Pages";
            this.likedPagesLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // likedPagesListBox
            // 
            this.likedPagesListBox.FormattingEnabled = true;
            this.likedPagesListBox.ItemHeight = 37;
            this.likedPagesListBox.Location = new System.Drawing.Point(28, 82);
            this.likedPagesListBox.Name = "likedPagesListBox";
            this.likedPagesListBox.Size = new System.Drawing.Size(308, 226);
            this.likedPagesListBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.listBox7);
            this.groupBox4.Location = new System.Drawing.Point(483, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 339);
            this.groupBox4.TabIndex = 74;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 38);
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
            // postsGroup
            // 
            this.postsGroup.AccessibleName = "postsGroup";
            this.postsGroup.Controls.Add(this.postsLabel);
            this.postsGroup.Controls.Add(this.postsListBox);
            this.postsGroup.Location = new System.Drawing.Point(455, 28);
            this.postsGroup.Name = "postsGroup";
            this.postsGroup.Size = new System.Drawing.Size(408, 339);
            this.postsGroup.TabIndex = 71;
            this.postsGroup.TabStop = false;
            this.postsGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // postsLabel
            // 
            this.postsLabel.AccessibleName = "postsLabel";
            this.postsLabel.AutoSize = true;
            this.postsLabel.Location = new System.Drawing.Point(21, 41);
            this.postsLabel.Name = "postsLabel";
            this.postsLabel.Size = new System.Drawing.Size(88, 38);
            this.postsLabel.TabIndex = 1;
            this.postsLabel.Text = "Posts";
            this.postsLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // postsListBox
            // 
            this.postsListBox.AccessibleName = "postsListBox";
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.ItemHeight = 37;
            this.postsListBox.Location = new System.Drawing.Point(28, 86);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(308, 226);
            this.postsListBox.TabIndex = 0;
            // 
            // favouriteTeamsGroup
            // 
            this.favouriteTeamsGroup.Controls.Add(this.pictureBox4);
            this.favouriteTeamsGroup.Controls.Add(this.favouriteTeamsLabel);
            this.favouriteTeamsGroup.Controls.Add(this.favouriteTeamsListBox);
            this.favouriteTeamsGroup.Location = new System.Drawing.Point(53, 380);
            this.favouriteTeamsGroup.Name = "favouriteTeamsGroup";
            this.favouriteTeamsGroup.Size = new System.Drawing.Size(408, 339);
            this.favouriteTeamsGroup.TabIndex = 73;
            this.favouriteTeamsGroup.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(267, 245);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 63);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // favouriteTeamsLabel
            // 
            this.favouriteTeamsLabel.AccessibleName = "favouriteTeamsLabel";
            this.favouriteTeamsLabel.AutoSize = true;
            this.favouriteTeamsLabel.Location = new System.Drawing.Point(21, 41);
            this.favouriteTeamsLabel.Name = "favouriteTeamsLabel";
            this.favouriteTeamsLabel.Size = new System.Drawing.Size(240, 38);
            this.favouriteTeamsLabel.TabIndex = 1;
            this.favouriteTeamsLabel.Text = "Favourite Teams:";
            // 
            // favouriteTeamsListBox
            // 
            this.favouriteTeamsListBox.AccessibleName = "favouriteTeamsListBox";
            this.favouriteTeamsListBox.FormattingEnabled = true;
            this.favouriteTeamsListBox.ItemHeight = 37;
            this.favouriteTeamsListBox.Location = new System.Drawing.Point(28, 82);
            this.favouriteTeamsListBox.Name = "favouriteTeamsListBox";
            this.favouriteTeamsListBox.Size = new System.Drawing.Size(308, 226);
            this.favouriteTeamsListBox.TabIndex = 0;
            // 
            // calendarEnd
            // 
            this.calendarEnd.Location = new System.Drawing.Point(1611, 79);
            this.calendarEnd.Name = "calendarEnd";
            this.calendarEnd.TabIndex = 70;
            this.calendarEnd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarEnd_DateChanged);
            // 
            // calendarStart
            // 
            this.calendarStart.Location = new System.Drawing.Point(1175, 79);
            this.calendarStart.Name = "calendarStart";
            this.calendarStart.TabIndex = 69;
            this.calendarStart.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarStart_DateChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1161, 655);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(940, 655);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // profileTabPage
            // 
            this.profileTabPage.AccessibleName = "profileTabPage";
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
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(229, 45);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(96, 38);
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
            this.userBirthday.Size = new System.Drawing.Size(182, 38);
            this.userBirthday.TabIndex = 57;
            this.userBirthday.Text = "userBirthday";
            this.userBirthday.Click += new System.EventHandler(this.label1_Click);
            // 
            // userEmail
            // 
            this.userEmail.AutoSize = true;
            this.userEmail.Location = new System.Drawing.Point(33, 255);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(143, 38);
            this.userEmail.TabIndex = 58;
            this.userEmail.Text = "userEmail";
            this.userEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // userGender
            // 
            this.userGender.AutoSize = true;
            this.userGender.Location = new System.Drawing.Point(33, 296);
            this.userGender.Name = "userGender";
            this.userGender.Size = new System.Drawing.Size(171, 38);
            this.userGender.TabIndex = 59;
            this.userGender.Text = "userGender";
            // 
            // userLocation
            // 
            this.userLocation.AutoSize = true;
            this.userLocation.Location = new System.Drawing.Point(33, 343);
            this.userLocation.Name = "userLocation";
            this.userLocation.Size = new System.Drawing.Size(186, 38);
            this.userLocation.TabIndex = 60;
            this.userLocation.Text = "userLocation";
            // 
            // logoutTabPage
            // 
            this.logoutTabPage.AccessibleName = "logoutTabPage";
            this.logoutTabPage.Location = new System.Drawing.Point(8, 51);
            this.logoutTabPage.Name = "logoutTabPage";
            this.logoutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.logoutTabPage.Size = new System.Drawing.Size(2320, 1104);
            this.logoutTabPage.TabIndex = 3;
            this.logoutTabPage.Text = "Logout";
            this.logoutTabPage.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2336, 1163);
            this.Controls.Add(this.generalTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.generalTabControl.ResumeLayout(false);
            this.loginTabPage.ResumeLayout(false);
            this.loginTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.feedTabPage.ResumeLayout(false);
            this.likedPagesGroup.ResumeLayout(false);
            this.likedPagesGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.postsGroup.ResumeLayout(false);
            this.postsGroup.PerformLayout();
            this.favouriteTeamsGroup.ResumeLayout(false);
            this.favouriteTeamsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.profileTabPage.ResumeLayout(false);
            this.profileTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
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

        private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabControl generalTabControl;
		private System.Windows.Forms.TabPage loginTabPage;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.Label userBirthday;
        private System.Windows.Forms.Label userLocation;
        private System.Windows.Forms.Label userGender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MonthCalendar calendarEnd;
        private System.Windows.Forms.MonthCalendar calendarStart;
        private System.Windows.Forms.GroupBox postsGroup;
        private System.Windows.Forms.Label postsLabel;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.GroupBox favouriteTeamsGroup;
        private System.Windows.Forms.Label favouriteTeamsLabel;
        private System.Windows.Forms.ListBox favouriteTeamsListBox;
        private System.Windows.Forms.GroupBox likedPagesGroup;
        private System.Windows.Forms.Label likedPagesLabel;
        private System.Windows.Forms.ListBox likedPagesListBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label userEmail;
        private System.Windows.Forms.TabPage feedTabPage;
        private System.Windows.Forms.TabPage profileTabPage;
        private System.Windows.Forms.TabPage logoutTabPage;
    }
}

