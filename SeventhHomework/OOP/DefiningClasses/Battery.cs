using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Battery
    {
        private string model;
        private double? hoursIdle;
        private decimal? hoursTalk;
        private BatteryType? batteryType;

        public Battery() { }

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(double hoursIdle)
        {
            this.HoursIdle = hoursIdle;
        }

        public Battery(decimal hoursTalk)
        {
            this.HoursTalk = hoursTalk;
        }

        public Battery(BatteryType batteryType)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string model, double hoursIdle) : this(model)
        {
            this.HoursIdle = hoursIdle;
        }

        public Battery(string model, decimal hoursTalk) : this(model)
        {
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, BatteryType batteryType) : this(model)
        {
            this.BatteryType = batteryType;
        }

        public Battery(double hoursIdle, decimal hoursTalk) : this(hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }

        public Battery(double hoursIdle, BatteryType batteryType) : this(hoursIdle)
        {
            this.BatteryType = batteryType;
        }

        public Battery(decimal hoursTalk, BatteryType batteryType) : this(hoursTalk)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string model, double hoursIdle, decimal hoursTalk) : this(model, hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, double hoursIdle, BatteryType batteryType) : this(model, hoursIdle)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string model, decimal hoursTalk, BatteryType batteryType) : this(model, hoursTalk)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string model, double hoursIdle, decimal hoursTalk, BatteryType batteryType) : this(model, hoursIdle, hoursTalk)
        {
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                    throw new ArgumentException("Incorrect battery model!");
                else this.model = value;
            }
        }

        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0 || value > 240)
                    throw new ArgumentException("Incorrect value for hours idle!");
                else
                    this.hoursIdle = value;
            }
        }

        public decimal? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0 || value > 72)
                    throw new ArgumentException("Incorrect value for hours talk!");
                else
                    this.hoursTalk = value;
            }
        }

        public BatteryType? BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if ((int)value.Value < 0 || (int)value.Value > 3)
                    throw new ArgumentException("Incorrect underlying value for battery type!");
                else
                    this.batteryType = value;
            }
        }

        public override string ToString()
        {
            StringBuilder finalResult = new StringBuilder();
            finalResult.Append("Model: ").Append(string.IsNullOrEmpty(this.model) ? "" : this.model).Append("\n");
            finalResult.Append("Hours Idle: ").Append(this.HoursIdle == null ? "" : hoursIdle.ToString()).Append("\n");
            finalResult.Append("Hours Talk: ").Append(this.HoursTalk == null ? "" : hoursTalk.ToString()).Append("\n");
            finalResult.Append("Battery type: ").Append(this.BatteryType == null ? "" : ((BatteryType)batteryType).ToString()).Append("\n");
            return finalResult.ToString();
        }
    }
}