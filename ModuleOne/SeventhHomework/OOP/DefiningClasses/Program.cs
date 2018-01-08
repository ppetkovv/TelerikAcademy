using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM currentGSM = new GSM("IPhone7", "Apple");
            GSM currentGSM2 = new GSM("IPhone7", "Apple");
            GSM currentGSM3 = new GSM("IPhone7", "Apple");
            DateTime currentDate = new DateTime(2015, 12, 6, 6, 33, 0);
            Call firstCall = new Call(currentDate, "0887589423", 120);
            currentDate = currentDate.AddMinutes(30);
            Call secondCall = new Call(currentDate, "0878236732", 180);
            GSMTest someTest = new GSMTest(new GSM[] { currentGSM, currentGSM2, currentGSM3 });
        }
    }
}
