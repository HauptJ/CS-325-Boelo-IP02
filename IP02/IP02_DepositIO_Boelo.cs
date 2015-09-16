using FileHelpers;
namespace IP02
{
    [DelimitedRecord(";")]
    public class IP02_DepositIO_Boelo : IP02_Transactions_Boelo
    {
        public string checkType = "DEPOSIT";

        public override string ToString()
        {
            return "Deposit: \n" + transDate + " , " + checkType + " , " + amount + " , " + checkType + " , " + memo + " , " + newBalance + " \n ";
        }
    }
}
