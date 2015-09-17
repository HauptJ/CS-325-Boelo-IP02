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
            IP02_Boelo_Tally CheckTally = new IP02_Boelo_Tally();

            //CSV file name
            string fileName;
            
            // Creating and running checkbook input form.
            IP02_Boelo_Checkbook checkBook = new IP02_Boelo_Checkbook();
            Application.Run(checkBook);

            //creates and sets the balance from the form
            double balance = checkBook.getBalance();

            // create new engine
            var csvRead = new IP02_Boelo_RunEngine();

            //set fileName
            fileName = checkBook.getCheckbook();
            if (checkBook.isExisting())
            {
                balance = csvRead.readBalance(fileName);
                CheckTally.setNumChecks( csvRead.readCheckNum(fileName) );
            }
            else
            {
                csvRead.createNewFile(fileName, balance);
                
            }

            //DEBUG
            //test CSV
            //var csvTest = new RunEngine();
            //csvTest.createNewFile(fileName);
            //csvTest.test();
            
            //create new CSV
            //CsvEngine.DataTableToCsv(csvRead, fileName);

            //TODO CheckSum.newSum(initialAmount); 

            // Create a while flag for entering more than one check.
            bool Rep = true;
            do
            {
                IP02_TransactionsIO_Boelo tra;
                IP02_Boelo_InputForm InForm = new IP02_Boelo_InputForm(); 
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


                if (InForm.getSelectedType() == "CHECK") {
                    if(InForm.getAmount() > balance) {
                        DialogResult result = MessageBox.Show("This transaction will give you a negative balance. Continue?", "Boelo - Intro Project 2 - More Checks", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                            continue;
                    }
                    CheckTally.newSum(InForm.getAmount());
                    balance -= InForm.getAmount();
                    tra = new IP02_TransactionsIO_Boelo(date, CheckTally.getNumChecks().ToString(), InForm.getAmount(), InForm.getName(), InForm.getMemo(), balance);
                    CheckTally.incrementNumChecks();
                }
                else if (InForm.getSelectedType() == "CASH") {
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

                
                csvRead.readCSV(fileName, tra.getFormattedTransaction());
                // These get the vaules from the input form. 
                // Name is trimmed of whitespace and amount is positive non-zero
                // InForm.getName()
                // InForm.getAmount()
                // InForm.getMemo()

                // Creates the input processor
                IP02_Boelo_InputProcessor proc = new IP02_Boelo_InputProcessor();

                // This method converts the getAmount into the string so the decimal and the whole number can be evaluated
                proc.Parse(InForm.getAmount());

                // This method prints the dollar amount in the word format
                string dollarAmountAsTxt = proc.PrintString();

                // Creates and runs the output gui
                OutputGUI output = new OutputGUI();
                if (InForm.getSelectedType() == "CHECK" && InForm.viewCheck() == true)
                {
                    output.displayCheck(CheckTally.getNumChecks()-1, InForm.getName(), InForm.getAmount(), dollarAmountAsTxt, InForm.getMemo(), CheckTally.getNumChecksWrote(), CheckTally.getCheckSum());
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
