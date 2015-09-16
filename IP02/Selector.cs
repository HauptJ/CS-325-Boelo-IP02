using FileHelpers;
using System;
namespace IP02 {
    public class Selector
    {

        public Type CustomSelector(MultiRecordEngine engine, string recordLine)
        {
            if (recordLine.Length == 0)
                return null;

            if (Char.ToLower(recordLine[1]) == 'a')
                return typeof(IP02_CashIO_Boelo);
            else if (Char.ToLower(recordLine[1]) == 'h')
                return typeof(IP02_CheckIO_Boelo);
            else
                return typeof(IP02_DepositIO_Boelo);
        }
    }
}