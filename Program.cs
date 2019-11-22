using System;

namespace inheritancePractice
{
    // Base class -Parent class
    public class modeOfTransportation
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vroom!");
        }
    }
    public class Zero : modeOfTransportation
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }
        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine("Zrooooom!!");
        }
    }
    public class Cessna : modeOfTransportation
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public void RefuelTank() { }
    }
    public class Tesla : modeOfTransportation
    {  // Electric car
        public double BatteryKWh { get; set; }
        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine("zzZZZZzzzz");
        }
    }
    public class Ram : modeOfTransportation
    {  // Gas powered truck
        public double FuelCapacity { get; set; }
        public void RefuelTank() { }

        // public override string ToString()
        // {
        //     Console.WriteLine("this is what happens when you override tostring");
        // }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var zero = new Zero();
            var tesla = new Tesla();
            var cessna = new Cessna();
            var ram = new Ram();

            zero.MainColor = "White";
            tesla.MaximumOccupancy = 5;

            cessna.Drive();
            tesla.Drive();
            zero.Drive();
            ram.Drive();

            // Console.WriteLine(ram);
        }
    }
}
