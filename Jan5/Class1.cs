using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jan5
{
    internal class Class1
    {
        static void Fun1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 Called {0}", i);
                Thread.Sleep(2000);// 1 second
            }
        }
        static void Fun2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 Called {0}", i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {// declare thread object
            Thread t1 = new Thread(Fun1);// nothing happens 
            t1.Priority = ThreadPriority.Lowest;
            t1.Start();// here starts execution , what ? Fun1
            Thread t2 = new Thread(Fun2);// job offer
            t2.Priority = ThreadPriority.Highest;
            // t1.IsBackground = true;
            t2.Start();// in office u are assigned some work , 
                       //  t2.Abort();             
        }

    }
}
