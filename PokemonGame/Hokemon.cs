using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGame
{
    class Hokemon
    {
        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;


        //properties are a combination of a field and method
        // and allows us to perform checks on what is inputs

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Health
        {
            get { return health; }
            set
            {
                health = value;

                // health property is keeping of health
            }
        }
        public Hokemon()
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);
        }
        public void provide_name()
        {
            Console.WriteLine("Enter a name for your Hokemon");
            name = Console.ReadLine();
        }
        public void get_details()
        {
            Console.WriteLine("\n\nName: {0}\nHealth: {1}/{2}\nAttack: {3}\nSpeed: {4}\nDefense: {5}", Name, Health, max_health, attack, speed, defense);
        }
        public int random_int_generator(int min_value, int max_value)
        {
            Random rnd = new Random();
            int randomValue;
            randomValue = rnd.Next(min_value, max_value);
            return randomValue;
        }
    }
}

        