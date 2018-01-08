using System.Text;

namespace DefiningClasses
{
    class IPhone4s
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private Battery battery;
        private Display display;

        public IPhone4s()
        {
            this.model = "iPhone 4s";
            this.manufacturer = "Apple";
            this.price = 300;
            this.battery = new Battery("616-0580", 200, 14, BatteryType.LiIon);
            this.display = new Display(3.5, 10000000);
        }

        public string Model { get { return this.model; } }
        public string Manufacturer { get { return this.manufacturer; } }
        public decimal Price { get { return this.price; } }
        public Battery Battery { get { return this.battery; } }
        public Display Display { get { return this.display; } }

        public override string ToString()
        {
            return string.Format("Model: {0}\nManufacturer: {1}\nPrice: {2}\nBattery:\n{3}\nDisplay:\n{4}\n", this.Model, this.Manufacturer, this.Price, this.Battery, this.Display);
        }
    }
}