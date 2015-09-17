using System;
using System.Collections.Generic;
using FileHelpers;
namespace IP02
{
    [DelimitedRecord(",")]
    public class IP02_DepositIO_Boelo : IP02_TransactionsIO_Boelo
    {
        public string checkType = "DEPOSIT";

        public override string ToString()
        {
            return "Deposit," + transDate + "," + "DEPOSIT" + "," + checkType + "," + amount + "," + checkType + "," + memo + "," + newBalance + " \n ";
        }
    }
}
