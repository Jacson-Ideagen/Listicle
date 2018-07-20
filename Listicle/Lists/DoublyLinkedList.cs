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

        public IDoublyLinkedList<T> this[int index]
        {
            get
            {
                var result = this;
                while (index > 0)
                {
                    result = (DoublyLinkedList<T>)result.Next;
                    index--;
                }
                return result;
            }
        }

        public void Add(T item, IDoublyLinkedList<T> caller = null)
        {
            if(caller == null)
            {
                caller = this;
            }
            if (Node == null)
            {
                Node = item;
                Next = new DoublyLinkedList<T>();
                Previous = caller;
            }
            else
            {
                Next.Add(item, caller);
            }
        }

        public void Delete(IDoublyLinkedList<T> NodeItem)
        {
            if (Node != null)
            {
                if (Equals(NodeItem))
                {
                    if (!(Next is null))
                    {
                        Node = Next.Node;
                        Next = Next.Next;
                    }
                    else
                    {
                        Node = new DoublyLinkedList<T>().Node;
                    }
                    return;
                }
            }
            if (Next.Node != null)
            {
                if (Next == NodeItem)
                {
                    Next = Next.Next;
                }
                else
                {
                    Next.Delete(NodeItem);
                }
            }
        }

        public IDoublyLinkedList<T> Find(T item)
        {
            if (Node != null)
            {
                if (Node.Equals(item))
                {
                    return this;
                }
            }

            if (Next.Node != null)
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
            else
            {
                return null;
            }
        }

        public T[] Values()
        {
            var vals = new List<T>();
            if (Node != null)
            {
                vals.Add(Node);
            }

            if (!(Next is null) && Next.Node != null)
            {
                vals.AddRange(new List<T>(Next.Values()));
            }
            return vals.ToArray();
        }
    }
}
