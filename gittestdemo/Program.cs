using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gittestdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            List<string> names = new List<string>();
            names.Add("abc");
            names.Add("def");
            Console.WriteLine(names.ToString());
            Console.ReadKey();
        }
    }
}
