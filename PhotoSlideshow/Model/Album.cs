using System;
using System.Collections;
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


        OrderedList items = new OrderedList();

        

        public OrderedList Items
        {
            get { return items; }
            set { items= value; }
        }
        

        public Album()
        {
            items = new OrderedList();
        }

        public Album(string name, string creator):this()
        {
            this.Name = name;
            this.Creator = creator;
        }


        public Picture Next(bool highlight)
        {
            return items.Next(highlight);
        }

    }
}
