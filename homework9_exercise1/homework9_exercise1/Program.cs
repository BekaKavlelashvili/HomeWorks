using System;

namespace homework9_exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Employee();
            manager.name = "manager";
            manager.lastname = "manageridze";
            manager.age = 25;
            manager.position = "manager";
            Console.WriteLine("It's Manager's salary:");
            Console.WriteLine(manager.CalculateSalary(EmployeeType.manager));

            Employee developer = new Employee();
            developer.name = "devo";
            developer.lastname = "devoshvili";
            developer.age = 20;
            developer.position = "developer";
            Console.WriteLine("It's Developer's salary:");
            Console.WriteLine(developer.CalculateSalary(EmployeeType.developer));

            Employee tester = new Employee();
            tester.name = "Test";
            tester.lastname = "Testidze";
            tester.age = 30;
            tester.position = "tester";
            Console.WriteLine("It's Tester's salary:");
            Console.WriteLine(tester.CalculateSalary(EmployeeType.tester));

            Employee other = new Employee();
            other.name = "other";
            other.lastname = "otherishvili";
            other.age = 40;
            other.position = "other";
            Console.WriteLine("It's Other's salary:");
            Console.WriteLine(other.CalculateSalary(EmployeeType.other));

            company sum_of_salary = new company();
            Console.WriteLine("It's deghege: ");
            sum_of_salary.deghege();
        }
    }
}
