using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan5
{
    internal class Class5
    {
        public static async Task Fun1()
        {
            await Task.Run(() => {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Function 1 is Async executing {0} ", i);
                    Task.Delay(1000).Wait();//like Thread.Sleep()
                }
            });
        }
        public static void Fun2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 is normal method");
                Task.Delay(1000).Wait();
            }
        }
        static void Main(string[] args)
        {
            Fun1();
            Fun2();
        }
    }
}

