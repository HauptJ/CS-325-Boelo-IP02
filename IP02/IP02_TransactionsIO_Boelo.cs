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
    }
}