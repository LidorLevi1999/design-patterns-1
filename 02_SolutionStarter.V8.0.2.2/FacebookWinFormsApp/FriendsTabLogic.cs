using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class FriendsTabLogic
    {
        private FriendsTab m_FriendsTab;
        internal bool IsDataLoaded { get; set; } = false;
        public FriendsTabLogic(FriendsTab i_FriendsTab)
        {
            this.m_FriendsTab = i_FriendsTab;
        }

        public void ShowAlbumsPictures(object sender)
        {
            Album selectedAlbum = sender as Album;
            if (selectedAlbum?.Count > 0)
            {
                PicturesGallery picturesGallery = new PicturesGallery();

                picturesGallery.Show();

                new Thread(() =>
                {
                    //List<string> imageUrls = new List<string>();
                    List<Photo> photos = new List<Photo>();

                    foreach (var picture in selectedAlbum.Photos)
                    {
                        //imageUrls.Add(picture.PictureNormalURL);
                        photos.Add(picture);

                    }
                    picturesGallery.Invoke((MethodInvoker)delegate
                    {
                        //picturesGallery.AddImages(imageUrls);
                        picturesGallery.AddPhotos(photos);

                    });

                })
                .Start();
            }
            else
            {
                MessageBox.Show($"Album {selectedAlbum?.Name} doesn't contains pictures");
            }

        }

        public void ShowLikedPageDetails(object sender)
        {
            ListBox senderAsListBox = sender as ListBox;
            Page selectedItem = senderAsListBox?.SelectedItem as Page;

            if (selectedItem != null)
            {
                LikedPageDetailsForm detailsForm = new LikedPageDetailsForm(selectedItem);
                detailsForm.ShowDialog();
            }

        }
    }
}
