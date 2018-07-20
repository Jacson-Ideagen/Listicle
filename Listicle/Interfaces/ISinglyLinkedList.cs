using System;
using System.Collections.Generic;
using System.Text;

namespace Listicle.Interfaces
{
    public interface ISinglyLinkedList<T>
    {
        T Node { get; set; }

        ISinglyLinkedList<T> Next { get; set; }

        void Add(T item);

        void Delete(ISinglyLinkedList<T> Node);

        ISinglyLinkedList<T> Find(T item);

        T[] Values();
    }
}
