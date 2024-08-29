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
        public LikedPageDetailsForm(Page i_Page)
        {
            InitializeComponent();
            likedPageProfilePictureBox.ImageLocation = i_Page.PictureSqaureURL;
            likedPageName.Text = i_Page.Name;
            likedPageDescription.Text = i_Page.Description;
            likedByNum.Text = string.Format("Liked by {0}!", 100);
        }

    }
}
