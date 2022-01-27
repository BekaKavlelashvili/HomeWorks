using System;
namespace homework10
{
    public class MicroFinance : FinanceOperations
    {
        public void CalculateLoanPercent(int month)
        {
            double pay2 = (month * 10) / 100 + (month * 10);
            Console.WriteLine($"You will be deducted from the loan ${pay2} .");
        }
        public void CheckUserHistory()
        {
            //realurad aq aris ragac problema raa, aqve ar unda mtxovdes mnishvnelobis sheyvanas parametrad
            //xoda axla swor pasuxs ar wers, radgan mainshic parametris mnishvneloba maqvs sheyvanili da
            //ragac ver angarishdeba.
            CalculateLoanPercent(month: Convert.ToInt32(Console.ReadLine()));

        }
    }
}
