using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Call
    {
        private DateTime currentDateAndTime;
        private string dialedPhoneNumber;
        private int callDurationInSeconds;

        public Call(DateTime currentDateAndTime, string dialedPhoneNumber, ushort callDuartionInSeconds)
        {
            this.CurrentDateAndTime = currentDateAndTime;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.CallDurationInSeconds = callDuartionInSeconds;
        }

        public DateTime CurrentDateAndTime { get { return currentDateAndTime; } set { if (value.Year < 1980 || value.Year > 2017 || value.Month < 0 || value.Month > 12 || value.Day < 0 || value.Day > 31 || value.Hour < 0 || value.Hour > 23 || value.Minute < 0 || value.Minute > 59) throw new ArgumentException("Incorrect date and/or time entered!"); else this.currentDateAndTime = value; } }

        public string DialedPhoneNumber { get { return this.dialedPhoneNumber; } set { if (value.Length == 0 || value.Length > 10 || !value.StartsWith("0")) throw new ArgumentException("Incorrect phone number entered!"); else this.dialedPhoneNumber = value; } }

        public int CallDurationInSeconds { get { return this.callDurationInSeconds; } set { if (value > 1000) throw new ArgumentException("Incorrect call duration entered!"); else this.callDurationInSeconds = value; } }

        public override string ToString()
        {
            return string.Format("Current date and time: {0:MM/dd/yy H:mm}\nDialed phone number: {1:(+359) ## #######}\nCall duration in seconds: {2} sec.\n", this.CurrentDateAndTime, this.DialedPhoneNumber, this.CallDurationInSeconds);
        }
    }
}