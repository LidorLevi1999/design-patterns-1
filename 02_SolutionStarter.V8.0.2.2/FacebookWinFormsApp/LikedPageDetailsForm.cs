using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class LikedPageDetailsForm : Form
    {
        private Page page;
        public LikedPageDetailsForm(Page page)
        {
            this.page = page;
            InitializeComponent();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LikedPageDetailsForm_Load(object sender, EventArgs e)
        {
            likedPageProfilePicture.ImageLocation = this.page.PictureSqaureURL;
            pageName.Text = page.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void likedPageProfilePicture_Click(object sender, EventArgs e)
        {

        }
    }
}
