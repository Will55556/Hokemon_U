using System;

namespace Hokemon_U
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");

            Hokemon hokeObject01 = new Hokemon(); //INSTANTIATION of object hokeObject01

            Console.WriteLine("Welcome to the world of Hokemon!");

            //Console.WriteLine("Your Hokemon name is: {0}", hokeObject01.Name);

            hokeObject01.get_details();

            Hokemon hoke02 = new Hokemon();  //INSTANTIATION of object 2
            
            
            Console.WriteLine("Name of Hokemon:{0}",hoke02.Name);
            Console.WriteLine("********");
            Console.WriteLine("****Details below***");
            hoke02.get_details();

            Hokemon hoke03 = new Hokemon(); // INSTANTIATION of object 3
            
            //Console.WriteLine("Name of Hokemon:{0}", hoke03.Name);
            
            hoke03.get_details();

              

            Battle_Arena firstArena = new Battle_Arena(); //INSTANTIATED Battle_Arena

            
            firstArena.ChallengeMe(hokeObject01);

            firstArena.ChallengeAccepted(hokeObject01, hoke03); //passing two objects into the firstArena

            attackValue = attacker.attackCalc();
            defenceValue = defender.defenceCalc();

            while(Convert.ToInt32(defender.Health) >= 0 || Convert.ToInt32(attacker.Health) >=0)
            { }

            Defender.Health = (Defender.Health

            //LOOP:
            for (int i = 0; i < 2; i++)
            {

            }

            //hoke02.about();
            //HalorHokemon01.Aboutt();
        }
    }
}
