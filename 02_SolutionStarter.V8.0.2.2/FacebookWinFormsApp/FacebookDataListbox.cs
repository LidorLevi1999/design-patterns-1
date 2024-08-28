using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FacebookDataListbox : UserControl
    {
        internal bool IsDataLoaded { get; private set; } = false;
        internal List<object> m_DataSource { get; private set; }

        private bool m_IsPictureSupported = true;
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
        private System.Timers.Timer m_LoadingTimer;

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


        public void loadData()
        {

            // Initialize and start the timer for loading data in chunks
            if (!IsDataLoaded)
            {
                this.IsDataLoaded = true;
                this.m_CurrentLoadIndex = 0;
                m_LoadingTimer = new System.Timers.Timer(30); // Interval in milliseconds
                m_LoadingTimer.Elapsed += onLoadDataChunk;
                m_LoadingTimer.AutoReset = true;
                m_LoadingTimer.Enabled = true;
            }
        }

        public void setDataSource(object[] i_DataSource)
        {
            this.m_DataSource = i_DataSource.ToList();
        }

        private void onLoadDataChunk(object sender, ElapsedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                List<object> batchItems = new List<object>();

                int itemsToLoad = Math.Min(k_LoadChunkSize, m_DataSource.Count - m_CurrentLoadIndex);
                if (itemsToLoad > 0)
                {
                    for (int i = 0; i < itemsToLoad; i++)
                    {
                        batchItems.Add(m_DataSource[m_CurrentLoadIndex++]);
                    }

                    ListBox.BeginUpdate(); // Suspend UI updates for performance
                    ListBox.Items.AddRange(batchItems.ToArray());
                    ListBox.EndUpdate(); // Resume UI updates

                    if (m_CurrentLoadIndex >= m_DataSource.Count)
                    {
                        m_LoadingTimer.Stop();
                        m_LoadingTimer.Dispose();
                    }
                }
            });
        }

        /*
        public void loadData(object[] i_DataSource)
        {
            this.IsDataLoaded = true;
            this.ListBox.DataSource = i_DataSource;
        }
        */


        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsDataLoaded)
            {
                string text = searchTextBox.Text.ToLower();
                if (text.Length > 0)
                {
                    var filteredData = m_DataSource
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
                    ListBox.DisplayMember = "Name";

                }
                else
                {
                    ListBox.DataSource = m_DataSource;
                    ListBox.DisplayMember = "Name";
                }
            }
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}