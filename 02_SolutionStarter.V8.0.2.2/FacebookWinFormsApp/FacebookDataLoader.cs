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

        internal List<object> DataSource
        {
            get { return this.m_DataSource; }
            set { m_DataSource = value; }
        }
        private ListBox m_ListBox;
        public bool IsDataLoaded { get; private set; } = false;

        public FacebookDataLoader(ListBox i_ListBox)
        {
            m_ListBox = i_ListBox;  
        }
        public void LoadData()
        {
            if (!IsDataLoaded && m_DataSource != null)
            {
                IsDataLoaded = true;
                foreach (var item in m_DataSource)
                {
                    m_ListBox.Invoke(new Action(() => m_ListBox.Items.Add(item)));
                }
            }
        }
        public void FilterData(string i_FilterText)
        {
            if (IsDataLoaded)
            {
                List<object> filteredData = m_DataSource
                    .Where(item =>
                    {
                        bool result = false;
                        var itemType = item.GetType();
                        var nameProperty = itemType.GetProperty("Name");

                        if (nameProperty != null)
                        {
                            var nameValue = nameProperty.GetValue(item)?.ToString().ToLower();
                            result =  nameValue != null && nameValue.Contains(i_FilterText);
                        }

                        return result;
                    })
                    .ToList();
                OnDataLoaded?.Invoke(filteredData);
            }
        }
    }
}
