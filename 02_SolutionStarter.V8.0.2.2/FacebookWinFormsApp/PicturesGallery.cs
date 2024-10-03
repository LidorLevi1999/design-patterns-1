using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class PicturesGallery : Form
    {
        public PicturesGallery()
        {
            InitializeComponent();
        }

        public void AddImages(List<string> i_ImageUrls)
        {
            foreach (var url in i_ImageUrls)
            {
                PictureBox picBox = new PictureBox
                {
                    ImageLocation = url,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 200,  
                    Height = 200,
                    Margin = new Padding(10) 
                };

                galleryFlowLayoutPanel.Controls.Add(picBox); 
            }
        }
    }
}
