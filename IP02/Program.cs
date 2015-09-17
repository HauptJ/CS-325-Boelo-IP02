using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using FileHelpers;

namespace IP02
{
    static class Program
    {

        //public string fileName;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            // Creating new tally.
            IP01_Tally_Boelo CheckTally = new IP01_Tally_Boelo();

            //CSV file name
            string fileName;
            
            // Creating and running input form.
            IP02_Checkbook_Boelo checkBook = new IP02_Checkbook_Boelo();
            Application.Run(checkBook);
            
            //set fileName
            fileName = checkBook.getCheckbook();

            if(!checkBook.isExisting())
            {
                var csvTest = new RunEngine();
                csvTest.createNewFile(fileName);
            }
            //DEBUG
            //test CSV
            //var csvTest = new RunEngine();
            //csvTest.createNewFile(fileName);
            //csvTest.test();

            //DEBUG
            //create new file
            //csvTest.createNewFile(fileName);

            // Read CSV
            var csvRead = new RunEngine();
            csvRead.readCSV(fileName);

            //create new CSV
            //CsvEngine.DataTableToCsv(csvRead, fileName);


            // Create a while flag for entering more than one check.
            bool Rep;
            do
            {
                IP02_TransactionsIO_Boelo tra = new IP02_TransactionsIO_Boelo();
                IP02_InputForm_Boelo InForm = new IP02_InputForm_Boelo(); 
                InForm.showForm();
                // Code doesn't advance until the user successfully enters a check. 
                // So beyond this point, assume a check has been entered successfully. 

                // Debug for input form
                //MessageBox.Show("Name: " + InForm.getName() + "\nAmount: " + InForm.getAmount() + "\nMemo: " + InForm.getMemo() );

                // Display the check
                

                // increments number of checks
                CheckTally.incrementNumChecks();

                // sum up new check sum
                CheckTally.newSum(InForm.getAmount());

                // These get the vaules from the input form. 
                // Name is trimmed of whitespace and amount is positive non-zero
                // InForm.getName()
                // InForm.getAmount()
                // InForm.getMemo()

                // Creates the input processor
                IP01_InputProcessor_Boelo proc = new IP01_InputProcessor_Boelo();

                // This method converts the getAmount into the string so the decimal and the whole number can be evaluated
                proc.Parse(InForm.getAmount());

                // This method prints the dollar amount in the word format
                string dollarAmountAsTxt = proc.PrintString();

                // Creates and runs the output gui
                OutputGUI output = new OutputGUI();
                if (InForm.viewCheck() == true)
                {
                    output.displayCheck(CheckTally.getNumChecks(), InForm.getName(), InForm.getAmount(), dollarAmountAsTxt, InForm.getMemo(), CheckTally.getNumChecksWrote(), CheckTally.getCheckSum());
                }

                // debug for amount to string
                // MessageBox.Show("Amount: "+InForm.getAmount()+"\nAmount Text: "+dollarAmountAsTxt);
                
                // Creates a message box asking if they want to enter another check.
                DialogResult dialogResult = MessageBox.Show("Would you like to enter another transaction?", "Boelo - Intro Project 2 - More Checks", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    Rep = true;
                }
                else
                {
                    Rep = false;
                }
            }
            while(Rep);
            
            // debug for tally 
            //MessageBox.Show("sum: " + CheckTally.getCheckSum() + "\nNum Checks: " + CheckTally.getNumChecks());
        }
    }
}
