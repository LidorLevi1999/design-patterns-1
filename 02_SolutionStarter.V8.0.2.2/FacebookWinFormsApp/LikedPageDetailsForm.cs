using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class LikedPageDetailsForm : Form
    {
        public LikedPageDetailsForm(Page page)
        {
            InitializeComponent();
            likedPageProfilePictureBox.ImageLocation = page.PictureSqaureURL;
            likedPageName.Text = page.Name;
            likedPageDescription.Text = page.Description;
            likedByNum.Text = string.Format("Liked by {0}!", 100);
        }

    }
}
