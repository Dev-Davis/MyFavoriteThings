using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings
{
    class Hats
    {
        //Properties
        public string Type { get; set; }
        public string Brim { get; set; }

        // Methods
        public void Wear()
        {
            Console.WriteLine("What hat will I wear today?");
        }

        public void Adjust()
        {
            Console.WriteLine("How should I wear my hat today?");
        }
    }
}
