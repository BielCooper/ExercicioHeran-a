﻿using System;

namespace ExercicioHerança.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base (number, holder, balance)
        { 
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit) {
                Balance += amount;
            }
            else {
                Console.WriteLine("Você não possui este limite para empréstimo");
            }
        }
    }
}
