using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGame
{
    class Halor : Hokemon
    {
        private string team = "Halor";
        public void about() //using polymorphism to change method inherited from hokemon parent class
        {
            Console.WriteLine("I am {0}, part of team {1}!!", Name, team);
        }
    }
}
