using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PhotoProxy
    {
        public Photo Photo { get; set; }
        internal int m_Id;
        
        public PhotoProxy(Photo i_Photo, int i_Id)
        {
            Photo = i_Photo;
            m_Id = i_Id;
        }

        public int Index
        { 
            get { return m_Id; } 
        }

        public string PhotoUrl
        {
            get { return Photo.PictureNormalURL; } 
        }

        public string PhotoId
        {
            get { return Photo.Id; }
        }

        public string AlbumName
        {
            get { return Photo.Album.Name; }
        }

        public string PhotoName
        {
            get { return Photo.Name ?? string.Format("random name {0}", 1); }
        }

        public int LikeCount
        {
            get { return Photo.LikedBy.Count; }
        }

        public DateTime CreatedTime
        {
            get { return Photo.CreatedTime ?? new DateTime(); }
        }

        public string Description
        {
           get { return Photo.Message ?? "No description available."; }
        }

        public override string ToString()
        {
            return $"{AlbumName}: {CreatedTime.ToShortDateString()} - {Description}";
        }
    }
}
