using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSlideshow.Model
{
    public class Picture
    {
        public string Text { get; set; }
        public bool IsHightlight { get; set; }

        public string Path { get; set; }

        public Picture(string path)
        {
            this.IsHightlight = false;
            this.Path = path;
        }
    }
}
