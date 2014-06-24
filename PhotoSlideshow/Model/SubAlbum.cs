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

        public SubAlbum(string name, string description)
            : this()
        {
            this.Name = name;
            this.Description = description;
        }


        private int current = 0;

        public override AlbumItem Next(bool highlight)
        {
            if (current >= items.Count)
                return null;

            if (items[current] is Picture)
                return items[current++] as Picture;

            AlbumItem nextItem = items[current].Next(highlight);
            if (nextItem is Picture)
            {
                return nextItem;
            }
            else if (nextItem == null && items[current] is SubAlbum)
            {
                if (current+1 >= items.Count)
                    return null;
                return items[++current].Next(highlight); }
            else return nextItem;
        }

    }
}
