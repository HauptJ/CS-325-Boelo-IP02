using System;
using System.Collections.Generic;
using FileHelpers;
namespace IP02
{
    [DelimitedRecord(",")]
    public class IP02_Boelo_DepositIO : IP02_TransactionsIO_Boelo
    {
        public string checkType = "DEPOSIT";

        public override string ToString()
        {
            return "Deposit: \n" + transDate + "," + "DEPOSIT" + "," + amount + "," + "DEPOSIT" + "," + memo + "," + newBalance + " \n ";
        }
    }
}
