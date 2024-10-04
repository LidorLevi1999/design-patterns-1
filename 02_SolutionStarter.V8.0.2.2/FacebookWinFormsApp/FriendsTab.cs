using FacebookWrapper.ObjectModel;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FriendsTab : UserControl
    {
        internal readonly User r_LoggedInUser;
        private FriendsTabLogic m_FriendsTabLogic;
        private IFetchingStrategy m_FetchingStrategy;

        public FriendsTab(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            this.m_FriendsTabLogic = new FriendsTabLogic(this);
            InitializeComponent();
        }

        private void fetchFriendsButton_Click(object sender, EventArgs e)
        {
            m_FetchingStrategy = new FetchFriendsStrategy(this);
            new Thread(() => m_FetchingStrategy.FetchData(r_LoggedInUser)).Start();
        }

        private void albumsListBox_DoubleClick(object sender, System.EventArgs e)
        {
            m_FriendsTabLogic.ShowAlbumsPictures(albumsListBox.SelectedItem);
        }

        private void myFriendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox friendsListBox = sender as ListBox;
            User selectedFriend = friendsListBox?.SelectedItem as User;

            if (selectedFriend != null)
            {
                m_FetchingStrategy = new FetchLikedPagesStrategy(this);
                new Thread(() => m_FetchingStrategy.FetchData(selectedFriend)).Start();
            }
        }


        private void pageListBox_DoubleClick(object sender, System.EventArgs e)
        {
            m_FriendsTabLogic.ShowLikedPageDetails(sender);
        }
    }
}
