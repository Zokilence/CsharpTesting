using System;
using System.Threading;

namespace CSharpTestingThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thr = new Thread(test);
            thr.Start();
        }
        static void test()
        {

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(i.ToString());
                Thread.Sleep(1000);

            }
        }
    }
}
