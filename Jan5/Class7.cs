using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan5
{
    public  class Class7
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(CallingFunctions);
            t1.Start();
            t1.Wait();
            Console.ReadLine();
        }
        static async void CallingFunctions()
        {
            string filePath = @"D:\StudentData.txt";
            Task<int> t1 = ReadFile(filePath);
            Console.WriteLine(" Other work 1");
            Console.WriteLine(" Other work 2");
            Console.WriteLine(" Other work 3");
            int len = await t1;
            Console.WriteLine(" Total Length " + len);
            Console.WriteLine("  after work 1");
            Console.WriteLine(" after  work 2");
        }
        static async Task<int> ReadFile(string f)
        {
            int len = 0;
            Console.WriteLine("File Reading is startiing");
            using (StreamReader sr = new StreamReader(f))
            {
                string content = await sr.ReadToEndAsync();// reads but allows other function to go
                len = content.Length;
            }
            Console.WriteLine(" File reading completed ");
            return len;
        }
    }
}