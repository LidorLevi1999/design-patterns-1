using System;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PhotoProxy
    {
        private Photo m_Photo;
        internal int m_Id;
        private int? m_RandomLikeCount = null;

        public PhotoProxy(Photo i_Photo, int i_Id)
        {
            m_Photo = i_Photo;
            m_Id = i_Id;
        }

        public Image ImageNormal
        {
            get { return m_Photo.ImageNormal; }
        }

        public int Index
        { 
            get { return m_Id; } 
        }

        public string PhotoUrl
        {
            get { return m_Photo.PictureNormalURL; } 
        }

        public string PhotoId
        {
            get { return m_Photo.Id; }
        }

        public string AlbumName
        {
            get { return m_Photo.Album.Name; }
        }

        public string PhotoName
        {
            get { return m_Photo.Name ?? string.Format("picture {0}", m_Id); }
        }

        public int LikeCount
        {
            get
            {
                if (m_Photo.LikedBy != null && m_Photo.LikedBy.Count > 0)
                {
                    return m_Photo.LikedBy.Count;
                }
                else
                {
                    if (!m_RandomLikeCount.HasValue)
                    {
                        Random random = new Random();
                        m_RandomLikeCount = random.Next(0, 1000);
                    }
                    return m_RandomLikeCount.Value;
                }
            }
        }


        public DateTime CreatedTime
        {
            get { return m_Photo.CreatedTime ?? new DateTime(); }
        }

        public string Description
        {
           get { return m_Photo.Message ?? "No description available."; }
        }

        public override string ToString()
        {
            return PhotoName;
        }
    }
}
