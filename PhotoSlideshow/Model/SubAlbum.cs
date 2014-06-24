using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSlideshow.Model
{
    public class SubAlbum
    {
        public string Name { get; set; }
        public string Description { get; set; }

        private List<SubAlbum> subAlbumCollection;

        public List<SubAlbum> SubAlbumCollection
        {
            get { return subAlbumCollection; }
        }

        private List<Picture> pictures;

        public List<Picture> Pictures
        {
            get { return pictures; }
        }

        public Picture FrontPicture { get; set; }

        public SubAlbum()
        {
            subAlbumCollection = new List<SubAlbum>();
            pictures = new List<Picture>();
        }

        public SubAlbum(string name, string description):this()
        {
            this.Name = name;
            this.Description = description;
        }
    }

}
