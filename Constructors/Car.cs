using System;

namespace Constructors
{
    public class Car : Vehicle
    {
        public string RegistrationNumber { get; set; }
        public Car(string registrationNumber): base(registrationNumber)
        {
            this.RegistrationNumber = registrationNumber;
            Console.WriteLine("car is being initialized{0}",registrationNumber);
        }
    }
}