using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overhiding_and_overriding
{
    internal class Billing
    {
        // overhiding
        public new float calcbill(int amt)
        {
            return amt;
        }
    }
}
