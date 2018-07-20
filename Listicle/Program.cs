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
                var comm = TakeCommand();

                Console.Clear();
            }
        }
        public string TakeCommand()
        {
            var comm = Console.ReadLine();
            switch (comm)
            {
                case "SingleLinkedListTests":
                    singlyTest();
                    break;
                case "sllt":
                    singlyTest();
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
            Console.ReadKey();
        }
    }
}
