using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FeedTab
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.myMemesButton = new System.Windows.Forms.Button();
            this.dateTimePickerPostsAfter = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPostsBefore = new System.Windows.Forms.DateTimePicker();
            this.labelPostsAfter = new System.Windows.Forms.Label();
            this.labelPostsBefore = new System.Windows.Forms.Label();
            this.FavouriteTeamsFacebookDataListbox = new BasicFacebookFeatures.FacebookDataListbox();
            this.PostsFacebookDataListBox = new BasicFacebookFeatures.FacebookDataListbox();
            this.LikedPageFacebookDataListbox = new BasicFacebookFeatures.FacebookDataListbox();
            this.AlbumsFacebookDataListbox = new BasicFacebookFeatures.FacebookDataListbox();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1913, 0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 0;
            // 
            // myMemesButton
            // 
            this.myMemesButton.Location = new System.Drawing.Point(665, 186);
            this.myMemesButton.Name = "myMemesButton";
            this.myMemesButton.Size = new System.Drawing.Size(200, 23);
            this.myMemesButton.TabIndex = 9;
            this.myMemesButton.Text = "Show My Memes";
            this.myMemesButton.UseVisualStyleBackColor = true;
            this.myMemesButton.Click += new System.EventHandler(this.myMemesButton_Click);
            // 
            // dateTimePickerPostsAfter
            // 
            this.dateTimePickerPostsAfter.Location = new System.Drawing.Point(665, 72);
            this.dateTimePickerPostsAfter.Name = "dateTimePickerPostsAfter";
            this.dateTimePickerPostsAfter.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerPostsAfter.TabIndex = 5;
            this.dateTimePickerPostsAfter.ValueChanged += new System.EventHandler(this.dateTimePickerPostsAfter_ValueChanged);
            // 
            // dateTimePickerPostsBefore
            // 
            this.dateTimePickerPostsBefore.Location = new System.Drawing.Point(665, 117);
            this.dateTimePickerPostsBefore.Name = "dateTimePickerPostsBefore";
            this.dateTimePickerPostsBefore.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerPostsBefore.TabIndex = 6;
            this.dateTimePickerPostsBefore.ValueChanged += new System.EventHandler(this.dateTimePickerPostsBefore_ValueChanged);
            // 
            // labelPostsAfter
            // 
            this.labelPostsAfter.AutoSize = true;
            this.labelPostsAfter.Location = new System.Drawing.Point(665, 53);
            this.labelPostsAfter.Name = "labelPostsAfter";
            this.labelPostsAfter.Size = new System.Drawing.Size(187, 25);
            this.labelPostsAfter.TabIndex = 7;
            this.labelPostsAfter.Text = "Get all posts after:";
            // 
            // labelPostsBefore
            // 
            this.labelPostsBefore.AutoSize = true;
            this.labelPostsBefore.Location = new System.Drawing.Point(665, 101);
            this.labelPostsBefore.Name = "labelPostsBefore";
            this.labelPostsBefore.Size = new System.Drawing.Size(205, 25);
            this.labelPostsBefore.TabIndex = 8;
            this.labelPostsBefore.Text = "Get all posts before:";
            // 
            // FavouriteTeamsFacebookDataListbox
            // 
            this.FavouriteTeamsFacebookDataListbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FavouriteTeamsFacebookDataListbox.DisplayMember = "";
            this.FavouriteTeamsFacebookDataListbox.Location = new System.Drawing.Point(0, 300);
            this.FavouriteTeamsFacebookDataListbox.Name = "FavouriteTeamsFacebookDataListbox";
            this.FavouriteTeamsFacebookDataListbox.Size = new System.Drawing.Size(328, 300);
            this.FavouriteTeamsFacebookDataListbox.TabIndex = 3;
            // 
            // PostsFacebookDataListBox
            // 
            this.PostsFacebookDataListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PostsFacebookDataListBox.DisplayMember = "";
            this.PostsFacebookDataListBox.Location = new System.Drawing.Point(358, 0);
            this.PostsFacebookDataListBox.Name = "PostsFacebookDataListBox";
            this.PostsFacebookDataListBox.Size = new System.Drawing.Size(328, 300);
            this.PostsFacebookDataListBox.TabIndex = 2;
            // 
            // LikedPageFacebookDataListbox
            // 
            this.LikedPageFacebookDataListbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LikedPageFacebookDataListbox.DisplayMember = "";
            this.LikedPageFacebookDataListbox.Location = new System.Drawing.Point(0, 0);
            this.LikedPageFacebookDataListbox.Name = "LikedPageFacebookDataListbox";
            this.LikedPageFacebookDataListbox.Size = new System.Drawing.Size(328, 300);
            this.LikedPageFacebookDataListbox.TabIndex = 1;
            this.LikedPageFacebookDataListbox.ListBox.DoubleClick += new System.EventHandler(this.LikedPageFacebookDataListbox_DoubleClick);
            // 
            // AlbumsFacebookDataListbox
            // 
            this.AlbumsFacebookDataListbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AlbumsFacebookDataListbox.DisplayMember = "";
            this.AlbumsFacebookDataListbox.Location = new System.Drawing.Point(358, 300);
            this.AlbumsFacebookDataListbox.Name = "AlbumsFacebookDataListbox";
            this.AlbumsFacebookDataListbox.Size = new System.Drawing.Size(328, 300);
            this.AlbumsFacebookDataListbox.TabIndex = 4;
            this.AlbumsFacebookDataListbox.ListBox.DoubleClick += new System.EventHandler(this.AlbumsFacebookDataListbox_DoubleClick);
            // 
            // FeedTab
            // 
            this.AccessibleName = "feedTabPage";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.labelPostsBefore);
            this.Controls.Add(this.labelPostsAfter);
            this.Controls.Add(this.myMemesButton);
            this.Controls.Add(this.dateTimePickerPostsBefore);
            this.Controls.Add(this.dateTimePickerPostsAfter);
            this.Controls.Add(this.FavouriteTeamsFacebookDataListbox);
            this.Controls.Add(this.PostsFacebookDataListBox);
            this.Controls.Add(this.LikedPageFacebookDataListbox);
            this.Controls.Add(this.AlbumsFacebookDataListbox);
            this.Controls.Add(this.logoutButton);
            this.Location = new System.Drawing.Point(8, 51);
            this.Name = "FeedTab";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(1100, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal FacebookDataListbox LikedPageFacebookDataListbox;
        internal FacebookDataListbox PostsFacebookDataListBox;
        internal FacebookDataListbox FavouriteTeamsFacebookDataListbox;
        internal FacebookDataListbox AlbumsFacebookDataListbox;
        internal DateTimePicker dateTimePickerPostsAfter;
        internal DateTimePicker dateTimePickerPostsBefore;
        private Label labelPostsAfter;
        private Label labelPostsBefore;
        private Button logoutButton;
        private BindingSource m_BindingSource = new BindingSource();
        private Button myMemesButton;
    }
}
