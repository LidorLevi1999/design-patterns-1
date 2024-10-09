using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FeedTab : UserControl
    {
        internal FeedTabLogic m_Logic;

        public FeedTab()
        {
            InitializeComponent();
            m_Logic = new FeedTabLogic(this);
            PostsFacebookDataListBox.IsPictureSupported = false;
            initializeDatePickersForPosts();
            InitializeFacebookDataListbox();
        }


        private void InitializeFacebookDataListbox()
        {
            this.AlbumsFacebookDataListbox.SetName("Albums");
            this.LikedPageFacebookDataListbox.SetName("Liked Pages");
            this.FavouriteTeamsFacebookDataListbox.SetName("Favorite Teams");
            this.PostsFacebookDataListBox.SetName("Posts");

            this.LikedPageFacebookDataListbox.ListBox.DisplayMember = "Name";
            this.LikedPageFacebookDataListbox.DisplayMember = "Name";
            this.FavouriteTeamsFacebookDataListbox.ListBox.DisplayMember = "Name";
            this.FavouriteTeamsFacebookDataListbox.DisplayMember = "Name";
            this.PostsFacebookDataListBox.ListBox.DisplayMember = "Message";
            this.PostsFacebookDataListBox.DisplayMember = "Message";
            this.AlbumsFacebookDataListbox.ListBox.DisplayMember = "Name";
            this.AlbumsFacebookDataListbox.DisplayMember = "Name";

        }

        private void initializeDatePickersForPosts()
        {
            this.dateTimePickerPostsAfter.MinDate = new DateTime(2008, 1, 1);
            this.dateTimePickerPostsAfter.MaxDate = DateTime.Today;
            this.dateTimePickerPostsAfter.Value = dateTimePickerPostsAfter.MinDate;

            this.dateTimePickerPostsBefore.MaxDate = DateTime.Today;
            this.dateTimePickerPostsBefore.MinDate = dateTimePickerPostsAfter.Value;
            this.dateTimePickerPostsBefore.Value = dateTimePickerPostsBefore.MaxDate;
        }

        private void dateTimePickerPostsBefore_ValueChanged(object sender, EventArgs e)
        {
            if (PostsFacebookDataListBox.IsDataLoaded)
            {
                dateTimePickerPostsAfter.MaxDate = dateTimePickerPostsBefore.Value;
                m_Logic.ApplyDateFilterToPostListBox();
            }
        }

        private void dateTimePickerPostsAfter_ValueChanged(object sender, EventArgs e)
        {
            if (PostsFacebookDataListBox.IsDataLoaded)
            {

                dateTimePickerPostsBefore.MinDate = dateTimePickerPostsAfter.Value;
                m_Logic.ApplyDateFilterToPostListBox();
            }
        }

        private void likedPageFacebookDataListbox_DoubleClick(object sender, EventArgs e)
        {
            m_Logic.ShowLikedPageDetails(sender);
        }

        private void albumsFacebookDataListbox_DoubleClick(object sender, EventArgs e)
        {
            m_Logic.ShowAlbumDetails(sender);
        }

        private void myMemesButton_Click(object sender, EventArgs e)
        {
            m_Logic.ShowAllUserMemes();
        }
    }
}
