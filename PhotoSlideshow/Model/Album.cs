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
        private List<SubAlbum> subAlbums;

        public List<SubAlbum> SubAlbums
        {
            get { return subAlbums; }
        }

        public Album()
        {
            subAlbums = new List<SubAlbum>();
        }

        public Album(string name, string creator):this()
        {
            this.Name = name;
            this.Creator = creator;
        }
        
    }
}
