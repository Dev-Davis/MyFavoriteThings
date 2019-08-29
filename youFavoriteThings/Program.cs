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

            var life1 = new Life
            {
                Bio = "I am a developing software developer",
                Hobbies = "Making music and learning development",
                Goals = "To get a career away from my shitty job"
            };

            var life2 = new Life
            {
                Bio = "I am a developing music engineer",
                Hobbies = "Making music and roller skating",
                Goals = "To get a career away from my shitty job also"
            };

            var movie1 = new Movies
            {
                Name = "Clifford",
                Genre = "Comedy",
                Description = "Not about the big red dog"
            };

            var movie2 = new Music
            {
                Artist = "How High",
                Song = "Comedy",
                Genre = "A movie about getting high with Redman and Method Man"
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

            var life = new List<Life>();
            foreach (var l in life)
            {
                Console.WriteLine(l);
            }
        }
    }
}
