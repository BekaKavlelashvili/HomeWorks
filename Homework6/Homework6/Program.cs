using System;
using System.Linq;
using System.Collections.Generic;
namespace Homework6
{
    internal class DateTim
    {
        static void Main(string[] args)
        {
            //chemeburad dawerili pirveli davaleba
            #region exercise 1.
            //int number = int.Parse(Console.ReadLine());
            //int[] numbersArray = new int[number];
            //for (int i = 0; i < numbersArray.Length; i++)
            //{
            //    numbersArray[i] = i + 1;
            //}
            //foreach (double item in numbersArray)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------");
            //Console.WriteLine("Even");

            //int[] even = new int[number];
            //for (int j = 0; j < even.Length; j += 2)
            //{
            //    even[j] = j + 2;
            //}
            //foreach (int ev in even)
            //{
            //    Console.WriteLine(ev);
            //}

            //Console.WriteLine("-------");
            //Console.WriteLine("Odd");

            //int[] odd = new int[number];
            //for (int j = 0; j < odd.Length; j += 2)
            //{
            //    even[j] = j + 1;
            //}
            //foreach (int od in even)
            //{
            //    Console.WriteLine(od);
            //}

            #endregion


            //leqciaze axsnilis mixedvit dawerili.
            #region exercise 1.
            //Console.WriteLine("Enter array size: ");
            //int array_size = Convert.ToInt32(Console.ReadLine());
            //int[] arr1 = new int[array_size];
            //int[] arr2 = new int[array_size];
            //int[] arr3 = new int[array_size];
            //int i, evenindex = 0, oddindex = 0;
            //for (i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine($"Element - {i} : ");
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (i = 0; i < arr1.Length; i++)
            //{
            //    if (arr1[i] % 2 == 0)
            //    {
            //        arr2[evenindex] = arr1[i];
            //        evenindex++;
            //    }
            //    else
            //    {
            //        arr3[oddindex] = arr1[i];
            //        oddindex++;
            //    }
            //}
            //Console.WriteLine("\n Even elements: \n");
            //for (i = 0; i < arr1.Length; i++)
            //{
            //    if (arr2[i] != 0)
            //    {
            //        Console.WriteLine($"{arr2[i]}");
            //    }

            //}
            //Console.WriteLine($"\n Odd elements: \n");
            //for (i = 0; i < arr2.Length; i++)
            //{
            //    if (arr3[i] != 0)
            //    {
            //        Console.WriteLine($"{arr3[i]}");
            //    }

            //}
            #endregion

            //es titqmis gadawerilia leqciidan, magram tan viazreb, prosta ar vwer..
            #region exercise 2.
            //int[] myArr = new int[] { 1, 2,  4, 8, 3, 7, 0, 5, 7, 11, 15, 2, 4, 3, 11, 3, 8, 5, 0, 2, 7 };

            //var m = from x in myArr
            //        group x by x into y
            //        select y;

            //foreach(var element in m)
            //{
            //    Console.WriteLine( element.Key + "\t" + element.Sum() + "\t\t\t" + element.Count());
            //}
            //Console.WriteLine();
            #endregion

            //esec.
            #region exercise 3.
            //List<int> templist = new List<int>
            //{
            //    5,
            //    3,
            //    1,
            //    8,
            //    11,
            //    24,
            //    12,
            //    14,
            //    30
            //};
            //Console.WriteLine("How many records  you want to display? ");
            //int quantity = Convert.ToInt32(Console.ReadLine());
            //templist.Sort();
            //templist.Reverse();
            //foreach(int topn in templist.Take(quantity))
            //{
            //    Console.WriteLine(topn);
            //}
            #endregion
        }
    }
}