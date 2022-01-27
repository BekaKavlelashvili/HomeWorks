using System;
namespace homework10
{
    public class Bank : FinanceOperations
    {

        public void CheckUserHistory()
        {
            if (true)//rendom generatori booleanze ver gavakete da davtove ubralod ase ra.
            {
                //aqac igive problemaa rac financOperationshi. 
                CalculateLoanPercent(month: Convert.ToInt32(Console.ReadLine()));
            }
        }
        public void CalculateLoanPercent(int month)
        {
            double pay = (month * 5) / 100;
            Console.WriteLine($"You will be deducted from the loan ${pay} .");
        }
    }
}
