using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings
{
    class Life
    {
        // Properties
        public string Bio { get; set; }
        public string Hobbies { get; set; }
        public string Goals { get; set; }

        //Methods
        public void Live()
        {
            Console.WriteLine("Living my best life...");
        }

        public void Die()
        {
            Console.WriteLine("Dying my best death...");
        }
    }
}
