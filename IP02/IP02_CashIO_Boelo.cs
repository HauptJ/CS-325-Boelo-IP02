using System;
using System.Collections.Generic;
using FileHelpers;
namespace IP02
{
    [DelimitedRecord(",")]
    public class IP02_CashIO_Boelo : IP02_TransactionsIO_Boelo
    {
        public string checkType = "CASH";

        public override string ToString()
        {
            return "CASH," + transDate + "," + "CASH" + "," + checkType + "," + amount + "," + checkType + "," + memo + "," + newBalance + " \n ";
        }
    }
}
