using System;
using System.Collections.Generic;
using FileHelpers;
namespace IP02
{
    [DelimitedRecord(",")]
    public class IP02_Boelo_CashIO : IP02_TransactionsIO_Boelo
    {
        public string checkType = "CASH";

        public override string ToString()
        {
            return "CASH \n" + transDate + "," + "CASH" + "," + amount + "," + "CASH " + "," + memo + "," + newBalance + " \n ";
        }
    }
}
