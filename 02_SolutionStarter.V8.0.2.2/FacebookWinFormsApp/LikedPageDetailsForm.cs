using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class LikedPageDetailsForm : Form
    {
        public LikedPageDetailsForm(Page i_Page)
        {
            InitializeComponent();
            long pageLikesCount = getPageLikeCounts(i_Page);

            likedPageProfilePictureBox.ImageLocation = i_Page.PictureSqaureURL;
            likedPageName.Text = i_Page.Name;
            likedPageDescription.Text = i_Page.Description;
            likedByNum.Text = string.Format("Liked by {0} People!", pageLikesCount);
        }

        private long getPageLikeCounts(Page i_Page)
        {
            long pageLikesCount = 0;

            if(i_Page != null && i_Page.LikesCount.HasValue)
            {
                pageLikesCount = i_Page.LikesCount.Value;
            }

            return pageLikesCount;
        }

    }
}
