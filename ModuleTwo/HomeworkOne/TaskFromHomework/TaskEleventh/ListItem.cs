using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEleventh
{
    class ListItem<T>
    {
        private T value;
        private ListItem<T> nextItem;

        public ListItem(T value)
        {
            this.Value = value;
        }

        public ListItem(T value, ListItem<T> nextItem)
        {
            this.Value = value;
            this.NextItem = nextItem;
        }

        public T Value { get => this.value; set => this.value = value; }
        public ListItem<T> NextItem { get => this.nextItem; set => this.nextItem = value; }
    }
}
