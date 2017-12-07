using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;
        private static IPhone4s iphoneFourS;

        public static IPhone4s Iphone4s { get { return GSM.iphoneFourS; } set { GSM.iphoneFourS = value; } }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price) : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, string owner) : this(model, manufacturer)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, Battery battery) : this(model, manufacturer)
        {
            this.Battery = battery;
        }

        public GSM(string model, string manufacturer, Display display) : this(model, manufacturer)
        {
            this.Display = display;
        }

        public GSM(string model, string manufacturer, decimal price, string owner) : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, Battery battery) : this(model, manufacturer, price)
        {
            this.Battery = battery;
        }

        public GSM(string model, string manufacturer, decimal price, Display display) : this(model, manufacturer, price)
        {
            this.Display = display;
        }

        public GSM(string model, string manufacturer, string owner, Battery battery) : this(model, manufacturer, owner)
        {
            this.Battery = battery;
        }

        public GSM(string model, string manufacturer, string owner, Display display) : this(model, manufacturer, owner)
        {
            this.Display = display;
        }

        public GSM(string model, string manufacturer, Battery battery, Display display) : this(model, manufacturer, battery)
        {
            this.Display = display;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery) : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Display display) : this(model, manufacturer, price, owner)
        {
            this.Display = display;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display) : this(model, manufacturer, price, owner, battery)
        {
            this.Display = display;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                    throw new ArgumentException("Incorrect phone model!");
                else
                    this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length < 2 || value.Length > 20)
                    throw new ArgumentException("Incorrect manufacturer name!");
                else
                    this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0 || value > 50000)
                    throw new ArgumentException("Incorrect phone prize!");
                else
                    this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length < 2 || value.Length > 50)
                    throw new ArgumentException("Incorrect owner name!");
                else
                    this.owner = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }//Not validating because of the validation of Battery class!!!
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }//Not validating because of the validation of the class!!!
        }

        public List<Call> CallHistory { get { return this.callHistory; } }

        public void AddCall(Call currentCall)
        {
            this.callHistory.Add(currentCall);
        }

        public Call DeleteLastCall()
        {
            Call lastCall = CallHistory[CallHistory.Count - 1];
            this.callHistory.Remove(lastCall);
            return lastCall;
        }

        public decimal GetTotalPriceOfCallHistory(decimal pricePerMinute)
        {
            return (this.callHistory.Select(currentCall => currentCall.CallDurationInSeconds).Sum() / (decimal)60) * pricePerMinute;
        }

        public override string ToString()
        {
            StringBuilder finalResult = new StringBuilder();
            finalResult.Append("Model: ").Append(string.IsNullOrEmpty(model) ? "" : this.model).Append("\n");
            finalResult.Append("Manufacturer: ").Append(string.IsNullOrEmpty(manufacturer) ? "" : this.manufacturer).Append("\n");
            finalResult.Append("Price: ").Append(this.Price == null ? "" : this.price.ToString()).Append("\n");
            finalResult.Append("Owner: ").Append(string.IsNullOrEmpty(owner) ? "" : this.owner).Append("\n");
            finalResult.Append("Battery: \n").Append(this.Battery == null ? "" : battery.ToString()).Append("\n");
            finalResult.Append("Display: \n").Append(this.Display == null ? "" : display.ToString()).Append("\n");
            return finalResult.ToString();
        }
    }
}