using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHORT_PROGRAM_WITH_ABSTRACT_CLASS
{
    internal class BankImplementation : Bank
    {
        public override void CheckBalance()
        {
            if (this.Login(1721))
            {
                Console.WriteLine("Balance is {0}", balance);
            }
            else
            {
                Console.WriteLine("Invalid Pin Code");
            }
        }

        public override void Credit(int amt)
        {
            if (this.Login(1721))
            {
                balance += amt;
            }
            else
            {
                Console.WriteLine("Invalid Pin Code");
            }
           
        }

        public override void Debit(int amt)
        {
            if (this.Login(1721))
            {
                balance -= amt;
            }
            else
            {
                Console.WriteLine("Invalid Pin Code");
            }
        }

        public override bool Login(int pincode)
        {
            if (pincode==1721) 
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
