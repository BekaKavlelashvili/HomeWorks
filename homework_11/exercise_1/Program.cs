using System;
using System.IO;
using System.Xml;

namespace exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(temp, "file.txt");
            bool fileExist = File.Exists(path);
            if (fileExist)
            {
                //Console.WriteLine("File is exist!");
            }
            else
            {
                using (File.Create(path));
                Console.WriteLine("File does not exist.");
            }

            Console.WriteLine("How many lines do you want in text file ? ");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter some text :");
            int[] vs = new int[lines];
            for (int i = 0; i < vs.Length; i++)
            {
                string content = Console.ReadLine();
                File.WriteAllText(path, content);
            }
            Console.WriteLine("It's last line's content: ");
            StreamReader streamReader = File.OpenText(path);
            Console.WriteLine(streamReader.ReadToEnd());
        }
    }
}
