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

        public FetchLikedPagesStrategy(FriendsTab i_FriendsTab)
        {
            m_FriendsTab = i_FriendsTab;
        }
        public void FetchData(User i_User)
        {
            var likedPages = i_User.LikedPages;
            m_FriendsTab.Invoke(new Action(() =>
            {
                m_FriendsTab.pageBindingSource.DataSource = likedPages;
            }));
        }
    }

}
