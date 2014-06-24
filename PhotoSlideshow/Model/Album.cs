using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSlideshow.Model
{
    public class Album :Next
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public Picture FrontPicture { get; set; }
        private List<AlbumItem> items;

        public List<AlbumItem> Items
        {
            get { return items; }
        }

        public Album()
        {
            items = new List<AlbumItem>();
        }

        public Album(string name, string creator):this()
        {
            this.Name = name;
            this.Creator = creator;
        }

        private int current = 0; 

        public AlbumItem Next(bool highlight)
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
