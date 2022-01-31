using System;
using homework10;
namespace homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("-----------task 1-----------");
            Fileworker2 fileworker2 = new Fileworker2();
            Console.WriteLine("Enter max value: ");
            fileworker2.MaxSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter expansion of file: ");
            fileworker2.Expansion = Console.ReadLine();
            Console.WriteLine(fileworker2.Read());
            Console.WriteLine(fileworker2.Write());
            Console.WriteLine(fileworker2.Edit());
            Console.WriteLine(fileworker2.Delete());

            Console.WriteLine("-----------task 2-----------");

            Bank bank = new Bank();
            bank.CheckUserHistory();
            bank.CalculateLoanPercent(5);

            MicroFinance microFinance = new MicroFinance();         
            microFinance.CheckUserHistory(); 
            microFinance.CalculateLoanPercent(5);


        }
    }
}
