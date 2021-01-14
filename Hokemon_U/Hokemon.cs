using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_U
{
    class Hokemon
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of Hokemon!");

            Hokemon hokeObject01 = new Hokemon();

            Console.WriteLine("Your Hokemon name is: {0}", hokeObject01.Name);

            //hokeObject.get_details(); <-- this will 
        }
    }
}
private string Name;
private int max_health;
private int attack;
private int speed;
private int defense;

public string Name
{
    get { return Name; } // access to the name attribute
    get { name = value; }
}

public int Health
{
    get { return Health; }
    set { Health = value; }

// METHODS

public Hokemon()    // CONSTRUCTOR METHOD
{
    provide_name();
    max_health = 100;
    health = random_int_generator(10, max_health);
    attack = random_int_generator(10, 100);
    speed = random_int_generator(10, 100);
    defense = random_int_generator(10, 100);
}


public void get_details() //get details METHOD
{
    Console.WriteLine("\n\n********\nName: {0}\n" + "Health: {1}/{2}\n" + "Attack value: {3}\n" + "Defense value: {5}", Name, Health, max_health, attack, speed, defense);

}

public int random_int_generator(int min_value, int max_value) // int min_value, int max_value are PARAMETERS
{
    Random rnd = new Random();  // Creating a new OBJECT called rnd this is an INSTANCE of RANDOM class

    int randomvalue;

    randomvalue = rnd.Next(min_value, max_value); //Using the NEXT method from the RANDOM class found in rnd OBJECT

    return randomvalue; 
}