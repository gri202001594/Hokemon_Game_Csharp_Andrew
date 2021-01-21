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

        public void Battle(Hokemon Attacker, Hokemon Defender) //passing in two parameters
        {
            Hokemon tempHoke;

            while (Convert.ToInt32(Attacker.Health) >= 0 || Convert.ToInt32(Defender.Health) >= 0)
            {
                int attackValue = Attacker.attackCalculator();
                int defenceValue = Defender.defenceCalculator();
                int round = 0;
                round = round + 1;
                if (Attacker.Health < Defender.Health)
                {
                    Console.WriteLine("{0} WINS", Attacker.Name);
                    
                }
                else
                {
                    Console.WriteLine("{0} WINS", Defender.Name);

                }

                Console.WriteLine("\n*****ROUND {0}*****\n", round);
                for (int i = 0; i < 2; i++) {
                    Console.WriteLine("{0}: Attacks with the value {1} ", Attacker.Name, attackValue);
                    //defenders defence
                    Console.WriteLine("{0}: defends with value {1}", Defender.Name, defenceValue);
                    Console.WriteLine("{0}: health = {1}", Defender.Name, Defender.Health);
                    //calculate the impact of the attack on defenders health
                    Defender.Health = (Defender.Health + defenceValue) - attackValue;

                    Console.WriteLine("{0}: New health value = {1} //Calc: [{1}+{2}-{3}]", Defender.Name, Defender.Health, defenceValue, attackValue);
                    Console.WriteLine("\n\n***switching turns***");
                    //important
                    tempHoke = Attacker; //tempHoke is assigned the attacker object
                    Attacker = Defender;
                    Defender = tempHoke;

                        }
            }
        }
    }
}
