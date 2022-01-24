using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9_exercise3
{
    internal class Student
    {
        public string Name;
        public int age;
        public int yearOfPass;

        public string RandomSubject()
        {
            List<string> subject = new List<string>()
            {
                "Math",
                "Chemistry"
            };

            Random rand = new Random();
            int index = rand.Next(subject.Count);
            string randomSubject = subject[index];

            if (randomSubject == "Math")
            {
                int x = rand.Next(50);
                int y = rand.Next(50);
                Console.WriteLine($"{x} + {y} = {x + y}");
            }
            else
            {
                if (randomSubject == "Chemistry")
                {
                    Console.WriteLine("\n Chemical Formula :\n H2SiO3");
                }
            }
            return randomSubject;
        }

        public int YearsFromGraduation()
        {
            int StudyTime = 4;
            int remainingTime = StudyTime - (DateTime.Now.Year - yearOfPass);

            if (remainingTime < 0)
            {
                Console.WriteLine("You have already graduated from university!");

            }
                return remainingTime;
            

        }


    }
}
