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
        }
    }
}
