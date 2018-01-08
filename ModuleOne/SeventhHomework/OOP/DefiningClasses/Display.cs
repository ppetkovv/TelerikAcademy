using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Display
    {
        private double? size;
        private int? numberOfColors;

        public Display() { }

        public Display(double size)
        {
            this.Size = size;
        }

        public Display(int numberOfColors)
        {
            this.NumberOfColors = numberOfColors;
        }

        public Display(double size, int numberOfColors) : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }

        public double? Size
        {
            get { return this.size; }
            set
            {
                if (value < 0 || value > 15)
                    throw new ArgumentException("Incorrect value for display size!");
                else
                    this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value < 0 || value > 30000000)
                    throw new ArgumentException("Incorrect value for number of colors for the display!");
                else
                    this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder finalResult = new StringBuilder();
            finalResult.Append("Size: ").Append(this.Size == null ? "" : this.Size.ToString()).Append("\n");
            finalResult.Append("Number of colors: ").Append(this.NumberOfColors == null ? "" : this.NumberOfColors.ToString()).Append("\n");
            return finalResult.ToString();
        }
    }
}