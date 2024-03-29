﻿using Course.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto116.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        {
        }
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance() 
        { 
            Balance += Balance * InterestRate;
        }
        public override void Withdraw(double amount)
        {
           base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
