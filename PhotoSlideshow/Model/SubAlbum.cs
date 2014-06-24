using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSlideshow.Model
{
    public class SubAlbum : AlbumItem
    {
        
        private List<AlbumItem> items;

        public List<AlbumItem> Items
        {
            get { return items; }
        }

        public Picture FrontPicture { get; set; }

        public SubAlbum()
        {
            items = new List<AlbumItem>();
        }

        public SubAlbum(string name, string description):this()
        {
            this.Name = name;
            this.Description = description;
        }
    }

}
