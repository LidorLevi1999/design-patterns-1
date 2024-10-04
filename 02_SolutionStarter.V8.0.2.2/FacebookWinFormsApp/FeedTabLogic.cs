using System.Collections.Generic;
using System.IO;
using System.Linq;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;
using System.Threading;
using System;

namespace BasicFacebookFeatures
{
    internal class FeedTabLogic
    {
        private readonly FeedTab m_FeedTab;
        private BindingSource m_BindingSource;

        public FeedTabLogic(FeedTab i_FeedTab)
        {
            m_FeedTab = i_FeedTab;
            m_BindingSource = new BindingSource();
        }

        public void LoadDataToListboxes(User i_LoggedInUser)
        {
            m_FeedTab.LikedPageFacebookDataListbox.DisplayMember = "Name";
            m_FeedTab.FavouriteTeamsFacebookDataListbox.DisplayMember = "Name";
            m_FeedTab.PostsFacebookDataListBox.DisplayMember = "Message";

            m_FeedTab.LikedPageFacebookDataListbox.SetDataSource(i_LoggedInUser.LikedPages?.ToArray());
            m_FeedTab.FavouriteTeamsFacebookDataListbox.SetDataSource(i_LoggedInUser.FavofriteTeams?.ToArray());
            m_FeedTab.PostsFacebookDataListBox.SetDataSource(i_LoggedInUser.Posts?.ToArray());
            m_FeedTab.PostsFacebookDataListBox.IsPictureSupported = false;
            m_FeedTab.AlbumsFacebookDataListbox.SetDataSource(i_LoggedInUser.Albums.ToArray());
            m_FeedTab.AlbumsFacebookDataListbox.IsPictureSupported = false;
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

        public void ShowAlbumDetails(object sender)
        {
            ListBox senderAsListBox = sender as ListBox;
            Album selectedItem = senderAsListBox?.SelectedItem as Album;
            if (selectedItem?.Count > 0)
            {
                PicturesGallery picturesGallery = new PicturesGallery();

                picturesGallery.Show();

                new Thread(() =>
                {
                    List<string> imageUrls = new List<string>();

                    foreach (var picture in selectedItem.Photos)
                    {
                        imageUrls.Add(picture.PictureNormalURL);
                    }

                    picturesGallery.Invoke((MethodInvoker)delegate
                    {
                        picturesGallery.AddImages(imageUrls);
                    });

                })
                .Start(); 
            }
            else
            {
                MessageBox.Show($"Album {selectedItem?.Name} doesn't contains pictures");
            }
        }

        public void ApplyDateFilterToPostListBox()
        {
            List<object> filteredPosts = new List<object>();

            foreach (var item in m_FeedTab.PostsFacebookDataListBox.GetDataSource()?.ToArray() ?? new object[0])
            {
                Post post = item as Post;

                if (post != null && post.UpdateTime >= m_FeedTab.dateTimePickerPostsAfter.Value && post.UpdateTime <= m_FeedTab.dateTimePickerPostsBefore.Value)
                {
                    filteredPosts.Add(item);
                }
            }

            m_BindingSource.DataSource = filteredPosts;
            m_FeedTab.PostsFacebookDataListBox.ListBox.DataSource = m_BindingSource;
            m_FeedTab.PostsFacebookDataListBox.ListBox.Refresh();
        }

        public void ShowAllUserMemes()
        {
            PicturesGallery picturesGallery = new PicturesGallery();
            List<string> imageUrls = new List<string>();
            string directoryOfMemesPath = Path.Combine(Application.StartupPath, MemeCreatorForm.m_MemesDirectoryPath);

            if (Directory.Exists(directoryOfMemesPath))
            {
                new Thread(() =>
                {
                    string[] memeFiles = Directory.GetFiles(directoryOfMemesPath);

                    foreach (var meme in memeFiles)
                    {
                        imageUrls.Add(meme);
                    }

                    picturesGallery.Invoke((MethodInvoker)(() => picturesGallery.AddImages(imageUrls)));
                })
                .Start();
            }

            picturesGallery.Name = "Meme Gallery";
            picturesGallery.ShowDialog();
        }
    }

}
