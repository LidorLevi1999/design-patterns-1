namespace BasicFacebookFeatures
{
    partial class FriendsTab
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
            this.myFriendsListBox = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fetchFriendsButton = new System.Windows.Forms.Button();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsListBox = new System.Windows.Forms.ListBox();
            this.wallPostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wallPostsListBox = new System.Windows.Forms.ListBox();
            this.checkinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkinsListBox = new System.Windows.Forms.ListBox();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.albumsLabel = new System.Windows.Forms.Label();
            this.wallPostsLabel = new System.Windows.Forms.Label();
            this.eventsLabel = new System.Windows.Forms.Label();
            this.checkInsLabel = new System.Windows.Forms.Label();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageListBox = new System.Windows.Forms.ListBox();
            this.likedPageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myFriendsListBox
            // 
            this.myFriendsListBox.DataSource = this.userBindingSource;
            this.myFriendsListBox.FormattingEnabled = true;
            this.myFriendsListBox.ItemHeight = 16;
            this.myFriendsListBox.Location = new System.Drawing.Point(28, 75);
            this.myFriendsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myFriendsListBox.Name = "myFriendsListBox";
            this.myFriendsListBox.Size = new System.Drawing.Size(265, 180);
            this.myFriendsListBox.TabIndex = 0;
            this.myFriendsListBox.SelectedIndexChanged += new System.EventHandler(this.myFriendsListBox_SelectedIndexChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // fetchFriendsButton
            // 
            this.fetchFriendsButton.Location = new System.Drawing.Point(28, 28);
            this.fetchFriendsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fetchFriendsButton.Name = "fetchFriendsButton";
            this.fetchFriendsButton.Size = new System.Drawing.Size(267, 39);
            this.fetchFriendsButton.TabIndex = 1;
            this.fetchFriendsButton.Text = "Fetch Friends";
            this.fetchFriendsButton.UseVisualStyleBackColor = true;
            this.fetchFriendsButton.Click += new System.EventHandler(this.fetchFriendsButton_Click);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel.Location = new System.Drawing.Point(24, 400);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(133, 28);
            this.birthdayLabel.TabIndex = 4;
            this.birthdayLabel.Text = "Birthday";
            // 
            // emailLabel
            // 
            this.emailLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel.Location = new System.Drawing.Point(24, 428);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(133, 28);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel.Location = new System.Drawing.Point(24, 372);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(133, 28);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(28, 276);
            this.imageNormalPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 92);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 15;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.userBindingSource;
            // 
            // albumsListBox
            // 
            this.albumsListBox.DataSource = this.albumsBindingSource;
            this.albumsListBox.DisplayMember = "Name";
            this.albumsListBox.FormattingEnabled = true;
            this.albumsListBox.ItemHeight = 16;
            this.albumsListBox.Location = new System.Drawing.Point(356, 75);
            this.albumsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(265, 180);
            this.albumsListBox.TabIndex = 15;
            this.albumsListBox.ValueMember = "Comments";
            this.albumsListBox.DoubleClick += new System.EventHandler(this.albumsListBox_DoubleClick);
            // 
            // wallPostsBindingSource
            // 
            this.wallPostsBindingSource.DataMember = "WallPosts";
            this.wallPostsBindingSource.DataSource = this.userBindingSource;
            // 
            // wallPostsListBox
            // 
            this.wallPostsListBox.DataSource = this.wallPostsBindingSource;
            this.wallPostsListBox.DisplayMember = "Message";
            this.wallPostsListBox.FormattingEnabled = true;
            this.wallPostsListBox.ItemHeight = 16;
            this.wallPostsListBox.Location = new System.Drawing.Point(356, 295);
            this.wallPostsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wallPostsListBox.Name = "wallPostsListBox";
            this.wallPostsListBox.Size = new System.Drawing.Size(265, 180);
            this.wallPostsListBox.TabIndex = 15;
            this.wallPostsListBox.ValueMember = "Caption";
            // 
            // checkinsBindingSource
            // 
            this.checkinsBindingSource.DataMember = "Checkins";
            this.checkinsBindingSource.DataSource = this.userBindingSource;
            // 
            // checkinsListBox
            // 
            this.checkinsListBox.DataSource = this.checkinsBindingSource;
            this.checkinsListBox.DisplayMember = "Place.Name";
            this.checkinsListBox.FormattingEnabled = true;
            this.checkinsListBox.ItemHeight = 16;
            this.checkinsListBox.Location = new System.Drawing.Point(693, 295);
            this.checkinsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkinsListBox.Name = "checkinsListBox";
            this.checkinsListBox.Size = new System.Drawing.Size(265, 180);
            this.checkinsListBox.TabIndex = 15;
            this.checkinsListBox.ValueMember = "Caption";
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.userBindingSource;
            // 
            // eventsListBox
            // 
            this.eventsListBox.DataSource = this.eventsBindingSource;
            this.eventsListBox.DisplayMember = "Name";
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 16;
            this.eventsListBox.Location = new System.Drawing.Point(693, 75);
            this.eventsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(265, 180);
            this.eventsListBox.TabIndex = 15;
            this.eventsListBox.ValueMember = "AttendingCount";
            // 
            // albumsLabel
            // 
            this.albumsLabel.AutoSize = true;
            this.albumsLabel.Location = new System.Drawing.Point(352, 53);
            this.albumsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.albumsLabel.Name = "albumsLabel";
            this.albumsLabel.Size = new System.Drawing.Size(52, 16);
            this.albumsLabel.TabIndex = 16;
            this.albumsLabel.Text = "Albums";
            // 
            // wallPostsLabel
            // 
            this.wallPostsLabel.AutoSize = true;
            this.wallPostsLabel.Location = new System.Drawing.Point(352, 276);
            this.wallPostsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wallPostsLabel.Name = "wallPostsLabel";
            this.wallPostsLabel.Size = new System.Drawing.Size(71, 16);
            this.wallPostsLabel.TabIndex = 17;
            this.wallPostsLabel.Text = "Wall Posts";
            // 
            // eventsLabel
            // 
            this.eventsLabel.AutoSize = true;
            this.eventsLabel.Location = new System.Drawing.Point(689, 53);
            this.eventsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(48, 16);
            this.eventsLabel.TabIndex = 18;
            this.eventsLabel.Text = "Events";
            // 
            // checkInsLabel
            // 
            this.checkInsLabel.AutoSize = true;
            this.checkInsLabel.Location = new System.Drawing.Point(689, 276);
            this.checkInsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkInsLabel.Name = "checkInsLabel";
            this.checkInsLabel.Size = new System.Drawing.Size(62, 16);
            this.checkInsLabel.TabIndex = 19;
            this.checkInsLabel.Text = "Checkins";
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // pageListBox
            // 
            this.pageListBox.DataSource = this.pageBindingSource;
            this.pageListBox.DisplayMember = "Name";
            this.pageListBox.FormattingEnabled = true;
            this.pageListBox.ItemHeight = 16;
            this.pageListBox.Location = new System.Drawing.Point(1011, 75);
            this.pageListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pageListBox.Name = "pageListBox";
            this.pageListBox.Size = new System.Drawing.Size(265, 180);
            this.pageListBox.TabIndex = 19;
            this.pageListBox.ValueMember = "AccessToken";
            this.pageListBox.DoubleClick += new System.EventHandler(this.pageListBox_DoubleClick);
            // 
            // likedPageLabel
            // 
            this.likedPageLabel.AutoSize = true;
            this.likedPageLabel.Location = new System.Drawing.Point(1007, 53);
            this.likedPageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.likedPageLabel.Name = "likedPageLabel";
            this.likedPageLabel.Size = new System.Drawing.Size(83, 16);
            this.likedPageLabel.TabIndex = 20;
            this.likedPageLabel.Text = "Liked Pages";
            // 
            // FriendsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.likedPageLabel);
            this.Controls.Add(this.pageListBox);
            this.Controls.Add(this.checkInsLabel);
            this.Controls.Add(this.eventsLabel);
            this.Controls.Add(this.wallPostsLabel);
            this.Controls.Add(this.albumsLabel);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.checkinsListBox);
            this.Controls.Add(this.wallPostsListBox);
            this.Controls.Add(this.albumsListBox);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.fetchFriendsButton);
            this.Controls.Add(this.myFriendsListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FriendsTab";
            this.Size = new System.Drawing.Size(1688, 820);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox myFriendsListBox;
        private System.Windows.Forms.Button fetchFriendsButton;
        internal System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.ListBox albumsListBox;
        private System.Windows.Forms.BindingSource wallPostsBindingSource;
        private System.Windows.Forms.ListBox wallPostsListBox;
        private System.Windows.Forms.BindingSource checkinsBindingSource;
        private System.Windows.Forms.ListBox checkinsListBox;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.Label albumsLabel;
        private System.Windows.Forms.Label wallPostsLabel;
        private System.Windows.Forms.Label eventsLabel;
        private System.Windows.Forms.Label checkInsLabel;
        internal System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.ListBox pageListBox;
        private System.Windows.Forms.Label likedPageLabel;
    }
}
