using System;
using System.Collections.Generic;
using FileHelpers;
using System.IO;
using System.Windows.Forms;

namespace IP02 {
    public class IP02_Boelo_RunEngine
    {

        //public string fileName;

        IP02_Boelo_Selector CustomSelector = new IP02_Boelo_Selector();

        public double readBalance(string file)
        {
            string test = "";
            string[] index = null;
            int x = 1;
            StreamReader read = new StreamReader(file);
            
            while (!read.EndOfStream)
            {
                x++;
                test = read.ReadLine();
                index = test.Split(',');
            }

            //MessageBox.Show(x.ToString());
            //MessageBox.Show(index[5]);
            double hi = Convert.ToDouble(index[5]);
            read.Close();
            return hi;
        }

        public int readCheckNum(string file)
        {
            string test = "";
            string[] index = null;
            int x = 1;
            int last = 1001;
            StreamReader read = new StreamReader(file);
            while (!read.EndOfStream)
            {
                x++;
                test = read.ReadLine();
                index = test.Split(',');
                if(index[1] != "DEPOSIT" & index[1] != "CASH")
                {
                    last = Convert.ToInt32(index[1]);
                }
            }


            int hi = Convert.ToInt32(index[1]);
            read.Close();
            return hi + 1;
        }

        public void readCSV(string fileName, string info)
        {
            var engine = new MultiRecordEngine(typeof(IP02_Boelo_CashIO),
                typeof(IP02_Boelo_CheckIO),
                typeof(IP02_Boelo_DepositIO));

            engine.RecordSelector = new RecordTypeSelector(CustomSelector.CustomSelector);

            try
            {

                Console.WriteLine("File Opened");

                //var res = engine.(fileName);

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
        public void createNewFile(string fileName, double bal)
        {
            FileStream fs = File.Create(fileName);
            fs.Close();
            try
            {
                using (StreamWriter test = File.AppendText(fileName))
                {
                    string info = ("00/00/0000,DEPOSIT," + bal + ",DEPOSIT,Initial Balance," + bal);
                    test.WriteLine(info.ToString());
                }
            }
            catch (FileNotFoundException ex)
            {
                //write error
                Console.WriteLine(ex);
            }
        }
    }
}