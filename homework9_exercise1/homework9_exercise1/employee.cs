using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9_exercise1
{
    enum EmployeeType
    {
        manager,
        developer,
        tester,
        other
    }
    internal class Employee
    {
        public string name;
        public string lastname;
        public int age;
        public string position;


        public double CalculateSalary(EmployeeType position)
        {
            int[] workWeek = new int[7];
            string[] weekDays = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            //menejeri
            if (true)
            {


                if (position == EmployeeType.manager)
                {
                    var add_on = 50;
                    var totalAdd = 0;
                    var normHours = 8;
                    var normRate = 40;
                    var overTime = 5;
                    var weekendRate = 80;
                    int totalNorm = 0;
                    int totalOverTime = 0;
                    for (int i = 0; i < weekDays.Length; i++)
                    {
                        Console.Write($"Enter the hours worked on {weekDays[i]}");
                        int hours = Convert.ToInt32(Console.ReadLine());
                        workWeek[i] = hours;
                    }
                    int totalWeekend = (workWeek.Length - 1 + workWeek.Length - 2) * weekendRate;
                    for (int i = 0; i < workWeek.Length - 2; i++)
                    {
                        totalNorm += workWeek[i] * normRate;
                        if (workWeek[i] > normHours)
                        {
                            totalOverTime += (workWeek[i] - normHours) * overTime;
                        }
                        if (workWeek[i] + workWeek[i + 1] > add_on)
                        {
                            totalAdd += (totalNorm + totalOverTime + totalWeekend) / 5;
                        }
                    }
                    int managerTotalSalary = totalNorm + totalOverTime + totalWeekend + totalAdd;
                    return managerTotalSalary;
                }

                //developeri
                if (position == EmployeeType.developer)
                {
                    var totalAdd = 0;
                    var add_on = 50;
                    var normHours = 8;
                    var normRate = 30;
                    var overTime = 5;
                    var weekendRate = 60;
                    int totalNorm = 0;
                    int totalOverTime = 0;

                    for (int i = 0; i < weekDays.Length; i++)
                    {
                        Console.Write($"Enter the hours worked on  {weekDays[i]}");
                        int hours = Convert.ToInt32(Console.ReadLine());
                        workWeek[i] = hours;
                    }
                    int totalWeekend = (workWeek.Length - 1 + workWeek.Length - 2) * weekendRate;
                    for (int i = 0; i < workWeek.Length - 2; i++)
                    {
                        totalNorm += workWeek[i] * normRate;
                        if (workWeek[i] > normHours)
                        {
                            totalOverTime += (workWeek[i] - normHours) * overTime;
                        }
                        if (workWeek[i] + workWeek[i + 1] > add_on)
                        {
                            totalAdd += (totalNorm + totalOverTime + totalWeekend) / 5;
                        }
                    }
                    int developerTotalSalary = totalNorm + totalOverTime + totalWeekend + totalAdd;
                    return developerTotalSalary;
                }

                //testeri
                if (position == EmployeeType.tester)
                {
                    var totalAdd = 0;
                    var add_on = 50;
                    var normHours = 8;
                    var normRate = 20;
                    var overTime = 5;
                    var weekendRate = 40;
                    int totalNorm = 0;
                    int totalOverTime = 0;

                    for (int i = 0; i < weekDays.Length; i++)
                    {
                        Console.Write($"Enter the hours worked on {weekDays[i]}");
                        int hours = Convert.ToInt32(Console.ReadLine());
                        workWeek[i] = hours;
                    }
                    int totalWeekend = (workWeek.Length - 1 + workWeek.Length - 2) * weekendRate;
                    for (int i = 0; i < workWeek.Length - 2; i++)
                    {
                        totalNorm += workWeek[i] * normRate;
                        if (workWeek[i] > normHours)
                        {
                            totalOverTime += (workWeek[i] - normHours) * overTime;
                        }
                        if (workWeek[i] + workWeek[i + 1] > add_on)
                        {
                            totalAdd += (totalNorm + totalOverTime + totalWeekend) / 5;
                        }
                    }
                    int testerTotalSalary = totalNorm + totalOverTime + totalWeekend + totalAdd;
                    return testerTotalSalary;
                }

                //other
                if (position == EmployeeType.other)
                {
                    var totalAdd = 0;
                    var add_on = 50;
                    var normHours = 8;
                    var normRate = 10;
                    var overTime = 5;
                    var weekendRate = 20;
                    int totalNorm = 0;
                    int totalOverTime = 0;

                    for (int i = 0; i < weekDays.Length; i++)
                    {
                        Console.Write($"Enter the hours worked on {weekDays[i]}");
                        int hours = Convert.ToInt32(Console.ReadLine());
                        workWeek[i] = hours;
                    }
                    int totalWeekend = (workWeek.Length - 1 + workWeek.Length - 2) * weekendRate;
                    for (int i = 0; i < workWeek.Length - 2; i++)
                    {
                        totalNorm += workWeek[i] * normRate;
                        if (workWeek[i] > normHours)
                        {
                            totalOverTime += (workWeek[i] - normHours) * overTime;
                        }
                        if (workWeek[i] + workWeek[i + 1] > add_on)
                        {
                            totalAdd += (totalNorm + totalOverTime + totalWeekend) / 5;
                        }
                    }
                    int otherTotalSalary = totalNorm + totalOverTime + totalWeekend + totalAdd;
                    return otherTotalSalary;
                }
                
                return CalculateSalary(EmployeeType.manager);
                return CalculateSalary(EmployeeType.developer);
                return CalculateSalary(EmployeeType.tester);
                return CalculateSalary(EmployeeType.other);
            }
            
        }
        public double TotalSalary()
        {
            CalculateSalary(EmployeeType.manager);
            CalculateSalary(EmployeeType.developer);
            CalculateSalary(EmployeeType.tester);
            CalculateSalary(EmployeeType.other);
            return TotalSalary();
        }
    }
}
