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


        public void theBattle(Hokemon attacker, Hokemon defender)
        {

            int round = 0;
            int attackValue = 0;
            int defenceValue = 0;
            Hokemon tempHoke;

            Console.WriteLine("{0}: waits for an opponent", attacker.Name);
            System.Threading.Thread.Sleep(1000); // Wait statement for 2 seconds
            Console.WriteLine("{0}: I accept the request of the battle", defender.Name);

         
            attacker.get_details();
            defender.get_details();

            Console.WriteLine("*** BATTLE START ***\n");

            while (Convert.ToInt32(defender.Health) >= 0 || Convert.ToInt32(attacker.Health) >= 0)
            {
                round += 1;
                attackValue = attacker.attackCalculator();
                defenceValue = defender.defenceCalculator();

                Console.WriteLine("*** ROUND {0} ***\n\n", round);

                for (int i = 0; i < 2; i++)
                {
                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds

                    Console.WriteLine("{0}: starts an attack ...", attacker.Name);
                    System.Threading.Thread.Sleep(1000); // Wait statement for 2 seconds
                    Console.WriteLine("{0}: Attack value: {1}...\n\n", attacker.Name, attackValue);
                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
                    Console.WriteLine("{0}: creates a defense with a value of: {1}", defender.Name, defenceValue);
                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
                    Console.WriteLine("{0}: has taken damage! : (HEALTH {1} + Defence {2}) = {3} - Attack {4}\n", defender.Name, defender.Health, defenceValue, (defender.Health + defenceValue), attackValue);
                    defender.Health = (defender.Health + defenceValue) - attackValue;
                    Console.WriteLine("{0} Health: {1} ", defender.Name, ((defender.Health + defenceValue) - attackValue));

                    
                 
              
                    Console.WriteLine("\n****\nSwitching sides \n****\n");
                    tempHoke = attacker;
                    attacker = defender;
                    defender = tempHoke;
                }
            }

            if (attacker.Health > defender.Health)
            {
                Console.WriteLine("{0}: WINS", attacker.Name);  
            }
            else
            {
                Console.WriteLine("{0}: WINS", defender.Name);  
            }

            Console.WriteLine("Would you like to play another game?");
            bool repeatGame.Console.ReadLine();

        }

    }
}
