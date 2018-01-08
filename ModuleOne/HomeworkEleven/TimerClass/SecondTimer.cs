using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerClass
{
    class SecondTimer
    {
        public event EventHandler<TimerEventArgs> myEvent;

        public void PrintingMessage(TimerEventArgs eventArgs)
        {
            this.myEvent?.Invoke(this, eventArgs);
        }
    }
}