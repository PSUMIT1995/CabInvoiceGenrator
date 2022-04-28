using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenrator
{
    public class CabInvoice
    {
        const int COST_PER_KM = 10;
        const int COST_PER_MINUTE = 1;
        const int MINIMUM_FARE = 5;
        public int CalculateFare(int distance, int time)
        {
            int fare = (distance * COST_PER_KM) + (time * COST_PER_MINUTE);

            if (fare > MINIMUM_FARE)
            {
                return fare;
            }
            return MINIMUM_FARE;

        }
    }
}
