using Intuit.Ipp.Data;
using System;
using System.IO;
using System.Xml;

namespace homework_11
{
    internal class Program
    {
        static void Main(string[] args) // xml fileshi integer mnishvnelobas ver vamateb qvemot gamoyenebuli  metodit.
                                        // mxolod strings igebs.
        { 
            var xmlFile = @"C:\Users\Beka\source\repos\homework_11\homework_11\XMLFile1.xml";
            //Multiplication multiplication = new Multiplication();
            //multiplication.Method();

            Console.WriteLine("It's multiplication table.\nEnter some number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            int sum = N * num;

            while (num < 9)
            {
                num++;
                sum = N * num;
                File.WriteAllText(xmlFile, "sum");//aq shemeqmna problema. 
                Console.WriteLine(N + "*" + num + "=" + (sum));
            }
            Console.WriteLine("=====================");
            while (N > 0)
            {
                N--;
                if (N != 0)
                {
                    num = 0;
                    while (num < 9)
                    {
                        num++;
                        sum = N * num;
                        Console.WriteLine(N + "*" + num + "=" + (sum));
                    }
                    Console.WriteLine("=====================");
                }
            }
        }
    }
}
