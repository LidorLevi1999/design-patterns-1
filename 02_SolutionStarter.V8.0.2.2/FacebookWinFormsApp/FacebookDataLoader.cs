using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class FacebookDataLoader
    {
        public event Action<List<object>> OnDataLoaded;
        private List<object> m_DataSource;
        public string DisplayMember { get; set; } = "";
        private bool m_IsPictureSupported = true;
        private Timer m_LoadingTimer;
        private int m_CurrentLoadIndex = 0;
        private const int k_LoadChunkSize = 3;

        public bool IsDataLoaded { get; private set; } = false;

        public bool IsPictureSupported
        {
            get => m_IsPictureSupported;
            set => m_IsPictureSupported = value;
        }

        public void LoadData()
        {
            if (!IsDataLoaded)
            {
                IsDataLoaded = true;
                m_CurrentLoadIndex = 0;
                int intervalInMilliseconds = 30;

                m_LoadingTimer = new Timer
                {
                    Interval = intervalInMilliseconds
                };
                m_LoadingTimer.Tick += onLoadDataChunk;
                m_LoadingTimer.Start();
            }
        }

        public void SetDataSource(object[] i_DataSource)
        {
            m_DataSource = i_DataSource.ToList();
        }

        public List<object> GetDataSource()
        {
            return m_DataSource;
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
                List<object> currentItems = new List<object>();

                for (int i = 0; i < itemsToLoad; i++)
                {
                    currentItems.Add(m_DataSource[m_CurrentLoadIndex++]);
                }

                OnDataLoaded?.Invoke(currentItems);

                if (m_CurrentLoadIndex >= m_DataSource.Count)
                {
                    m_LoadingTimer.Stop();
                    m_LoadingTimer.Dispose();
                }
            }
        }

        public void FilterData(string filterText)
        {
            if (IsDataLoaded)
            {
                List<object> filteredData = m_DataSource
                    .Where(item =>
                    {
                        var itemType = item.GetType();
                        var nameProperty = itemType.GetProperty("Name");

                        if (nameProperty != null)
                        {
                            var nameValue = nameProperty.GetValue(item)?.ToString().ToLower();
                            return nameValue != null && nameValue.Contains(filterText);
                        }

                        return false;
                    })
                    .ToList();

                OnDataLoaded?.Invoke(filteredData);
            }
        }
    }
}
