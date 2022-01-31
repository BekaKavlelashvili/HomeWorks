using System;

namespace homework_11
{
    public class Multiplication
    {
        public void Method()
        {
            Console.WriteLine("It's multiplication table.\nEnter some number: ");
            int sum = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            int num = 0;

            while (num < 9)
            {
                num++;
                sum = N * num;
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
