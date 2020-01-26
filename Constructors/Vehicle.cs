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
}