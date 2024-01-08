using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan5
{
    internal class Class6
    {
        public static async Task<int> Fun1()
        {
            int count = 0;
            await Task.Run(() => {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Function 1 is Async executing {0} ", i);
                    count++;
                    //Task.Delay(1000).Wait();//like Thread.Sleep()
                }
            }); return count;
        }
        public static void Fun2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 is normal method");
                Task.Delay(1000).Wait();
            }
        }
        public static void Fun3(int c)
        {
            Console.WriteLine(" Total number of times " + c);
        }
        public static async void CallingFunctions()
        {
            Task<int> t1 = Fun1();
            Fun2();
            int count = await t1;// Fun1 is executii=ng in background
            Fun3(count);
        }
        static void Main(string[] args)
        {
            CallingFunctions();
        }
    }
}