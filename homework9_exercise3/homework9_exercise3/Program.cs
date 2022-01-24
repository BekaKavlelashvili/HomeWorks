using System;

namespace homework9_exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();           
            Console.WriteLine(student.RandomSubject());
            student.Name = "vasiko";
            student.age = 22;
            Console.WriteLine("Enter the year of enrollment in the university:");
            student.yearOfPass = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("It,s your time from graduation: ");
            Console.WriteLine(student.YearsFromGraduation());  

        }
    }
}
