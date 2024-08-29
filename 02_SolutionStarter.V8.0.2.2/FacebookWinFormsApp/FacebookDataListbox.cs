using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FacebookDataListbox : UserControl
    {
        internal bool IsDataLoaded { get; private set; } = false;
        internal List<object> m_DataSource { get; private set; }
        internal string DisplayMemeber { get; set; } = "";
        private bool m_IsPictureSupported = true;
        private System.Windows.Forms.Timer m_LoadingTimer = new System.Windows.Forms.Timer();
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
        private int m_CurrentLoadIndex = 0;
        private const int k_LoadChunkSize = 3;

        public FacebookDataListbox()
        {
            InitializeComponent();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox senderAsListBox = sender as ListBox;
            Page selectedItem = senderAsListBox.SelectedItem as Page;

            if (this.IsPictureSupported)
            {
                this.PictureBox.ImageLocation = selectedItem?.PictureSqaureURL;
            }
        }


        public void LoadData()
        {
            if (!IsDataLoaded)
            {
                this.IsDataLoaded = true;
                this.m_CurrentLoadIndex = 0;
                int intervalInMilliseconds = 30;

                m_LoadingTimer = new System.Windows.Forms.Timer(); 
                m_LoadingTimer.Interval = intervalInMilliseconds; 
                m_LoadingTimer.Tick += onLoadDataChunk;
                m_LoadingTimer.Start();
                this.ListBox.DisplayMember = DisplayMemeber;
            }
        }

        public void SetDataSource(object[] i_DataSource)
        {
            this.m_DataSource = i_DataSource.ToList();
            this.ListBox.DisplayMember = DisplayMemeber;
        }

        private void onLoadDataChunk(object sender, EventArgs e)
        {
            loadChunkData();
        }

        private void loadChunkData()
        {
            int itemsToLoad = Math.Min(k_LoadChunkSize, m_DataSource.Count - m_CurrentLoadIndex);

            if (itemsToLoad > 0)
            {
                List<object> currentItems = ListBox.DataSource as List<object> ?? new List<object>();

                for (int i = 0; i < itemsToLoad; i++)
                {
                    currentItems.Add(m_DataSource[m_CurrentLoadIndex++]);
                }

                ListBox.DataSource = null;
                ListBox.DataSource = currentItems;
                this.ListBox.DisplayMember = DisplayMemeber;
                if (m_CurrentLoadIndex >= m_DataSource.Count)
                {
                    m_LoadingTimer.Stop();
                    m_LoadingTimer.Dispose();
                    this.ListBox.DisplayMember = DisplayMemeber;

                }
            }
        }


        public void SetName(string name)
        {
            this.CategoryTextLabel.Text = name;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string displayMember = ListBox.DisplayMember;

            if (IsDataLoaded)
            {
                string text = searchTextBox.Text.ToLower();

                if (text.Length > 0)
                {
                    List<object> filteredData = m_DataSource
                    .Where(item =>
                    {
                        var itemType = item.GetType();
                        var nameProperty = itemType.GetProperty("Name");

                        if (nameProperty != null)
                        {
                            var nameValue = nameProperty.GetValue(item)?.ToString().ToLower();
                            return nameValue != null && nameValue.Contains(text);
                        }

                        return false;
                    })
                    .ToList();

                    ListBox.DataSource = filteredData;
                }
                else
                {
                    ListBox.DataSource = m_DataSource;
                }

                ListBox.DisplayMember = DisplayMemeber;
            }
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            LoadData();
            this.ListBox.DisplayMember = DisplayMemeber;
        }
    }
}