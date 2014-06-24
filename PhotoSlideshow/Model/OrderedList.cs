using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSlideshow.Model
{
    public class OrderedList : ICollection<AlbumItem>
    {
        public OrderedList()
        {
            items = new List<AlbumItem>();
        }

        private List<AlbumItem> items;

        public List<AlbumItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        private int current = 0;

        public Picture Next(bool highlight)
        {
            AlbumItem res = null;

            if (current >= items.Count)
                return null;

            AlbumItem item = items[current];

            res = item.Next(highlight);

            if (item is SubAlbum)
            {
                if (res == null)
                {
                    current++;
                    res = this.Next(highlight);
                }
            }

            return res as Picture;
        }


        public void Add(AlbumItem item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public bool Contains(AlbumItem item)
        {
            return items.Contains(item);
        }

        public void CopyTo(AlbumItem[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return items.Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(AlbumItem item)
        {
            return items.Remove(item);
        }

        public IEnumerator<AlbumItem> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
