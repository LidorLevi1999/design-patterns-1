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
            this.myFriendsListBox.Location = new System.Drawing.Point(21, 61);
            this.myFriendsListBox.Name = "myFriendsListBox";
            this.myFriendsListBox.Size = new System.Drawing.Size(200, 147);
            this.myFriendsListBox.TabIndex = 0;
            this.myFriendsListBox.SelectedIndexChanged += new System.EventHandler(this.myFriendsListBox_SelectedIndexChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // fetchFriendsButton
            // 
            this.fetchFriendsButton.Location = new System.Drawing.Point(21, 23);
            this.fetchFriendsButton.Name = "fetchFriendsButton";
            this.fetchFriendsButton.Size = new System.Drawing.Size(200, 32);
            this.fetchFriendsButton.TabIndex = 1;
            this.fetchFriendsButton.Text = "Fetch Friends";
            this.fetchFriendsButton.UseVisualStyleBackColor = true;
            this.fetchFriendsButton.Click += new System.EventHandler(this.fetchFriendsButton_Click);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel.Location = new System.Drawing.Point(18, 325);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(100, 23);
            this.birthdayLabel.TabIndex = 4;
            this.birthdayLabel.Text = "bday";
            // 
            // emailLabel
            // 
            this.emailLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel.Location = new System.Drawing.Point(18, 348);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 23);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "email";
            // 
            // nameLabel
            // 
            this.nameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel.Location = new System.Drawing.Point(18, 302);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "name";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(21, 224);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(75, 75);
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
            this.albumsListBox.Location = new System.Drawing.Point(267, 61);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(200, 147);
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
            this.wallPostsListBox.Location = new System.Drawing.Point(267, 240);
            this.wallPostsListBox.Name = "wallPostsListBox";
            this.wallPostsListBox.Size = new System.Drawing.Size(200, 147);
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
            this.checkinsListBox.Location = new System.Drawing.Point(520, 240);
            this.checkinsListBox.Name = "checkinsListBox";
            this.checkinsListBox.Size = new System.Drawing.Size(200, 147);
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
            this.eventsListBox.Location = new System.Drawing.Point(520, 61);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(200, 147);
            this.eventsListBox.TabIndex = 15;
            this.eventsListBox.ValueMember = "AttendingCount";
            // 
            // albumsLabel
            // 
            this.albumsLabel.AutoSize = true;
            this.albumsLabel.Location = new System.Drawing.Point(264, 43);
            this.albumsLabel.Name = "albumsLabel";
            this.albumsLabel.Size = new System.Drawing.Size(48, 15);
            this.albumsLabel.TabIndex = 16;
            this.albumsLabel.Text = "Albums";
            // 
            // wallPostsLabel
            // 
            this.wallPostsLabel.AutoSize = true;
            this.wallPostsLabel.Location = new System.Drawing.Point(264, 224);
            this.wallPostsLabel.Name = "wallPostsLabel";
            this.wallPostsLabel.Size = new System.Drawing.Size(64, 15);
            this.wallPostsLabel.TabIndex = 17;
            this.wallPostsLabel.Text = "Wall Posts";
            // 
            // eventsLabel
            // 
            this.eventsLabel.AutoSize = true;
            this.eventsLabel.Location = new System.Drawing.Point(517, 43);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(43, 15);
            this.eventsLabel.TabIndex = 18;
            this.eventsLabel.Text = "Events";
            // 
            // checkInsLabel
            // 
            this.checkInsLabel.AutoSize = true;
            this.checkInsLabel.Location = new System.Drawing.Point(517, 224);
            this.checkInsLabel.Name = "checkInsLabel";
            this.checkInsLabel.Size = new System.Drawing.Size(57, 15);
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
            this.pageListBox.Location = new System.Drawing.Point(758, 61);
            this.pageListBox.Name = "pageListBox";
            this.pageListBox.Size = new System.Drawing.Size(200, 147);
            this.pageListBox.TabIndex = 19;
            this.pageListBox.ValueMember = "AccessToken";
            this.pageListBox.DoubleClick += new System.EventHandler(this.pageListBox_DoubleClick);
            // 
            // likedPageLabel
            // 
            this.likedPageLabel.AutoSize = true;
            this.likedPageLabel.Location = new System.Drawing.Point(755, 43);
            this.likedPageLabel.Name = "likedPageLabel";
            this.likedPageLabel.Size = new System.Drawing.Size(75, 15);
            this.likedPageLabel.TabIndex = 20;
            this.likedPageLabel.Text = "Liked Pages";
            // 
            // FriendsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Name = "FriendsTab";
            this.Size = new System.Drawing.Size(1266, 666);
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
