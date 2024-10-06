using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class FacebookDataFacade
    {
        private readonly FacebookDataLoader m_DataLoader;

        public bool IsDataLoaded { get {  return m_DataLoader.IsDataLoaded; } }

        public List<object> DataSource 
        {
            get {  return m_DataLoader.DataSource; }
            set
            {
                if (value != null)
                {
                    m_DataLoader.DataSource = value;
                }
            }
        }

        public FacebookDataFacade(ListBox i_ListBox, Action<List<object>> i_DataLoadedAction)
        {
            m_DataLoader = new FacebookDataLoader(i_ListBox);
            m_DataLoader.OnDataLoaded += i_DataLoadedAction;
        }

        public void LoadData(Action<List<object>> onDataLoaded)
        {
            new Thread(() =>
            {
                m_DataLoader.LoadData();
                List<object> dataSource = m_DataLoader.DataSource;
                onDataLoaded(dataSource);
            }).Start();
        }

        public void FilterData(string filterText)
        {
            m_DataLoader.FilterData(filterText);
        }
    }

}
