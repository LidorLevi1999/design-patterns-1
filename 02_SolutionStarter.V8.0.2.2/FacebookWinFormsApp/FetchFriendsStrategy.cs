using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FetchFriendsStrategy : IFetchingStrategy
    {
        private FriendsTab m_FriendsTab;

        public FetchFriendsStrategy(FriendsTab friendsTab)
        {
            m_FriendsTab = friendsTab;
        }

        public void FetchData(User user)
        {
            var friends = user.Friends;
            m_FriendsTab.Invoke(new Action(() =>
            {
                m_FriendsTab.userBindingSource.DataSource = friends;
            }));
        }
    }
}
