using System;
using System.Collections.Generic;
using System.Text;

namespace Listicle.Tests
{
    public class TestBase
    {
        public void DoTest(bool result)
        {
            Console.WriteLine();
            Console.WriteLine(result ? "passed" : "failed");
            Console.WriteLine();
        }
    }
}
