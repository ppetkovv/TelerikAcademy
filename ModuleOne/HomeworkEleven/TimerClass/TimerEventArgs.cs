using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerClass
{
    class TimerEventArgs : EventArgs
    {
        private string message;
        private int seconds;

        public TimerEventArgs(int seconds, string message)
        {
            this.Seconds = seconds;
            this.Message = message;
        }

        public string Message { get => this.message; private set { if (value == null) { throw new ArgumentNullException(); } this.message = value; } }
        public int Seconds { get => this.seconds; set { if (seconds < 0) { throw new ArgumentOutOfRangeException(); } this.seconds = value; } }
    }
}
