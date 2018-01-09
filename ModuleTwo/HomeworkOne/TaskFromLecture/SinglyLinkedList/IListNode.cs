using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public interface IListNode
    {
        int Value { get; set; }
        IListNode Next { get; set; }
    }
}