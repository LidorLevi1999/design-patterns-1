using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal interface IFetchingStrategy
    {
        void FetchData(User i_User);
    }
}
