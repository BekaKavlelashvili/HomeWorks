using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_17.domain
{
    public class Adress
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Homenumber { get; set; }
    }
}
