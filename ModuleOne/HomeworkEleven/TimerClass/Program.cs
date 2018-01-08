using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Timer

            //Console.Write("Please enter time interval in seconds: ");
            //int seconds = Int32.Parse(Console.ReadLine());
            //Console.Write("Please enter the message which you want to be visualized: ");
            //string message = Console.ReadLine();

            //MyTimerDelegate myDelegate = new MyTimerDelegate(Timer.PrintSomeMessage);
            //myDelegate.Invoke(seconds, message);

            //Second Timer

            //Console.Write("Please enter time interval in seconds: ");
            //int seconds = Int32.Parse(Console.ReadLine());
            //Console.Write("Please enter the message which you want to be visualized: ");
            //string message = Console.ReadLine();

            //SecondTimer timer = new SecondTimer();
            //timer.myEvent += new EventHandler<TimerEventArgs>(PrintSomeMessage);
            //timer.PrintingMessage(new TimerEventArgs(seconds, message));
        }

        public static void PrintSomeMessage(object sender, TimerEventArgs eventArgs)
        {
            while (true)
            {
                Console.WriteLine(eventArgs.Message);
                Thread.Sleep(eventArgs.Seconds * 1000);
            }
        }
    }
}