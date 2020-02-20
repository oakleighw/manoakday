using System;
namespace Voting
{
	public class VotingRule
	{	//field used by VoteRule Property
		private string _voteRule;

		private string VoteRule//property set to private as used by VoteChoose(within class)
		{
			get
			{
				return _voteRule;
			}
			set
			{//This is the choice made through the initial menu "Method VoteChoose()" (select one through 4)
				while (true)//allows for Input validation
				{
					if (value == "1")
					{
						_voteRule = "Qualified Majority";
						break;
					}
					else if (value == "2")
					{
						_voteRule = "Reinforced Qualified Majority";
						break;
					}
					else if (value == "3")
					{
						_voteRule = "Simple Majority";
						break;
					}
					else if (value == "4")
					{
						_voteRule = "Unanimous";
						break;
					}
					else if (value == "q")
					{
						Console.WriteLine("Goodbye");
						Console.ReadLine();
						System.Environment.Exit(0);
					}
					else
					{
						try
						{//if user inputs an invalid option
							throw new Exception("InvalidInput");
						}
						catch (Exception)
						{
							Console.WriteLine("Selection number incorrect, please try again[or enter 'q' to quit]");
							value = Console.ReadLine();
						}
					}
					
				}
			}
		}//Allow the user to pick which rule they would like to apply for their vote
		public void Votechoose()//acts as starting User Interface
		{
			Console.WriteLine("Please choose a Voting Rule by number: \n 1.Qualified Majority \n 2.Reinforced Qualified Majority \n 3.Simple Majority \n 4.Unanimous");
			string answer = Console.ReadLine();
			VoteRule = answer;
			Console.WriteLine($"You have chosen {VoteRule}");
		}
		public bool Result(double percentage, int countryYes)//returns result to be used at end of main
		{//Qualified majority rule, at least 65% of the population and 15 countries have to 
		//vote in favour for the rule to pass
			if (_voteRule == "Qualified Majority")
			{
				if (percentage >= 65.00 && countryYes >= 15)
				{
					return true;
				}
				else
				{
					return false;
				}
			}//Reinforced qualified majority rule, at least 65% of the population and 20 countries have to vote in favour 
			//for the vote to pass
			else if (_voteRule == "Reinforced Qualified Majority")
			{
				if (percentage >= 65 && countryYes >= 20)
				{
					return true;
				}
				else
				{
					return false;
				}
			}//Simple majority rule, 14 participating countries have to vote in favour for the vote to pass
			else if (_voteRule == "Simple Majority")
			{
				if (countryYes >= 14)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			//Unanimity rule, all participating countries have to vote in favour for the vote to pass
			else
			{
				if (countryYes == 27)
				{
					return true;
				}
				else
				{
					return false;
				}					
			}
		}
		//Stats Method allows user to view overall votes.
		public void Stats(double perYes, double perNo, double perAb, int noYes, int noNo, int noAb){
			Console.WriteLine("Would you like to see the final statistics? (y/n)");
			string input = Console.ReadLine();
			if (input == "y"){
				Console.WriteLine($"The total number of yes voting countries = {noYes}, or ~{Math.Floor(perYes)}% of EU Population");
				Console.WriteLine($"The total number of no voting countries = {noNo}, or ~{perNo}% of EU Population");
				Console.WriteLine($"The total number of countries abstaining from the vote = {noAb}, or ~{perAb}% of EU Population");
			} else{
				Console.WriteLine("Thank you for using our European Voting Calculator");
			}
		}
	}
}
