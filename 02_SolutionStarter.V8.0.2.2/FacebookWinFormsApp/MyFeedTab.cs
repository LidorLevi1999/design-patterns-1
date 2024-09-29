using BasicFacebookFeatures;
using FacebookWrapper;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.IO;

public partial class FeedTab : UserControl
{
    internal FacebookDataListbox LikedPageFacebookDataListbox;
    internal FacebookDataListbox PostsFacebookDataListBox;
    internal FacebookDataListbox FavouriteTeamsFacebookDataListbox;
    internal FacebookDataListbox AlbumsFacebookDataListbox;
    private DateTimePicker dateTimePickerPostsAfter;
    private DateTimePicker dateTimePickerPostsBefore;
    private Label labelPostsAfter;
    private Label labelPostsBefore;
    private Button logoutButton;
    private Button myMemesButton;
    private BindingSource m_BindingSource = new BindingSource();

    public FeedTab()
    {
        InitializeComponent();
        PostsFacebookDataListBox.IsPictureSupported = false;
        initializeDatePickersForPosts();
        initalizeFacebookDataListbox();
    }

    private void initalizeFacebookDataListbox()
    {
        this.AlbumsFacebookDataListbox.SetName("Albums");
        this.LikedPageFacebookDataListbox.SetName("Liked Pages");
        this.FavouriteTeamsFacebookDataListbox.SetName("Favourite Teams");
        this.PostsFacebookDataListBox.SetName("Posts");
    }
    private void initializeDatePickersForPosts()
    {
        this.dateTimePickerPostsAfter.MinDate = new DateTime(2008, 1, 1);
        this.dateTimePickerPostsAfter.MaxDate = DateTime.Today;
        this.dateTimePickerPostsAfter.Value = dateTimePickerPostsAfter.MinDate;

        this.dateTimePickerPostsBefore.MaxDate = DateTime.Today;
        this.dateTimePickerPostsBefore.MinDate = dateTimePickerPostsAfter.Value;
        this.dateTimePickerPostsBefore.Value = dateTimePickerPostsBefore.MaxDate;
        m_BindingSource = new BindingSource();
    }

    private void InitializeComponent()
    {
            this.logoutButton = new System.Windows.Forms.Button();
            this.dateTimePickerPostsAfter = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPostsBefore = new System.Windows.Forms.DateTimePicker();
            this.labelPostsAfter = new System.Windows.Forms.Label();
            this.labelPostsBefore = new System.Windows.Forms.Label();
            this.myMemesButton = new System.Windows.Forms.Button();
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
            // dateTimePickerPostsAfter
            // 
            this.dateTimePickerPostsAfter.Location = new System.Drawing.Point(665, 72);
            this.dateTimePickerPostsAfter.Name = "dateTimePickerPostsAfter";
            this.dateTimePickerPostsAfter.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPostsAfter.TabIndex = 5;
            this.dateTimePickerPostsAfter.ValueChanged += new System.EventHandler(this.dateTimePickerPostsAfter_ValueChanged);
            // 
            // dateTimePickerPostsBefore
            // 
            this.dateTimePickerPostsBefore.Location = new System.Drawing.Point(665, 117);
            this.dateTimePickerPostsBefore.Name = "dateTimePickerPostsBefore";
            this.dateTimePickerPostsBefore.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPostsBefore.TabIndex = 6;
            this.dateTimePickerPostsBefore.ValueChanged += new System.EventHandler(this.dateTimePickerPostsBefore_ValueChanged);
            // 
            // labelPostsAfter
            // 
            this.labelPostsAfter.AutoSize = true;
            this.labelPostsAfter.Location = new System.Drawing.Point(665, 53);
            this.labelPostsAfter.Name = "labelPostsAfter";
            this.labelPostsAfter.Size = new System.Drawing.Size(92, 13);
            this.labelPostsAfter.TabIndex = 7;
            this.labelPostsAfter.Text = "Get all posts after:";
            // 
            // labelPostsBefore
            // 
            this.labelPostsBefore.AutoSize = true;
            this.labelPostsBefore.Location = new System.Drawing.Point(665, 101);
            this.labelPostsBefore.Name = "labelPostsBefore";
            this.labelPostsBefore.Size = new System.Drawing.Size(101, 13);
            this.labelPostsBefore.TabIndex = 8;
            this.labelPostsBefore.Text = "Get all posts before:";
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
            // FavouriteTeamsFacebookDataListbox
            // 
            this.FavouriteTeamsFacebookDataListbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FavouriteTeamsFacebookDataListbox.Location = new System.Drawing.Point(0, 300);
            this.FavouriteTeamsFacebookDataListbox.Name = "FavouriteTeamsFacebookDataListbox";
            this.FavouriteTeamsFacebookDataListbox.Size = new System.Drawing.Size(328, 300);
            this.FavouriteTeamsFacebookDataListbox.TabIndex = 3;
            // 
            // PostsFacebookDataListBox
            // 
            this.PostsFacebookDataListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PostsFacebookDataListBox.Location = new System.Drawing.Point(358, 0);
            this.PostsFacebookDataListBox.Name = "PostsFacebookDataListBox";
            this.PostsFacebookDataListBox.Size = new System.Drawing.Size(328, 300);
            this.PostsFacebookDataListBox.TabIndex = 2;
            // 
            // LikedPageFacebookDataListbox
            // 
            this.LikedPageFacebookDataListbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LikedPageFacebookDataListbox.Location = new System.Drawing.Point(0, 0);
            this.LikedPageFacebookDataListbox.Name = "LikedPageFacebookDataListbox";
            this.LikedPageFacebookDataListbox.Size = new System.Drawing.Size(328, 300);
            this.LikedPageFacebookDataListbox.TabIndex = 1;
            // 
            // AlbumsFacebookDataListbox
            // 
            this.AlbumsFacebookDataListbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AlbumsFacebookDataListbox.Location = new System.Drawing.Point(358, 300);
            this.AlbumsFacebookDataListbox.Name = "AlbumsFacebookDataListbox";
            this.AlbumsFacebookDataListbox.Size = new System.Drawing.Size(328, 300);
            this.AlbumsFacebookDataListbox.TabIndex = 4;
            this.AlbumsFacebookDataListbox.DoubleClick += new System.EventHandler(this.AlbumsFacebookDataListbox_DoubleClick);
            // 
            // FeedTab
            // 
            this.AccessibleName = "feedTabPage";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.myMemesButton);
            this.Controls.Add(this.labelPostsBefore);
            this.Controls.Add(this.labelPostsAfter);
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
            this.Size = new System.Drawing.Size(1200, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

    }


    internal void loadDataToListboxes(User i_LoggedInUser)
    {
        this.LikedPageFacebookDataListbox.DisplayMemeber = "Name";
        this.FavouriteTeamsFacebookDataListbox.DisplayMemeber = "Name";
        this.PostsFacebookDataListBox.DisplayMemeber = "Message";

        this.LikedPageFacebookDataListbox.SetDataSource(i_LoggedInUser.LikedPages?.ToArray());
        this.FavouriteTeamsFacebookDataListbox.SetDataSource(i_LoggedInUser.FavofriteTeams?.ToArray());
        this.PostsFacebookDataListBox.SetDataSource(i_LoggedInUser.Posts?.ToArray());
        this.PostsFacebookDataListBox.IsPictureSupported = false;
        this.AlbumsFacebookDataListbox.SetDataSource(i_LoggedInUser.Albums.ToArray());
        this.AlbumsFacebookDataListbox.IsPictureSupported = false;

    }
    private void LikedPageFacebookDataListbox_DoubleClick(object sender, EventArgs e)
    {
        ListBox senderAsListBox = sender as ListBox;
        Page selectedItem = senderAsListBox.SelectedItem as Page;
        if (selectedItem != null)
        {
                showLikedPageDetails(selectedItem);
        }
    }

    private void showLikedPageDetails(Page i_Page)
    {
        LikedPageDetailsForm detailsForm = new LikedPageDetailsForm(i_Page);
        detailsForm.ShowDialog(); 
    }

    private void AlbumsFacebookDataListbox_DoubleClick(object sender, EventArgs e)
    {
        ListBox senderAsListBox = sender as ListBox;
        Album selectedItem = senderAsListBox.SelectedItem as Album;
        PicturesGallery picturesGallery = new PicturesGallery();
        List<string> imageUrls = new List<string>(); ;

        if (selectedItem != null)
        {
            try
            {
                foreach (var picture in selectedItem.Photos)
                {
                    imageUrls.Add(picture.PictureNormalURL);
                }

                picturesGallery.AddImages(imageUrls);
                picturesGallery.ShowDialog();
            }
            finally { }
        }
    }

    private void dateTimePickerPostsBefore_ValueChanged(object sender, EventArgs e)
    {
        dateTimePickerPostsAfter.MaxDate = dateTimePickerPostsBefore.Value;
        applyDateFilterToPostListBox();

    }

    private void dateTimePickerPostsAfter_ValueChanged(object sender, EventArgs e)
    {
        dateTimePickerPostsBefore.MinDate = dateTimePickerPostsAfter.Value;
        applyDateFilterToPostListBox();
    }

    private void applyDateFilterToPostListBox()
    {

        List<object> filteredPosts = new List<object>();

        foreach (var item in PostsFacebookDataListBox.m_DataSource?.ToArray() ?? new object[0])
        {
            Post post = item as Post;

            if (post != null && post.UpdateTime >= dateTimePickerPostsAfter.Value && post.UpdateTime <= dateTimePickerPostsBefore.Value)
            {
                filteredPosts.Add(item);
            }
        }

        m_BindingSource.DataSource = filteredPosts;
        PostsFacebookDataListBox.ListBox.DataSource = m_BindingSource;
        PostsFacebookDataListBox.ListBox.Refresh();
    }

    private void myMemesButton_Click(object sender, EventArgs e)
    {
        showAllUserMemes();
    }

    private void showAllUserMemes()
    {
        PicturesGallery picturesGallery = new PicturesGallery();
        List<string> imageUrls = new List<string>();
        string directoryOfMemesPath = Path.Combine(Application.StartupPath, MemeCreatorForm.m_MemesDiredtoryPath);

        if (Directory.Exists(directoryOfMemesPath))
        {
            string[] memeFiles = Directory.GetFiles(directoryOfMemesPath);

            foreach (var meme in memeFiles)
            {
                imageUrls.Add(meme);
            }

            picturesGallery.AddImages(imageUrls);
        }

        picturesGallery.Name = "Meme Gallery";
        picturesGallery.ShowDialog();
    }
}
