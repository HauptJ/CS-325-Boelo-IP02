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

            //set fileName
            fileName = "checkbook.cbk";

            // Create a while flag for entering more than one check.
            bool Rep = true;

            // Creating and running input form.
            
            IP02_Checkbook_Boelo checkBook = new IP02_Checkbook_Boelo();
            Application.Run(checkBook);

            //DEBUG
            //test CSV
            //var csvTest = new RunEngine();
            //csvTest.createNewFile(fileName);
            //csvTest.test();

            //DEBUG
            //create new file


            // Read CSV


            //create new CSV
            //CsvEngine.DataTableToCsv(csvRead, fileName);
            double balance = 0;
            //TODO CheckSum.newSum(initialAmount); 
            do
            {
                IP02_TransactionsIO_Boelo tra;
                IP02_InputForm_Boelo InForm = new IP02_InputForm_Boelo(); 
                InForm.showForm();
                // Code doesn't advance until the user successfully enters a check. 
                // So beyond this point, assume a check has been entered successfully. 

                // Debug for input form
                //MessageBox.Show("Name: " + InForm.getName() + "\nAmount: " + InForm.getAmount() + "\nMemo: " + InForm.getMemo() );

                // Get the date for the transaction
                String day = DateTime.Now.Day.ToString();
                String month = DateTime.Now.Month.ToString();
                String date = (month.Length == 1 ? "0" + month : month) + "/"
                    + (day.Length == 1 ? "0" + day : day) + "/"
                    + DateTime.Now.Year;


                if (InForm.getSelectedType() == "Check") {
                    if(InForm.getAmount() > balance) {
                        DialogResult result = MessageBox.Show("This transaction will give you a negative balance. Continue?", "Boelo - Intro Project 2 - More Checks", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                            continue;
                    }
                    CheckTally.incrementNumChecks();
                    CheckTally.newSum(InForm.getAmount());
                    balance -= InForm.getAmount();
                    tra = new IP02_TransactionsIO_Boelo(date, InForm.getSelectedType(), InForm.getAmount(), InForm.getSelectedType(), InForm.getMemo(), balance);
                }
                else if (InForm.getSelectedType() == "Cash") {
                    if(InForm.getAmount() > balance) {
                        DialogResult result = MessageBox.Show("This transaction will give you a negative balance. Continue?", "Boelo - Intro Project 2 - More Checks", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                            continue;
                    }
                    balance -= InForm.getAmount();
                    tra = new IP02_TransactionsIO_Boelo(date, InForm.getSelectedType(), InForm.getAmount(), InForm.getSelectedType(), InForm.getMemo(), balance);
                }
                else {
                    balance += InForm.getAmount();
                    tra = new IP02_TransactionsIO_Boelo(date, InForm.getSelectedType(), InForm.getAmount(), InForm.getSelectedType(), InForm.getMemo(), balance);
                }

                var csvRead = new RunEngine();
                //csvRead.createNewFile("test.cbk");
                csvRead.readCSV(fileName,tra.ToString());

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
                if (InForm.getSelectedType() == "Check" && InForm.viewCheck() == true)
                {
                    output.displayCheck(CheckTally.getNumChecks(), InForm.getName(), InForm.getAmount(), dollarAmountAsTxt, InForm.getMemo(), CheckTally.getNumChecksWrote(), CheckTally.getCheckSum());
                }

                // debug for amount to string
                // MessageBox.Show("Amount: "+InForm.getAmount()+"\nAmount Text: "+dollarAmountAsTxt);
                
                // Creates a message box asking if they want to enter another check.
                DialogResult dialogResult = MessageBox.Show("Current balance: " + balance + "\nWould you like to enter another transaction?", "Boelo - Intro Project 2 - More Checks", MessageBoxButtons.YesNo);
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
