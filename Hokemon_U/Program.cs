using System;

namespace Hokemon_U
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring members
            Hinstinct[] ChallengerArray = new Hinstinct[3];
            Battle_Arena firstArena = new Battle_Arena(); // INSTANTIATED Battle_Arena

            Random rnd = new Random(); // Instantiating the rnd object

            bool repeatGame = true;
            string result;

            Console.WriteLine("Hello World");
            /*
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

            hokeObject01.About();
            hoke02.About();
*/
/*
            Hokemon hoke04 = new Hokemon();
            hoke04.get_details();
*/
            Halor playerHokemon01 = new Halor(); // INSTANTIATION from Halor Class
            playerHokemon01.get_details();
            //Demonstrating POLYMORPHISM with about method
            // Hokemon instance hoke04 + halor instance halohokemon01

            //NPC Hokemon

            for (int i = 0; i < ChallengerArray.Length; i++) 
            {
                ChallengerArray[i] = new Hinstinct(); // INSTANTIATING Challenger Hokemon
            }

            while (repeatGame == true)
            {
                playerHokemon01.About();

                firstArena.ChallengeMe(playerHokemon01);


                firstArena.Battle(playerHokemon01, ChallengerArray[rnd.Next(0, ChallengerArray.Length)]); //passing two objects into the firstArena

                Console.WriteLine("Do you want to repeat the game? (y/n)");
                result = Console.ReadLine();
                if (result.ToLower()[0]== 'n')
                {
                    repeatGame = false;
                }

            }


           // hoke04.About();
           // haloHokemon01.About();

              

            //Battle_Arena firstArena = new Battle_Arena(); //INSTANTIATED Battle_Arena

            
            //firstArena.ChallengeMe(haloHokemon01);

            //firstArena.ChallengeAccepted(haloHokemon01, hoke02); //passing two objects into the firstArena

            //firstArena.RequestAChallenger(HokeObject01); // ARGUMENT HokeObject01
            // passed into the 
            // firstArena object
            // method Req....
            //firstArena.AcceptingTheBattle(HokeObject01, Hoke02);

            //firstArena.Battle(haloHokemon01, hoke02); <-- code changed so we could add in an array, but this works also
            //firstArena.Battle();
        }
    }
}
