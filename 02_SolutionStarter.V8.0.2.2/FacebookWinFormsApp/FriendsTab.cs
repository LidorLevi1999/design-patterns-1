using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FriendsTab : UserControl
    {
        internal readonly User r_LoggedInUser;
        private FriendsTabLogic m_FriendsTabLogic;
        public FriendsTab(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            this.m_FriendsTabLogic = new FriendsTabLogic(this);
            InitializeComponent();
        }

        private void fetchFriendsButton_Click(object sender, System.EventArgs e)
        {
            userBindingSource.DataSource = r_LoggedInUser.Friends;
        }

        private void albumsListBox_DoubleClick(object sender, System.EventArgs e)
        {
            m_FriendsTabLogic.ShowAlbumsPictures(albumsListBox.SelectedItem);
        }

        private void myFriendsListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ListBox friendsListBox = sender as ListBox;
            User friend = friendsListBox?.SelectedItem as User;
            if(friend != null)
            {
                pageBindingSource.DataSource = friend.LikedPages;
            }
        }

        private void pageListBox_DoubleClick(object sender, System.EventArgs e)
        {
            m_FriendsTabLogic.ShowLikedPageDetails(sender);
        }
    }
}
