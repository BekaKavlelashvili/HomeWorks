using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace exercise_3
{
    internal class Program
    {
        public static void Main()
        {
            var xmlPath = @"C:\Users\Beka\source\repos\homework_11\exercise_3\XMLFile1.xml";
            string str = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            int str_size = str.Length;
            int part_size = str_size / n; ;

            for (int i = 0; i < str_size; i++)
            {
                if (i % part_size == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(str[i]);
            }
        }

    }
}
