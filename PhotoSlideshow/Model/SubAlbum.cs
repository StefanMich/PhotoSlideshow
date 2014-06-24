using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSlideshow.Model
{
    public class SubAlbum : AlbumItem, Next
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

        public SubAlbum(string name, string description)
            : this()
        {
            this.Name = name;
            this.Description = description;
        }


        private int current = 0;

        public override AlbumItem Next(bool highlight)
        {

            if (items[current].Next(highlight) == null)
            {
                current++;
                return items[current];
            }
            else return items[current].Next(highlight);
        }

    }
}
