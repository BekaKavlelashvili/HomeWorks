using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task number: ");
            var taskNum = Console.ReadLine();
            if (taskNum == "task1")
            {
                task1();

            }
            else
            {
                if (taskNum == "task2")
                {
                    task2();
                }
                else
                {
                    if (taskNum == "task3")
                    {
                        task3();
                    }
                    else
                    {
                        if (taskNum == "task4")
                        {
                            task4();
                        }
                        else
                        {
                            if (taskNum == "task5")
                            {
                                task5();
                            }
                            else
                            {
                                if (taskNum == "task6")
                                {
                                    task6();
                                }
                                else
                                {
                                    if (taskNum == "task7")
                                    {
                                        task7();
                                    }
                                    else
                                    {
                                        if (taskNum == "task8")
                                        {
                                            task8();
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }


        }
        // leqciaze gasaketebeli davaleba iwyeba aq 
        static string task1()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your lastName: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your date of birth: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int age = DateTime.Now.Year - birthYear;
            Console.WriteLine("-------------------");
            Console.WriteLine(name + lastName + " is " + age + " years old.");
            return name + lastName + "is" + age;
        }

        //TODO: ver davassrule;
        static void task2()
        {

            Console.WriteLine("Enter password: ");
            int[] passMaxArr = new int[6];
            int[] passMinArr = new int[4];

            int userPass = Convert.ToInt32(Console.ReadLine());
            for (int i = passMinArr.Length; i <= passMaxArr.Length; i++)
            {
                if (userPass >= passMinArr.Length && userPass <= passMaxArr.Length)
                {
                    Console.WriteLine("your password is correct");
                }
                else
                {
                    Console.WriteLine("Your password is  not correct. Please, try again!");
                }
            }





        }

        static int task3()
        {
            Console.WriteLine("Enter x value :");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value :");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter math operation :");
            string N = Console.ReadLine();
            if (N == "sum")
            {
                Console.WriteLine(x + y);
            }
            else
            {
                if (N == "multiplication")
                {
                    Console.WriteLine(x * y);
                }
                else
                {
                    if (N == "subtraction" && x > y)
                    {
                        Console.WriteLine(x - y);
                    }
                    else
                    {
                        if (N == "subtraction" && x < y)
                        {
                            Console.WriteLine(y - x);
                        }
                        else
                        {
                            if (N == "devide" && x > y && y != 0 && x != 0)
                            {
                                Console.WriteLine(x / y);
                            }
                            else
                            {
                                if (N == "devide" && y > x && y != 0 && x != 0)
                                {
                                    Console.WriteLine(y / x);
                                }
                                else
                                {
                                    if (N == "devide" && x == 0 || y == 0)
                                    {
                                        Console.WriteLine("---------------------------");
                                        Console.WriteLine("Not Able To Devide By Zero!");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return x;
        }
        // da mtavrdeba aq.

        //aqedan iwyeba saxlshi gasaketebeli davalebebi.
        static void task4()
        {
            int count = 1;
            Console.WriteLine("Enter min number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max number :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  Nth degree: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] c = new int[b];
            for (int i = 0; i <= b; i++)
            {
                if (Math.Pow(i, n) >= a && Math.Pow(i, n) <= b)
                {
                    Console.WriteLine("--------------");
                    count++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"raodenoba : {count}");

        }

        //TODO : ver davamtavre;
        static string task5()
        {
            Console.WriteLine("Enter your lost socks:");
            string sock = Console.ReadLine();
            string[] pairSock = new string[] { "AA", "BB", "CC", "DD" };
            for (var i = 0; i < pairSock.Length; i++)
            {
                if (sock == pairSock[i] || sock == pairSock[i + 1])
                {
                    Console.WriteLine("Congratulation, we found your socks!");
                }
                else
                {
                    Console.WriteLine("Sorry, search is unsuccessful :(");
                }
            }
            return sock;
        }

        static string task6() //ragac ver jdeba 
        {
            Console.WriteLine("Add first word:");
            string first = Console.ReadLine();
            Console.WriteLine("Add second word:");
            string second = Console.ReadLine();
            string[] f = new string[] { first };
            string[] s = new string[] { second };

            while (f.Length - 1 != s.Length - 1)
            {
                Console.WriteLine(f.Length - 1);

            }
            return first;
        }

        static void task7() //booleanze ver gavakete.
        {
            Console.WriteLine("Add word: ");
            string srg = Console.ReadLine();
            List<string> srg1 = new List<string>() { srg };
            if (srg1.Count != 0)
            {
                Console.WriteLine(srg.ToUpper());

            }

            Console.WriteLine("Add some number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add some number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int[] numArr = new int[] { num1, num2 };
            if (numArr.Length != 0)
            {
                Console.WriteLine(num2 + num1);
            }

            Console.WriteLine("Add some boolean words: ");
            string question = Console.ReadLine();
            




        }

        static int task8() //n-s ver vanawevreb.
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 10)
            {
                Console.WriteLine(n);
                return n;
            }
            else
            {
                int l = n % 5;
                Console.WriteLine(n % 5 + "-");
                return l;
            }
        }
    }
}

