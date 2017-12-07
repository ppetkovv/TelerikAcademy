using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class GSMCallHistoryTest
    {
        private GSM gsm;

        public GSMCallHistoryTest() { }

        public GSMCallHistoryTest(GSM gsm)
        {
            this.GSM = gsm;
        }

        public GSM GSM { get { return this.gsm; } set { this.gsm = value; } }

        public void AddGSMForTesting(GSM gsm)
        {
            this.GSM = gsm;
        }

        public void AddCallsToGSMInstance(params Call[] someCalls)
        {
            foreach (Call currentCall in someCalls)
            {
                this.gsm.AddCall(currentCall);
            }
        }

        public void DisplayGSMCallsInformation()
        {
            foreach (Call currentCall in this.GSM.CallHistory)
            {
                Console.WriteLine(currentCall);
            }
        }

        public decimal GetTotalPriceOfCallHistoryByFixedPrice()
        {
            return gsm.CallHistory.Select(currentCall => currentCall.CallDurationInSeconds).Sum() / (decimal)60 * (decimal)0.37;
        }

        public Call RemoveTheLongestCallFromHistory()
        {
            Call longestCall = this.gsm.CallHistory.OrderByDescending(call => call.CallDurationInSeconds).First();
            this.gsm.CallHistory.Remove(longestCall);
            return longestCall;
        }
    }
}