using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGame
{
    class Hinstinct : Hokemon
    {
        public string HinstinctTeam = "Halor";
        public void about() //using polymorphism to change method inherited from hokemon parent class
        {
            Console.WriteLine("I am {0}, part of team {1}!!", Name, HinstinctTeam);
        }
    }
}


