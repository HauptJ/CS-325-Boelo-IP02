﻿using FileHelpers;

namespace IP02
{
    [DelimitedRecord(";")]

    public class IP02_CheckIO_Boelo : IP02_Transactions_Boelo
    {
        public int checkNbr = 1001;

        public string toField;

        public override string ToString()
        {
            return "Check: \n" + transDate + " , " + checkNbr + " , " + amount + " , " + toField + " , " + memo + " , " + newBalance + " \n ";
        }
    }
}