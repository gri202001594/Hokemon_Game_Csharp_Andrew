using System;

namespace PokemonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of Hokemon!");
            Hokemon HokeObject01 = new Hokemon();
            HokeObject01.get_details();
            //Console.WriteLine("The attack value is: {0}", HokeObject01.attackCalculator());
            //Console.WriteLine("The defense value is: {0}", HokeObject01.defenceCalculator());


            System.Threading.Thread.Sleep(1000);//sleepsfor1second
            //create a second hokemon




            //Hokemon HokeObject02 = new Hokemon();
            //HokeObject02.get_details();
           // Hokemon hokemonObject = new Hokemon();
            //hokemonObject.get_details();



            Hokemon hoke03 = new Hinstinct();
            Console.WriteLine("I am part of {0} team.", hoke03.HinstinctTeam); // tried to get another team involved
            // INSTANTIATE from Hokemon Parent class

            Halor hoke04 = new Halor(); // INSTANTIATE from Halor child class
            Console.WriteLine("I am part of {0} team.", hoke04.Halorteam);



            Battle_Arena newBattleObject = new Battle_Arena();

            newBattleObject.RequestAChallenger(hoke03);  

            newBattleObject.theBattle(hoke03, hoke04);





            // Halor halorHoke01 = Hokemon HokeObject02();
            //hoke04.about();
            //halorHoke01.about();
            // halorHoke01.get_details();


            //|| = or
            //polymorphism is when a method inherited is able to be repurposed


        }
    }
}
