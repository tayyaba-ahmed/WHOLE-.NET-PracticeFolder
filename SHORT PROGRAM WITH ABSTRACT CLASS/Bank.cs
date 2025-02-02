﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHORT_PROGRAM_WITH_ABSTRACT_CLASS
{
    abstract class Bank
    {
        internal int balance = 5000;
        public abstract void Credit(int amt);
        public abstract void Debit(int amt);
        public abstract bool Login(int pincode);
        public abstract void CheckBalance();
        void BankInfo()
        {
            Console.WriteLine("HBL Bank");
        }
    }
}
