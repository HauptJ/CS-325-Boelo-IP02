using System;
using System.Collections.Generic;
using FileHelpers;
namespace IP02
{
    [DelimitedRecord(",")]
    public class IP02_TransactionsIO_Boelo
    {
        public string transType;

        public string transDate;

        public double amount;

        //public string transTypePrint;

        public string memo;

        public double newBalance;

        public IP02_TransactionsIO_Boelo()
        {

        }

        public IP02_TransactionsIO_Boelo(string tt, string td, double amt, string mem, double nb)
        {
            transType = tt;
            transDate = td;
            amount = amt;
            memo = mem;
            newBalance = nb;
        }

        public string getFormattedTransaction()
        {
            return transDate + "," + transType + "," + amount + "," + memo + "," + newBalance;
        }
    }
}