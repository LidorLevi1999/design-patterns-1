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
    public partial class PictureDetailsForm : Form
    {
        private List<PhotoProxy> m_PhotoList;

        public PictureDetailsForm(List<Photo> i_Photos, int i_SelectedIndex)
        {
            InitializeComponent();
            generatePhotoProxyList(i_Photos);
            photoProxyBindingSource.DataSource = m_PhotoList;
            pictureIndexListBox.DataSource = photoProxyBindingSource;
            pictureIndexListBox.SelectedIndex = i_SelectedIndex;
            picturesBindingNavigator.BindingSource = photoProxyBindingSource;
        }

        private void PictureDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void generatePhotoProxyList(List<Photo> i_Photos)
        {
            int photoId = 0;
            m_PhotoList = new List<PhotoProxy>();
            foreach (Photo photo in i_Photos)
            {
                m_PhotoList.Add(new PhotoProxy(photo, photoId));
                photoId++;
            }
        }

       
    }
}
