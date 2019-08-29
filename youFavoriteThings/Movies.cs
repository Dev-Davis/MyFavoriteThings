using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings
{
    class Movies
    {
        // Properties
        public string Genre { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void Watch()
        {
            Console.WriteLine("Let go watch that movie...");
        }

        public void Rate()
        {
            Console.WriteLine("That movie sucked...");
        }
    }
}
