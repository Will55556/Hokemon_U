using System;

namespace Hokemon_U
{
    class Hokemon
    {

        private string name;
        private int max_health;
        private int health;
        private int attack;
        private int speed;
        private int defense;
        private string team = "Hokemon";

        public string Name
        {
            get { return name; } // access to the name attribute
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        // METHODS

        public Hokemon()    // CONSTRUCTOR METHOD
        {
            provide_name();
            max_health = 100;
            health = Random_int_generator(10, max_health);
            attack = Random_int_generator(10, 100);                         //going to have to change this - if statement with console.readlines. (this means changing in program.cs)
            speed = Random_int_generator(10, 100);                          //Set stats based on pokemon name e.g if name == harizard: health = x etc.. (this is changed in here)
            defense = Random_int_generator(10, 100);                        // that means commenting out the random int generator since that wont matter unless im going to do ranges for attacks.
        }                                                                   //see below for random int gen. 

        public void provide_name() // METHOD
        {
            Console.WriteLine("What Hokemon do you want?");
            name = Console.ReadLine();
        }

        public void get_details() //get details METHOD
        {
            Console.WriteLine("\n\n********\nName: {0}\n" + "Health: {1}/{2}\n" + "Attack value: {3}\n" + "Defense value: {5}", name, Health, max_health, attack, speed, defense);

        }

        public int Random_int_generator(int min_value, int max_value) // int min_value, int max_value are PARAMETERS
        {
            Random rnd = new Random();  // Creating a new OBJECT called rnd this is an INSTANCE of RANDOM class

            int randomvalue;

            randomvalue = rnd.Next(min_value, max_value); //Using the NEXT method from the RANDOM class found in rnd OBJECT

            return randomvalue;
        }

        public void About()
        {
            Console.WriteLine("hi");
        }

        public int attackCalc()
        {
            int attackValue;
            // Calcing an attack when hokemon uses move
            attackValue = (attack);

            return attackValue;
        }

        public int defenceCalc()
        {
            int defenceValue;
            //calcing resistance to damage
            defenceValue = (defense);

            return defenceValue;
        }
        

    }
}




