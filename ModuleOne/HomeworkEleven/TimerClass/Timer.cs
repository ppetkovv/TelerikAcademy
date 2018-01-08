using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerClass
{
    public delegate void MyTimerDelegate(int seconds, string message);

    class Timer
    {
        public static void PrintSomeMessage(int seconds, string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                Thread.Sleep(seconds * 1000);
            }
        }
    }
}