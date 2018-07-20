using Listicle.Tests;
using System;

namespace Listicle
{
    class Program
    {
        private bool running = true;
        static void Main(string[] args)
        {
            var prog = new Program();
            prog.Run();
        }
        public void Run()
        {
            while (running)
            {
                Console.WriteLine("Please enter test you would like to run");
                Console.WriteLine("you can enter the first letter of each word or the whole thing...");
                Console.WriteLine();
                Console.WriteLine("Singly Linked List Tests");
                Console.WriteLine("Doubly Linked List Tests");
                Console.WriteLine();
                var comm = TakeCommand();

                Console.Clear();
            }
        }
        public string TakeCommand()
        {
            var comm = Console.ReadLine().ToLower();
            Console.WriteLine();
            switch (comm)
            {
                case "singlylinkedlisttests":
                    singlyTest();
                    break;
                case "singly linked list tests":
                    singlyTest();
                    break;
                case "sllt":
                    singlyTest();
                    break;
                case "s":
                    singlyTest();
                    break;
                case "doublylinkedlisttests":
                    doublyTest();
                    break;
                case "doubly linked list tests":
                    doublyTest();
                    break;
                case "dllt":
                    doublyTest();
                    break;
                case "d":
                    doublyTest();
                    break;
                case "x":
                    running = false;
                    break;
                default:
                    return comm;
            }
            return comm;
        }
        public void singlyTest()
        {
            var slt = new SinglyLinkedListTests();
            slt.RunAllTests();
        }
        public void doublyTest()
        {
            var dlt = new DoublyLinkedListTests();
            dlt.RunAllTests();
        }
    }
}
