using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class PicturesGallery : Form
    {
        public PicturesGallery()
        {
            InitializeComponent();
        }

        public void AddImages(List<string> imageUrls)
        {
            foreach (var url in imageUrls)
            {
                PictureBox picBox = new PictureBox
                {
                    ImageLocation = url,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 200,  // Set appropriate size
                    Height = 200,
                    Margin = new Padding(10)  // Add some margin for spacing
                };

                galleryFlowLayoutPanel.Controls.Add(picBox); // Add PictureBox to the FlowLayoutPanel
            }
        }
    }
}
