using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            //First way

            //int currentIntegerValue = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    try
            //    {
            //        currentIntegerValue = Int32.Parse(Console.ReadLine());
            //        if (currentIntegerValue < 0 || currentIntegerValue > 100)
            //        {
            //            throw new InvalidRangeException<int>(0, 100, "currentIntegerValue", currentIntegerValue, string.Format("You are out of range because the possible values are in the range: [{0}..{1}]{2}{3}.", 0, 100, "Param name: currentIntegerValue ", "Actual value: " + currentIntegerValue));
            //        }
            //    }
            //    catch (InvalidRangeException<int> exception)
            //    {
            //        Console.WriteLine(exception.Message);
            //    }
            //}

            //Second Way

            //DateTime currentDate = DateTime.Now;

            //try
            //{
            //    if (currentDate.Year < 1980 || currentDate.Year > 2013)
            //    {
            //        throw new InvalidRangeException<DateTime>(new DateTime(1980), new DateTime(2013), "currentDate", new DateTime(currentDate.Year), string.Format("You are out of range because the possible values are in the range: [{0}..{1}]{2}{3}.", 1980, 2013, string.Format(" Parameter name: {0}", "currentDate"), string.Format(" Actual value: {0}", currentDate.Year)));
            //    }
            //}
            //catch (InvalidRangeException<DateTime> ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}