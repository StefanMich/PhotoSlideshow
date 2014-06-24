using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSlideshow.Model
{
    public class Picture : AlbumItem
    {
        public string Path { get; set; }

        public Picture(string path)
        {
            this.IsHightlight = false;
            this.Path = path;
        }

        public override AlbumItem Next(bool hightlight)
        {
            return this;
        }
    }
}
