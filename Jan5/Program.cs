using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan5
{
    internal class Program
    {
        static void Fun1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 Called {0}", i);
            }
        }
        static void Fun2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 Called {0}", i);
            }
        }
        static void Main(string[] args)
        {
            Fun1();// till loop completes , then fun2 will start 
            Fun2();
        }
    }
}
