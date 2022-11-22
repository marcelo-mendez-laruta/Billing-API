using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingLibrary
{
    public class Utils
    {
        public decimal GetRandomAmount()
        {
            Random random = new();
            return new decimal(random.NextDouble()*100);
        }
    }
}
