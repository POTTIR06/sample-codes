
using System;
 
namespace ClassExample
{
    // Car class
    public class Car
    {
        // Data members
        public string brand = "Hyundai";
        public string model = "Creta";
        public string color = "Red";
        public int topSpeed = 165;

        public void CarDetails()
        {
            Console.WriteLine($"Brand:{brand} Model:{model} Color: {color}: Speed:{topSpeed}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of the Car class
            Car carObj = new Car();
            Console.WriteLine("Print Car Details");
            carObj.CarDetails();

        }
    }
}