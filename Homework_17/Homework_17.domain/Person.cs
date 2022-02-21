using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_17.domain
{
    public class Person
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobPosition { get; set; }
        public string WorkExperience { get; set; }
        public decimal Salary { get; set; }
        public Adress Adresses { get; set; }

    }
}
