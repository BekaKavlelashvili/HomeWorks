using System;
using System.Linq;
using System.Collections.Generic;
namespace homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region exercise1.  
            //var s2 = Convert.ToInt32(Console.ReadLine());//didi kvadratis gverdi;
            //var s1 = s2 / Math.Sqrt(2);//patara kvadratis gverdi= didi kvadratis gverdi/fesvi 2-ze;
            //var difference = Math.Pow(s2, 2) - Math.Pow(s1, 2);
            //Console.WriteLine(difference);
            #endregion

            #region exercise 2.
            //string user, user1, user2, user3, user4;
            //string[] jackpot = new string[] { "$", "$", "$", "$", "$" };
            //user = Console.ReadLine();
            //user1 = Console.ReadLine();
            //user2 = Console.ReadLine();
            //user3 = Console.ReadLine();
            //user4 = Console.ReadLine();

            //for (var j = 0; j < jackpot.Length; j++)
            //{
            //    if (user == jackpot[j] && user1 == jackpot[j + 1] && user2 == jackpot[j + 2] && user3 == jackpot[j + 3]
            //                       && user4 == jackpot[j + 4])
            //    {
            //        Console.WriteLine("You won 500000000 $");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Try again, loooser");
            //        break;
            //    }
            //}
            #endregion

            #region exercise 3.
            //Console.WriteLine("Enter win number:");
            //int win = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter draw number:");
            //int draw = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter lose numebr:");
            //int lose = Convert.ToInt32(Console.ReadLine());

            //int total_win = win * 3;
            //Console.WriteLine($"Win score = {total_win}");
            //int total_draw = draw;
            //Console.WriteLine($"draw score = {total_draw}");
            //int total_lose = lose * 0;
            //Console.WriteLine($"lose score = {total_lose}");
            //int total_score = total_win + total_draw + total_lose;
            //Console.WriteLine($"Total score {total_score}");

            #endregion

            #region exercise 4.  
            int normal_workday = 8;
            int salary_per_hour = 10;
            int salary_per_overtime_hour = 15;
            int weekend_salary_per_hour = 20;
            int normal_salary_per_day = 80;

            Console.WriteLine("Enter your monday working hours");
            int monday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your tuesday working hours");
            int tuesday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your wednesday working hours");
            int wednesday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your thursday working hours");
            int thursday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your friday working hours");
            int friday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your saturday working hours");
            int saturday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your sunday working hours");
            int sunday = Convert.ToInt32(Console.ReadLine());

            int m, t, w, th, fr;
            int sat = saturday * weekend_salary_per_hour;
            int sun = sunday * weekend_salary_per_hour;
            if (true)
            {
                if (monday > normal_workday)
                {
                    m = (monday - normal_workday) * salary_per_overtime_hour + normal_salary_per_day;
                }
                else
                {
                    m = monday * salary_per_hour;
                }
                if (tuesday > normal_workday)
                {
                    t = (tuesday - normal_workday) * salary_per_overtime_hour + normal_salary_per_day;
                }
                else
                {
                    t = tuesday * salary_per_hour;
                }
                if (wednesday > normal_workday)
                {
                    w = (wednesday - normal_workday) * salary_per_overtime_hour + normal_salary_per_day;
                }
                else
                {
                    w = wednesday * salary_per_hour;
                }
                if (thursday > normal_workday)
                {
                    th = (thursday - normal_workday) * salary_per_overtime_hour + normal_salary_per_day;
                }
                else
                {
                    th = thursday * salary_per_hour;

                }
                if (friday > normal_workday)
                {
                    fr = (friday - normal_workday) * salary_per_overtime_hour + normal_salary_per_day;
                }
                else
                {
                    fr = friday * salary_per_hour;
                }
                Console.WriteLine("---------------");
                Console.WriteLine("your salary is - ");
                Console.WriteLine(m + t + w + th + fr + sat + sun);
            }
            #endregion

            //am logikit mivyevi  magram konsolshi progress ver  vigeb :/.
            #region execise 5.
            //int run_days = Convert.ToInt32(Console.ReadLine());
            //int progress_days = 0;
            //int[] vs = new int[run_days];
            //for (int i = 0; i < run_days; i++)
            //{
            //    int per_day = Convert.ToInt32(Console.ReadLine());
            //    if (vs[i] < vs[i + 1])
            //    {
            //        vs[i + 1] = progress_days;
            //        Console.WriteLine(progress_days);
            //    }
            //}
            #endregion


            #region exercise 6.
            //Console.WriteLine("Enter character's number :");
            //int user = Convert.ToInt32(Console.ReadLine());
            //string[] myWords = new string[] { "Hello", "World", "Communication", "Private" };
            //int hello = myWords[0].Length;
            //int world = myWords[1].Length;
            //int comm = myWords[2].Length;
            //int privat = myWords[3].Length;
            //if (hello >= user)
            //{
            //    Console.WriteLine(myWords[0]);
            //}
            //if (world >= user)
            //{
            //    Console.WriteLine(myWords[1]);
            //}
            //if (comm >= user)
            //{
            //    Console.WriteLine(myWords[2]);
            //}
            //if (privat >= user)
            //{
            //    Console.WriteLine(myWords[3]);
            //}
            //if(user > world && user > hello && user > comm && user> privat)
            //{
            //    Console.WriteLine("Unsuccessful search");
            //}
            //Console.WriteLine("====================");
            //Console.WriteLine("Enter any key to exit");
            #endregion
        }
    }
}
