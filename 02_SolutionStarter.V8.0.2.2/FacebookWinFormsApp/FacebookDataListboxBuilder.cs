using BasicFacebookFeatures;
using System.Collections.Generic;

public class FacebookDataListboxBuilder
{
    private FacebookDataListbox m_DataListbox;

    public FacebookDataListboxBuilder()
    {
        m_DataListbox = new FacebookDataListbox();
    }

    public FacebookDataListboxBuilder SetName(string i_Name)
    {
        m_DataListbox.SetName(i_Name);
        return this;
    }

    public FacebookDataListboxBuilder SetDisplayMember(string i_DisplayMember)
    {
        m_DataListbox.DisplayMember = i_DisplayMember;
        m_DataListbox.ListBox.DisplayMember = i_DisplayMember;
        return this;
    }

    public FacebookDataListboxBuilder SetPictureSupport(bool i_IsPictureSupported)
    {
        m_DataListbox.IsPictureSupported = i_IsPictureSupported;
        return this;
    }

    public FacebookDataListboxBuilder SetDataSource(object[] i_DataSource)
    {
        m_DataListbox.SetDataSource(i_DataSource);
        return this;
    }

    public FacebookDataListbox Build()
    {
        return m_DataListbox;
    }
}
