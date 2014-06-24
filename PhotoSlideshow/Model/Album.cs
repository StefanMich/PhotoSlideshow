using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSlideshow.Model
{
    public class Album
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

        

        /*public Picture Next(bool highlight)
        { 


            return 
        }*/
        
    }
}
