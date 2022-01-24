using System;

namespace homework9_exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GoodStudent GoodStudent = new GoodStudent();
            GoodStudent.Name = "Giorgi";
            GoodStudent.Study();

            GoodStudent.Name = "revazi";
            GoodStudent.Write();

            GoodStudent.Name = "Tamazi";
            GoodStudent.Read();

            LazyStudent lazyStudent = new LazyStudent();
            lazyStudent.Name = "Nika";
            lazyStudent.Relax();

            classRoom classRoom = new classRoom("Salo");
            classRoom.Read();

        }
    }
}
