using System;
using System.Collections.Generic;
using System.Text;

namespace Listicle.Interfaces
{
    public interface IDoublyLinkedList<T>
    {
        T Node { get; set; }

        IDoublyLinkedList<T> Next { get; set; }
        IDoublyLinkedList<T> Previous { get; set; }

        void Add(T item);

        void Delete(IDoublyLinkedList<T> Node);

        IDoublyLinkedList<T> Find(T item);

        T[] Values();
    }
}
