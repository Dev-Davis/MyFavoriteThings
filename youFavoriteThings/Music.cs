using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings
{
    class Music
    {
        public string Genre { get; set; }
        public string Artist { get; set; }
        public string Song { get; set; }

        //Methods
        public void SingAlong()
        {
            Console.WriteLine("Making my way downtown...");
        }

        public void Tracks()
        {
            Console.WriteLine("Who made this beat?");
        }

        public void Listen()
        {
            Console.WriteLine("Where's the aux cord?");
        }
    }
}
