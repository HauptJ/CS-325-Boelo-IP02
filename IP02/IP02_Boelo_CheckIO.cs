using System;
using System.Collections.Generic;
using FileHelpers;
namespace IP02
{
    [DelimitedRecord(",")]

    public class IP02_Boelo_CheckIO : IP02_TransactionsIO_Boelo
    {
        public int checkNbr = 1001;

        public string toField;

        public override string ToString()
        {
            return "CHECK \n" + transDate + "," + checkNbr + "," + amount + "," + toField + "," + memo + "," + newBalance + " \n ";
        }
    }
}
