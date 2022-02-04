using System;

namespace exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainActor mainActor = new MainActor();
            Console.Write("Main Actor - ");
            mainActor.SimpleScene(false);
            Kaskadiori kaskadiori = new Kaskadiori();
            Console.Write("Kaskadiori - ");
            kaskadiori.HardScene(true);
        }
    }

    public interface IActor
    {
        public bool HardScene()
        {
            if (true)
                return true;
            else return false;
        }
        public bool SimpleScene()
        {
            if (true)
                return true;
            else return false;
        }
    }
    public class MainActor : IActor
    {
        public void SimpleScene(bool hard)
        {
            if (hard)
            {
                Console.WriteLine("I can't participate! ");
            }
            else
            {
                Console.WriteLine("I can participate! ");
            }

        }
    }

    public class Kaskadiori : IActor
    {
        public void HardScene(bool simple)
        {
            if(simple)
            Console.WriteLine("I can't participate! ");
            else Console.WriteLine("I can participate!");
        }
    }
}
