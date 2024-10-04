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

        internal List<object> DataSource { get { return this.m_DataSource; } }
        public string DisplayMember { get; set; } = "";
        private ListBox m_ListBox;
        public bool IsDataLoaded { get; private set; } = false;

        public FacebookDataLoader(ListBox i_ListBox)
        {
            m_ListBox = i_ListBox;  
        }
        public void LoadData()
        {
            if (!IsDataLoaded)
            {
                IsDataLoaded = true;
                foreach (var item in m_DataSource)
                {
                    m_ListBox.Invoke(new Action(() => m_ListBox.Items.Add(item)));
                }
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
