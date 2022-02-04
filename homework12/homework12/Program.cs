using System;
using System.IO;
namespace homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           VictorianFurniture victorianFurniture = 


        }

    }


    //skamebi 
    public interface Chair
    {
        public void HasLegs();
        public void SitOn();
    }

    public abstract class VictorianChair : Chair
    {
        public void HasLegs() { }
        public void SitOn() { }
    }
    public abstract class ModernChair : Chair
    {
        public void HasLegs() { }
        public void SitOn() { }
    }
    public abstract class ArtDecoChair : Chair
    {
        public void HasLegs() { }
        public void SitOn() { }
    }
    //magidebi
    public interface Table
    {
        public void HasLegs();
    }
    public abstract class VictorianTable : Table
    {
        public void HasLegs() { }
    }
    public abstract class ModernTable : Table
    {
        public void HasLegs() { }
    }
    public abstract class ArtDecoTable : Table
    {
        public void HasLegs() { }
    }
    //divani 
    public interface Sofa
    {
        public void HasLegs();
        public void SitOn();
    }
    public abstract class VictorianSofa : Sofa
    {
        public void HasLegs() { }
        public void SitOn() { }
    }
    public abstract class ModernSofa  : Sofa
    {
        public void HasLegs() { }
        public void SitOn() { }
    }
    public abstract class ArtDecoSofa : Sofa
    {
        public void HasLegs() { }
        public void SitOn() { }
    }


    public interface FurnitureFactory
    {
        public void CreateChair(Chair chair)
        {
            chair.SitOn();
            chair.HasLegs();
            Console.WriteLine($"Your order is {chair}, it's ready!");
        }
        public void CreateCoffeeTable(Table table)
        {
            table.HasLegs();
            Console.WriteLine($"Your order is {table}, it's ready!");
        }
        public void CreateSofa(Sofa sofa)
        {
            sofa.HasLegs();
            sofa.SitOn();
            Console.WriteLine($"Your order is {sofa}, it's ready!");
        }
    }
    public abstract class VictorianFurniture : FurnitureFactory
    {
        public void CreateChair(Chair VictorianChair) { }
        
        public void CreateCoffeeTable(Table VictorianTable) { }
        public void CreateSofa(Sofa VictorianSofa) { }
    }

    public abstract class ModernFurniture : FurnitureFactory
    {
        public void CreateChair(Chair ModernChair) { }
        public void CreateCoffeeTable(Table ModernTable) { }
        public void CreateSofa(Sofa ModernSofa) { }
    }
    public abstract class ArtDecoFurniture : FurnitureFactory
    {
        public void CreateChair(Chair ArtDecoChair) { }
        public void CreateCoffeeTable(Table ArtDecoTable) { }
        public void CreateSofa(Sofa ArtDecoSofa) { }
    }

    public class Client 
    {
        //aq gavichede da agarc gamomivida sabolood ra.
        private Chair chair;
        private Table table;
        private Sofa sofa;
        public Client(FurnitureFactory factory)
        {
            chair = factory.CreateChair(chair);
        }
    }
}
