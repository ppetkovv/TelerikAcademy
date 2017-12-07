using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class GSMTest
    {
        private GSM[] someGSMs;

        public GSMTest(params GSM[] someGSMs)
        {
            this.someGSMs = someGSMs;
        }

        public GSM[] SomeGSMs { get { return this.someGSMs; } }

        public override string ToString()
        {
            StringBuilder finalResult = new StringBuilder();
            foreach (GSM gsm in this.SomeGSMs)
            {
                finalResult.Append(gsm.ToString());
            }
            finalResult.Append(GSM.Iphone4s);
            return finalResult.ToString();
        }
    }
}