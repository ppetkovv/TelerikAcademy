using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeException
{
    public class InvalidRangeException<T> : ArgumentOutOfRangeException
    {
        private T bottomBorder;
        private T aboveBorder;
        private T actualValue;
        private string message;

        public InvalidRangeException(T bottomBorder, T aboveBorder, string paramName, T actualValue, string message) : base(paramName)
        {
            this.BottomBorder = bottomBorder;
            this.AboveBorder = aboveBorder;
            this.ActualValue = actualValue;
            this.Message = message;
        }

        public T BottomBorder { get => this.bottomBorder; set => this.bottomBorder = value; }
        public T AboveBorder { get => this.aboveBorder; set => this.aboveBorder = value; }
        public new T ActualValue { get => this.actualValue; set => this.actualValue = value; }

        public new string Message
        {
            get => this.message;
            private set => this.message = value;
        }
    }
}