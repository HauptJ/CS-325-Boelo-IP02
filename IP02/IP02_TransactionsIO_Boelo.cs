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

        public string transTypePrint;

        public string memo;

        public double newBalance;

        public IP02_TransactionsIO_Boelo()
        {

        }

        public IP02_TransactionsIO_Boelo(string td, string tt, double amt, string ttp, string mem, double nb)
        {
            transDate = td;
            transType = tt;
            amount = amt;
            transTypePrint = ttp;
            memo = mem;
            newBalance = nb;
        }

        public string getFormattedTransaction()
        {
            return transDate + "," + transType + "," + amount + "," + transTypePrint + "," + memo + "," + newBalance;
        }
    }
}