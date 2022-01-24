using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9_exercise2
{
    public class Student
    {
        public string Name { get; set; }

        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
    }
    class GoodStudent : Student
    {
         public override void Study()
         {
            Console.WriteLine($"{Name} is good person.");
         }
        public override void Read()
        {
            Console.WriteLine($"{Name} is good person.");
        }
        public override void Write()
        {
            Console.WriteLine($"{Name} is good person.");
        }
    }

    class LazyStudent : Student
    {
        public override void Relax()
        {
            Console.WriteLine($"{Name} is not good enough.");
        }

    }
}
