using Listicle.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Listicle.Lists
{
    public class DoublyLinkedList<T> : IDoublyLinkedList<T>
    {
        public T Node { get; set; }
        public IDoublyLinkedList<T> Next { get; set; }
        public IDoublyLinkedList<T> Previous { get; set; }

        public void Add(T item)
        {
            if (Next is null)
            {
                Next.Add(item);
            }
            else
            {
                Next = new DoublyLinkedList<T>
                {
                    Node = item,
                    Previous = this
                };
            }
        }

        public void Delete(IDoublyLinkedList<T> Node)
        {
            if (Next == Node)
            {
                Next = Next.Next;
            }
        }

        public IDoublyLinkedList<T> Find(T item)
        {
            if (Next.Node.Equals(item))
            {
                return Next;
            }
            else
            {
                return Next.Find(item);
            }
        }

        public T[] Values()
        {
            var vals = new List<T>() { Node };
            if (!(Next is null))
            {
                vals.AddRange(new List<T>(Next.Values()));
            }
            return vals.ToArray();
        }
    }
}
