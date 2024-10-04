using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FetchLikedPagesStrategy : IFetchingStrategy
    {
        private FriendsTab m_FriendsTab;

        public FetchLikedPagesStrategy(FriendsTab friendsTab)
        {
            m_FriendsTab = friendsTab;
        }
        public void FetchData(User user)
        {
            var likedPages = user.LikedPages;
            m_FriendsTab.Invoke(new Action(() =>
            {
                m_FriendsTab.pageBindingSource.DataSource = likedPages;
            }));
        }
    }

}
