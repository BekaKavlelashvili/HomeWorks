using System;
using System.IO;
using System.Text.Json;

namespace exercise_4
{
    internal class Program
    {
        public class Date
        {
            public DateTime DateTime { get; set; }
        }
        static void Main(string[] args)
        {   
            //ase davtove ubralod, ki mushaobs magram json failshi ver vamateb integerebis shedegs
            //stringad agiqvams da gamoklebasac ar asrulebs shesabamisad. xmltanac msgavsi problema mqonda 
            //meore davalebashi. 
        
            var json = @"C:\Users\Beka\source\repos\homework_11\exercise_4\myFile.json";
            Date date = new Date();
            date.DateTime = new DateTime(2022,1,29);
            Console.WriteLine(DateTime.Today - date.DateTime);        
        }
        
    }
}
