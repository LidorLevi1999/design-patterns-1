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

        public FetchFriendsStrategy(FriendsTab i_FriendsTab)
        {
            m_FriendsTab = i_FriendsTab;
        }

        public void FetchData(User i_User)
        {
            var friends = i_User.Friends;
            m_FriendsTab.Invoke(new Action(() =>
            {
                m_FriendsTab.userBindingSource.DataSource = friends;
            }));
        }
    }
}
