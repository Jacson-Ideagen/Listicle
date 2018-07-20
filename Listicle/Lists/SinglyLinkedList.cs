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

        public void Delete(ISinglyLinkedList<T> NodeItem)
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
                        Node = new SinglyLinkedList<T>().Node;
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

        public ISinglyLinkedList<T> Find(T item)
        {
            if(Node != null)
            {
                if(Node.Equals(item))
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
            if(Node != null)
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
