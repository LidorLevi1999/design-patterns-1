using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FacebookDataListbox : UserControl
    {
        private FacebookDataFacade m_DataFacade;
        private bool m_IsPictureSupported = true;
        internal bool IsDataLoaded { get { return m_DataFacade.IsDataLoaded; } }
        public string DisplayMember { get; set; } = "";
        internal bool IsPictureSupported
        {
            get
            {
                return m_IsPictureSupported;
            }
            set
            {
                m_IsPictureSupported = value;
                if (m_IsPictureSupported == false)
                {
                    this.PictureBox.Visible = false;
                }
            }
        }
        public List<object> DataSource
        {
            get { return this.m_DataFacade.DataSource; }
            set { this.m_DataFacade.DataSource = value.ToList(); }
        }

        public FacebookDataListbox()
        {
            InitializeComponent();
            m_DataFacade = new FacebookDataFacade(ListBox, updateUIAfterDataLoad);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox senderAsListBox = sender as ListBox;
            Page selectedItem = senderAsListBox.SelectedItem as Page;

            if (IsPictureSupported)
            {
                this.PictureBox.ImageLocation = selectedItem?.PictureSqaureURL;
            }
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            m_DataFacade.LoadData(updateUIAfterDataLoad);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            m_DataFacade.FilterData(searchTextBox.Text.ToLower());
        }

        private void updateUIAfterDataLoad(List<object> i_DataSource)
        {
            new Thread(() =>
            {
                this.ListBox.Invoke(new Action(() =>
                {
                    this.ListBox.DataSource = i_DataSource;
                    this.ListBox.DisplayMember = this.DisplayMember;
                }));
            }).Start();
        }
        public void SetName(string i_Name)
        {
            this.CategoryTextLabel.Text = i_Name;
        }
    }
}
