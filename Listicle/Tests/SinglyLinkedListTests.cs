using Listicle.Lists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Listicle.Tests
{
    class SinglyLinkedListTests
    {
        public bool AddTest()
        {
            var result = true;

            var list = new SinglyLinkedList<string>();

            list.Add("jim");
            if(list[0].Node != "jim")
            {
                result = false;
            }

            return result;
        }
        public bool FindTest()
        {
            var result = true;

            var list = new SinglyLinkedList<string>();

            list.Add("jim");
            list.Add("dave");

            if (list.Find("dave") == null)
            {
                result = false;
            }

            return result;
        }
    }
}
