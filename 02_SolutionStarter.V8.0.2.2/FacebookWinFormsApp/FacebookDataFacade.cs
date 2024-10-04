using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BasicFacebookFeatures
{
    internal class FacebookDataFacade
    {
        private readonly FacebookDataLoader m_DataLoader;

        public bool IsDataLoaded { get {  return m_DataLoader.IsDataLoaded; } }

        public FacebookDataFacade(FacebookDataLoader dataLoader)
        {
            m_DataLoader = dataLoader;
        }

        public void SetDataSource(object[] i_DataSource)
        {
            m_DataLoader.SetDataSource(i_DataSource);
        }

        public List<object> GetDataSource()
        {
            return m_DataLoader.GetDataSource();
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
