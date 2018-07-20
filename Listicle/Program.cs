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
            var slt = new SinglyLinkedListTests();
            while (running)
            {
                Console.WriteLine(slt.AddTest());
                var comm = TakeCommand();
            }
        }
        public string TakeCommand()
        {
            var comm = Console.ReadLine();
            switch (comm)
            {
                case "x":
                    running = false;
                    break;
                default:
                    return comm;
            }
            return comm;
        }
    }
}
