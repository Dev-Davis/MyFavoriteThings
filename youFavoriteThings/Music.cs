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

        public void Listen()
        {
            Console.WriteLine("Where's my phone?");
        }
    }
}
