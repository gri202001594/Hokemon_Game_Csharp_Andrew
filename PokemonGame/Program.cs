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
            System.Threading.Thread.Sleep(1000);//sleepsfor1second
            //create a second hokemon
            Hokemon HokeObject02 = new Hokemon();
            HokeObject02.get_details();
            Battle_Arena firstArena = new Battle_Arena(); // creating/instantiating the object firstArena from the Battle_Arena CLASS
            firstArena.RequestAChallenger(HokeObject01);
            firstArena.AcceptingTheBattle(HokeObject01, HokeObject02);
            HokeObject01.about();
            HokeObject02.about();
            Hokemon hoke04 = new Hokemon();
            Halor halorHoke01 = new Halor();
            hoke04.about();
            halorHoke01.about();
            halorHoke01.get_details(); //|| = or
            //polymorphism is when a method inherited is able to be repurposed

            
        }
    }
}
