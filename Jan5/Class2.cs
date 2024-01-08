using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jan5
{
    internal class Class2
    {
        // more features 
        static void Main(string[] args)
        {
            Thread cuTh = Thread.CurrentThread;//property
            cuTh.Name = "Hi Thread";
            Console.WriteLine($"the name of thread    {cuTh.Name}");
            Console.WriteLine($"the id of thread is {cuTh.ManagedThreadId}");
            Console.WriteLine($"Priority of thread {cuTh.Priority}");
            Console.WriteLine($"state of thread  {cuTh.ThreadState}");
            Console.WriteLine($"thread is alive {cuTh.IsAlive}");

        }
    }
}