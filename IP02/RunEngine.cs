using System;
using System.Collections.Generic;
using FileHelpers;
using System.IO;
using System.Windows.Forms;

namespace IP02 {
    public class RunEngine
    {

        //public string fileName;

        Selector CustomSelector = new Selector();
        public void test(string fileName)
        {
            var engine = new MultiRecordEngine(typeof(IP02_CashIO_Boelo),
                typeof(IP02_CheckIO_Boelo),
                typeof(IP02_DepositIO_Boelo));

            engine.RecordSelector = new RecordTypeSelector(CustomSelector.CustomSelector);

            try {

                Console.WriteLine("File Opened");
                //input file
                var res = engine.ReadFile(fileName);

                /// to Write use:
                engine.WriteFile(fileName, res);

                foreach (var rec in res)
                    Console.WriteLine(rec.ToString());
            }
            catch (FileNotFoundException ex)
            {
                //write error
                Console.WriteLine(ex);
            }
        }

        public void readCSV(string fileName)
        {
            var engine = new MultiRecordEngine(typeof(IP02_CashIO_Boelo),
                typeof(IP02_CheckIO_Boelo),
                typeof(IP02_DepositIO_Boelo));

            engine.RecordSelector = new RecordTypeSelector(CustomSelector.CustomSelector);

            try
            {

                Console.WriteLine("File Opened");
                //input file
                var res = engine.ReadFile(fileName);

                /// to Write use:
                engine.WriteFile(fileName, res);

                foreach (var rec in res)
                    Console.WriteLine(rec.ToString());
            }
            catch (FileNotFoundException ex)
            {
                //write error
                Console.WriteLine(ex);
            }
        }

        //create new file
        public void createNewFile(string fileName)
        {
            FileStream fs = File.Create(fileName);
            fs.Close(); 
        }
    }
}