using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class PicturesGallery : Form
    {
        public List<Photo> m_Photos;

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

                picBox.DoubleClick += ImagePictureBox_DoubleClick;
                galleryFlowLayoutPanel.Controls.Add(picBox); 
            }
        }

        public void AddPhotos(List<Photo> i_Photos) 
        {
            m_Photos = i_Photos;
            List<string> imageUrl = new List<string>();

            foreach (Photo photo in m_Photos)
            {
                imageUrl.Add(photo.PictureNormalURL);
            }
            this.AddImages(imageUrl);
        }

        public void ImagePictureBox_DoubleClick(object sender, EventArgs e)
        {
            int imageIndex = 0;
            string selectedImageUrl = (sender as PictureBox).ImageLocation;

            if (m_Photos != null)
            {

                if (selectedImageUrl != null)
                {
                    imageIndex = getPhotoByImageUrl(selectedImageUrl);
                }

                PictureDetailsForm pictureDetailsForm = new PictureDetailsForm(this.m_Photos, imageIndex);
                this.Hide();
                pictureDetailsForm.FormClosed += PictureDetailsForm_FormClosed;
                pictureDetailsForm.Show();
            }
        }

        private void PictureDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private int getPhotoByImageUrl(string i_Url)
        {
            int count = 0;
            foreach (Photo photo in m_Photos)
            {
                if(photo.PictureNormalURL == i_Url)
                { 
                    return count; 
                }
                count++;
            }

            return -1;
        }


    }
}
