using FileHelpers;
using System;
namespace IP02 {
    public class IP02_Boelo_Selector
    {

        public Type CustomSelector(MultiRecordEngine engine, string recordLine)
        {
            if (recordLine.Length == 0)
                return null;

            if (Char.ToLower(recordLine[1]) == 'a')
                return typeof(IP02_Boelo_CashIO);
            else if (Char.ToLower(recordLine[1]) == 'h')
                return typeof(IP02_Boelo_CheckIO);
            else
                return typeof(IP02_Boelo_DepositIO);
        }
    }
}