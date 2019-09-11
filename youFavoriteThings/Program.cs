using System;
using System.Collections.Generic;
using YourFavoriteThings;

namespace youFavoriteThings
{
    class Program
    {
         
        static void Main(string[] args)
        {
            var hat1 = new Hats
            {
                Name = "Doggystyle",
                Type = "Snapback",
                numberInCollection = 88
            };

            var hat2 = new Hats
            {
                Name = "Death Row Records",
                Type = "Snapback",
                numberInCollection = 89
            };

            var skate1 = new RollerSkating
            {
                Boot = "Riedell 220 Boots",
                Plates = "Sure Grip Avanti Aluminum Plate",
                Wheels = "Sure-Grip FoMac Premier Mini Mac roller skate wheels 45mm"

            };

            var skate2 = new RollerSkating
            {
                Boot = "Riedell OG Rhythm Boots",
                Plates = "Sure-Grip Competitor Quad Skate Plate Plates",
                Wheels = "Radar Varsity Plus Skate Wheels Black 57mm 8 set"
            };

            var movie1 = new Movies
            {
                Name = "Clifford",
                Genre = "Comedy",
                Description = "Not about the big red dog"
            };

            var movie2 = new Movies
            {
                Name = "How High",
                Genre = "Comedy",
                Description = "A movie about getting high with Redman and Method Man"
            };

            var music1 = new Music
            {
                Song = "Hit Em' Up",
                Artist = "2pac",
                Genre = "The hardest diss song in history"
            };

            var music2 = new Music
            {
                Song = "What's Yo Name",
                Artist = "T.I.",
                Genre = "The song that introduced me to T.I."
            };

            Console.WriteLine($"This is a {hat1.Name}, after Snoop Dogg's first album.");
            Console.WriteLine($"This is a {hat2.Name} hat.");
            Console.WriteLine($"The {skate1.Boot} were my first pair of good skates.");
            Console.WriteLine($"The {skate2.Boot} are my current skates, and I love them.");
            Console.WriteLine($"Have you seen {movie1.Name}? Not the big red dog.");
            Console.WriteLine($"{movie2.Name} is my movie. Don't know how good part 2 is though.");
            Console.WriteLine($"{music1.Artist} is the meanest diss record in history.");
            Console.WriteLine($"I was introduced to {music2.Artist} back in 2001 when I heard {music2.Song}. Still my favorite song by him to this day.");
        }
    }
}
