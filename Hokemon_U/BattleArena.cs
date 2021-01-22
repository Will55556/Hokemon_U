using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace Hokemon_U
{
	class Battle_Arena
	{
		public Battle_Arena() // CONSTRUCTOR method runs 1st.
		{
			Console.WriteLine("Welcome to the battle arena !!");
		}

		public void ChallengeMe(Hokemon hokeChallenge)  // Passing a Hoke Object into Method
														//to use in the method
		{

			Console.WriteLine("{0}: says ' I want a BATTLE!'", hokeChallenge.Name);

		}

		public void ChallengeAccepted(Hokemon Challenger, Hokemon Accepter)
		{
			Console.WriteLine("{0}: 'I accept your challenge for a fight'" +
				"Come on then {1} lets RUMBLE!!", Accepter.Name, Challenger.Name);
		
		
		
		

			public void Battle(Hokemon Attacker, Hokemon Defender)
			{
				int attackValue;
				int defenceValue;
				int round = 0;

				Hokemon tempHoke;

				while (Attacker.Health >= 0 || Defender.Health >= 0)
				{
					round += 1; //This is the same as round = round +1
					
					Console.WriteLine("\n****** Round {0} ******\n\n", round);

					for (int i = 0; i < 2; i++)
					{
						attackValue = Attacker.attackCalc();
						defenceValue = Defender.defenceCalc();
						
						Console.WriteLine("{0} Attacks with value: {1}\n", Attacker.Name, attackValue);

						
						Console.WriteLine("{0}: Defends...", Defender.Name);
						Console.WriteLine("Calculation: (Health {0} + Defence {1}) - attackValue");

						//EXAMPLE of how OBJECTS can have switched identifier names
						//This saves on having to repeat code
						Console.WriteLine("\n****\nSwitch turns: Defender becomes the Attacker...\n***\n");

						tempHoke = attacker;
						attacker = defender;
						defender = tempHoke;
					}

							while (Attacker.Health > DefenderHealth >= 0)

							if (Attacker.Health > Defender.Health)
							{
								Console.WriteLine("{0} WINS the BATTLE!!", Attacker.Name);
							}
							else
							{







							}

														Defender.Health = (Defender.Health
			}

