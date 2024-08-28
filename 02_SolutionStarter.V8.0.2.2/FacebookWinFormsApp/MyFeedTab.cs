using BasicFacebookFeatures;
using FacebookWrapper;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

public partial class FeedTab : UserControl, IFacebookTab
{
    internal FacebookDataListbox LikedPageFacebookDataListbox;
    internal FacebookDataListbox PostsFacebookDataListBox;
    internal FacebookDataListbox FavouriteTeamsFacebookDataListbox;
    internal FacebookDataListbox AlbumsFacebookDataListbox;

    private Button logoutButton;

    public FeedTab()
    {
        InitializeComponent();
        PostsFacebookDataListBox.IsPictureSupported = false;

    }

    public void loadData(LoginResult i_LoginResult)
    {

    }

    public void hideData()
    {
        
    }

    private void InitializeComponent()
    {
            this.logoutButton = new System.Windows.Forms.Button();
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
            // FavouriteTeamsFacebookDataListbox
            // 
            this.FavouriteTeamsFacebookDataListbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FavouriteTeamsFacebookDataListbox.Location = new System.Drawing.Point(0, 300);
            this.FavouriteTeamsFacebookDataListbox.Name = "FavouriteTeamsFacebookDataListbox";
            this.FavouriteTeamsFacebookDataListbox.setName("Favourite Teams");
            this.FavouriteTeamsFacebookDataListbox.Size = new System.Drawing.Size(328, 300);
            this.FavouriteTeamsFacebookDataListbox.TabIndex = 3;
            this.FavouriteTeamsFacebookDataListbox.Load += new System.EventHandler(this.FavouriteTeamsFacebookDataListbox_Load);
            // 
            // PostsFacebookDataListBox
            // 
            this.PostsFacebookDataListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PostsFacebookDataListBox.Location = new System.Drawing.Point(358, 0);
            this.PostsFacebookDataListBox.Name = "PostsFacebookDataListBox";
            this.PostsFacebookDataListBox.setName("My Posts");
            this.PostsFacebookDataListBox.Size = new System.Drawing.Size(328, 300);
            this.PostsFacebookDataListBox.TabIndex = 2;
            this.PostsFacebookDataListBox.Load += new System.EventHandler(this.PostsFacebookDataListBox_Load);
            // 
            // LikedPageFacebookDataListbox
            // 
            this.LikedPageFacebookDataListbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LikedPageFacebookDataListbox.Location = new System.Drawing.Point(0, 0);
            this.LikedPageFacebookDataListbox.Name = "LikedPageFacebookDataListbox";
            this.LikedPageFacebookDataListbox.setName("Liked Pages");
            this.LikedPageFacebookDataListbox.Size = new System.Drawing.Size(328, 300);
            this.LikedPageFacebookDataListbox.TabIndex = 1;
            this.LikedPageFacebookDataListbox.Load += new System.EventHandler(this.LikedPageFacebookDataListbox_Load_1);
            this.LikedPageFacebookDataListbox.ListBox.DoubleClick += new System.EventHandler(this.LikedPageFacebookDataListbox_DoubleClick);

            // 
            // AlbumsFacebookDataListBox
            // 
            this.AlbumsFacebookDataListbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AlbumsFacebookDataListbox.Location = new System.Drawing.Point(358, 300);
            this.AlbumsFacebookDataListbox.Name = "AlbumsFacebookDataListbox";
            this.AlbumsFacebookDataListbox.setName("My Albums");
            this.AlbumsFacebookDataListbox.Size = new System.Drawing.Size(328, 300);
            this.AlbumsFacebookDataListbox.TabIndex = 4;
            this.AlbumsFacebookDataListbox.Load += new System.EventHandler(this.AlbumsFacebookDataListbox_Load);
            this.AlbumsFacebookDataListbox.ListBox.DoubleClick += new System.EventHandler(this.AlbumsFacebookDataListbox_DoubleClick);

            // 
            // FeedTab
            // 
            this.AccessibleName = "feedTabPage";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.FavouriteTeamsFacebookDataListbox);
            this.Controls.Add(this.PostsFacebookDataListBox);
            this.Controls.Add(this.LikedPageFacebookDataListbox);
            this.Controls.Add(this.AlbumsFacebookDataListbox);
            this.Controls.Add(this.logoutButton);
            this.Location = new System.Drawing.Point(8, 51);
            this.Name = "FeedTab";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.FeedTab_Load);
            this.Enter += new System.EventHandler(this.FeedTab_Enter);
            this.ResumeLayout(false);

    }


    private void FeedTab_Enter(object sender, EventArgs e)
    {
    }

    internal void loadDataToListboxes(User i_LoggedInUser)
    {
        this.LikedPageFacebookDataListbox.setDataSource(i_LoggedInUser.LikedPages.ToArray());
        this.LikedPageFacebookDataListbox.ListBox.DisplayMember = "Name";
        if (i_LoggedInUser.FavofriteTeams != null)
        {
            this.FavouriteTeamsFacebookDataListbox.setDataSource(i_LoggedInUser.FavofriteTeams.ToArray());

        }        
        
        this.FavouriteTeamsFacebookDataListbox.ListBox.DisplayMember = "Name";
        this.PostsFacebookDataListBox.setDataSource(i_LoggedInUser.Posts.ToArray());
        this.PostsFacebookDataListBox.IsPictureSupported = false;
        this.AlbumsFacebookDataListbox.setDataSource(i_LoggedInUser.Albums.ToArray());
        this.AlbumsFacebookDataListbox.IsPictureSupported = false;
        
    }

    private void FeedTab_Load(object sender, EventArgs e)
    {

    }

    private void facebookDataListbox2_Load(object sender, EventArgs e)
    {

    }

    private void LikedPageFacebookDataListbox_Load_1(object sender, EventArgs e)
    {

    }

    private void PostsFacebookDataListBox_Load(object sender, EventArgs e)
    {

    }

    private void FavouriteTeamsFacebookDataListbox_Load(object sender, EventArgs e)
    {

    }
    
    private void AlbumsFacebookDataListbox_Load(object sender, EventArgs e)
    {

    }

    private void LikedPageFacebookDataListbox_DoubleClick(object sender, EventArgs e)
    {
        ListBox senderAsListBox = sender as ListBox;
        Page selectedItem = senderAsListBox.SelectedItem as Page;
        if (selectedItem != null)
        {
                ShowLikedPageDetails(selectedItem);
        }
    }

    private void ShowLikedPageDetails(Page page)
    {
        LikedPageDetailsForm detailsForm = new LikedPageDetailsForm(page);
        detailsForm.ShowDialog(); // Show the popup as a dialog
    }

    private void AlbumsFacebookDataListbox_DoubleClick(object sender, EventArgs e)
    {
        ListBox senderAsListBox = sender as ListBox;
        Album selectedItem = senderAsListBox.SelectedItem as Album;
        if (selectedItem != null)
        {
            try
            {
                List<string> imageUrls = new List<string>(); ;
                foreach (var picture in selectedItem.Photos)
                {
                    imageUrls.Add(picture.PictureNormalURL);
                }
                PicturesGallery picturesGallery = new PicturesGallery();
                picturesGallery.AddImages(imageUrls);
                picturesGallery.ShowDialog();
            }
            finally { }
            
        }
    }

}
