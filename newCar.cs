using System;

namespace delegates.Events
{
    public class newCar
    {
        public event EventHandler ColourChanged;
        public string Colour { get; set;}
        public newCar(string makeOfCar)
        {
            Make = makeOfCar;
        }
        public string setCarColour(string colour)
        {

             if(colour != null)
             {
                this.Colour = colour;
                ColourChanged?.Invoke(this, new EventArgs()); 
             }
             return colour;
        } 
        private string Make { get; set;}
    }
}