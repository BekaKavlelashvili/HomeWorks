using System;

namespace exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //am logikit ar gamovida ashkarad.. 
            string[] word = { "S", "O", "M", "E" };
            int key = 3;
            string[] chars = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L",
                "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            for (var i = 0; i < chars.Length; i++)
            {
                for (var j = 0; j < word.Length; j++)
                {
                    if (word[j] ==  chars[i])
                    {
                        word[j] = chars[i + key];
                        Console.WriteLine(word); 
                    }
                }
            }
            //foreach (var items in chars)
            //{
            //    Console.WriteLine(items); ;
            //}

        }
    }
}

