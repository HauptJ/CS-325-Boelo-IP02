﻿using System;
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

        public void readCSV(string fileName, string info)
        {
            var engine = new MultiRecordEngine(typeof(IP02_CashIO_Boelo),
                typeof(IP02_CheckIO_Boelo),
                typeof(IP02_DepositIO_Boelo));

            engine.RecordSelector = new RecordTypeSelector(CustomSelector.CustomSelector);

            try
            {

                Console.WriteLine("File Opened");
                //input file
                //using(StreamWriter test = File.AppendText(fileName))
                //{
                //    test.WriteLine();
                //}
                //var res = engine.ReadFile(fileName);

                ///// to Write use:
                //engine.WriteFile(fileName, res);
                //MessageBox.Show(res.ToString());
                //foreach (var rec in res)
                //{
                //    Console.WriteLine(rec.ToString());

                //    MessageBox.Show(rec.ToString());
                //}
                using (StreamWriter test = File.AppendText(fileName))
                {
                    test.WriteLine(info.ToString());
                }

            }
            catch (FileNotFoundException ex)
            {
                //write error
                Console.WriteLine(ex);
            }
        }

        //create new file
        public void createNewFile(string fileName,double bal)
        {
            FileStream fs = File.Create(fileName);
            fs.Close();
            try
            {
                using (StreamWriter test = File.AppendText(fileName))
                {
                    test.WriteLine("00/00/0000,DEPOSIT,"+bal+",DEPOSIT,Initial Balance,"+bal+"\n");
                }
            }
            catch (FileNotFoundException ex)
            {
                //write error
                Console.WriteLine(ex);
            }
        }

        public double getExistingBalance()
        {

            return 0;
        }
    }
}