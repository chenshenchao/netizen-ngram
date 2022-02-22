using System;
using System.Collections.Generic;

namespace Netizen.NGram.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            NGramSpliter ngspliter = new NGramSpliter(3, 4);
            List<string> rs = ngspliter.Split("Hello World!");

            foreach(string r in rs)
            {
                Console.WriteLine(r);
            }
        }
    }
}
