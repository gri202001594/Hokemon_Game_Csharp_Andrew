using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGame
{
    class Battle_Arena
    {
        public Battle_Arena()//constructor method - nnotice same name as class, runs first when object instantiated
        {
            Console.WriteLine("*****WELCOME TO THE BATTLE ARENA*****");
        }

    public void RequestAChallenger(Hokemon contender)
        {
            Console.WriteLine("{0}: announces that they wish to battle", contender.Name);
        }
        //class is like a blueprint, instantiation is the creation of an object from a class.
    public void AcceptingTheBattle(Hokemon contendor1, Hokemon contendor2)
        {
            Console.WriteLine("{0}: 'announces that they have accepted the battle request of {1}'", contendor2.Name, contendor1.Name);
        }
    }
}
