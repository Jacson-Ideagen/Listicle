using Listicle.Lists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Listicle.Tests
{
    class SinglyLinkedListTests : TestBase
    {
        public SinglyLinkedListTests()
        {
            Console.WriteLine("SinglyLinkedListTests");
            Console.WriteLine("=====================");
            Console.WriteLine();
        }
        public bool AddTest()
        {
            Console.WriteLine("SinglyLinkedListTests : AddTest");
            var result = true;

            var list = new SinglyLinkedList<string>();

            list.Add("jim");
            list.Add("dave");
            if (list[0].Node != "jim")
            {
                result = false;
            }
            if (list[1].Node == "jim")
            {
                result = false;
            }
            if (list[1].Node != "dave")
            {
                result = false;
            }

            return result;
        }
        public bool FindTest()
        {
            Console.WriteLine("SinglyLinkedListTests : FindTest");
            var result = true;

            var list = new SinglyLinkedList<string>();

            list.Add("jim");
            list.Add("dave");

            if (list.Find("dave") == null)
            {
                result = false;
            }
            if (list.Find("jim") == null)
            {
                result = false;
                if (list.Find("jim").Node != "jim")
                {
                    result = false;
                }
                if (list.Find("jim").Node == "jIm")
                {
                    result = false;
                }
            }
            if (list.Find("Z") != null)
            {
                result = false;
            }

            return result;
        }
        public bool ValuesTest()
        {
            Console.WriteLine("SinglyLinkedListTests : ValuesTest");
            var result = true;

            var list = new SinglyLinkedList<string>();

            list.Add("jim");
            list.Add("dave");
            list.Add("ben");
            list.Add("kaine");
            list.Add("ross");
            list.Add("jess");
            list.Add("lucy");
            list.Add("beth");
            list.Add("jane");
            list.Add("anne");

            string[] x = new string[]
            {
                "jim","dave","ben","kaine","ross","jess","lucy","beth","jane", "anne"
            };
            var y = list.Values();

            for(int i = 0;i< 10; i++)
            {
                if (y[i] != x[i])
                {
                    result = false;
                    break;
                }
            }

            list.Delete(list.Find("beth"));

            x = new string[]
            {
                "jim","dave","ben","kaine","ross","jess","lucy","jane", "anne"
            };
            y = list.Values();

            for (int i = 0; i < 9; i++)
            {
                if (y[i] != x[i])
                {
                    result = false;
                    break;
                }
            }

            if(list[7].Node != "jane")
            {
                result = false;
            }
            list.Delete(list.Find("anne"));
            list.Delete(list.Find("jane"));
            list.Delete(list.Find("lucy"));
            list.Delete(list.Find("ross"));
            list.Delete(list.Find("ben"));
            list.Delete(list.Find("kaine"));
            list.Delete(list.Find("jim"));


            x = new string[]
            {
                "dave","jess"
            };
            y = list.Values();

            for (int i = 0; i < 2; i++)
            {
                if (y[i] != x[i])
                {
                    result = false;
                    break;
                }
            }

            list.Delete(list.Find("dave"));

            if (list[0].Node != "jess")
            {
                result = false;
            }

            x = new string[]
            {
                "jess"
            };
            y = list.Values();

            for (int i = 0; i < 1; i++)
            {
                if (y[i] != x[i])
                {
                    result = false;
                    break;
                }
            }

            list.Delete(list.Find("jess"));


            x = new string[]
            {
            };
            y = list.Values();
            if (x.Equals(y))
            {
                result = false;
            }
            return result;
        }
        public void RunAllTests()
        {
            DoTest(AddTest());
            DoTest(FindTest());
            DoTest(ValuesTest());
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadLine();
        }
    }
}
