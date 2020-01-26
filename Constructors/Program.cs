using System;

namespace Constructors
{
    public class Vehicle
    {
        private string RegistrationNumber { get; set; }

        public Vehicle(string registrationNumber)
        {

            this.RegistrationNumber = registrationNumber;
            Console.WriteLine("vehicle is being initialized{0} ", registrationNumber);
        }
    }

    public class Car : Vehicle
    {
        public string RegistrationNumber { get; set; }
        public Car(string registrationNumber): base(registrationNumber)
        {
            this.RegistrationNumber = registrationNumber;
            Console.WriteLine("car is being initialized{0}",registrationNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(" XYZ2134");
        }
    }
}
