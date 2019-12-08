using System;

namespace delegates.Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCar = new newCar("Fiat");

            newCar.ColourChanged += OnColourChanged;

            var carColour = newCar.setCarColour("Blue");

            // Prove that the static method OnColourChanged and the event are linked by writing out "Logging: The Colour has been changed!"

            Console.WriteLine($"The colour of the car is {carColour}");
        }

        static void OnColourChanged(Object sender, EventArgs e )
        {
            System.Console.WriteLine("Logging: The Colour has been changed!");
        }
    }
}
