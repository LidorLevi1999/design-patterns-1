using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FacebookDataListbox : UserControl
    {
        internal bool IsDataLoaded { get; set; } = false;

        public FacebookDataListbox(string i_Name)
        {
            InitializeComponent();
            this.GroupBox.Text = String.Format($"{0}", i_Name);
            this.ListBox.Text = i_Name;
        }


        private void FacebookDataListbox_Load(object sender, EventArgs e)
        {
            //ListBox.SelectedIndex = 0;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox senderAsListBox = sender as ListBox;
            Page selectedItem = senderAsListBox.SelectedItem as Page;
            this.PictureBox.ImageLocation = selectedItem?.PictureSqaureURL;
        }

        public void loadData(object[] i_DataSource)
        {
            this.ListBox.DataSource = i_DataSource;
            this.IsDataLoaded = true;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            //TODO : Maybe expand (?)
        }
    }
}
