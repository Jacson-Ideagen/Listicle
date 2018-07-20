using Listicle.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Listicle.Lists
{
    public class SinglyLinkedList<T> : ISinglyLinkedList<T>
    {
        public T Node { get; set; }

        public ISinglyLinkedList<T> Next { get; set; }

        public ISinglyLinkedList<T> this[int index]
        {
            get
            {
                var result = this;
                while(index > 0)
                {
                    result = (SinglyLinkedList<T>)result.Next;
                    index--;
                }
                return result;
            }
        }

        public void Add(T item)
        {
            if (Node == null)
            {
                Node = item;
                Next = new SinglyLinkedList<T>();
            }
            else
            {
                Next.Add(item);
            }
        }

        public void Delete(ISinglyLinkedList<T> Node)
        {
            if (Next == Node)
            {
                Next = Next.Next;
            }
        }

        public ISinglyLinkedList<T> Find(T item)
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
