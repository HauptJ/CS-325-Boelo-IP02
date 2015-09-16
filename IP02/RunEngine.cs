using FileHelpers;
using System;

namespace IP02 {
    public class RunEngine
    {
        Selector CustomSelector = new Selector();
        public void test()
        {
            var engine = new MultiRecordEngine(typeof(IP02_CashIO_Boelo),
                typeof(IP02_CheckIO_Boelo),
                typeof(IP02_DepositIO_Boelo));

            engine.RecordSelector = new RecordTypeSelector(CustomSelector.CustomSelector);

            //input file
            var res = engine.ReadFile("checkbook.cbk");

            /// to Write use:
            engine.WriteFile("checkbook.cbk", res);

            foreach (var rec in res)
                Console.WriteLine(rec.ToString());
        }
    }
}