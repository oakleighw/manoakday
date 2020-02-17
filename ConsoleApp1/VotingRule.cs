using System;
namespace Voting
{
	public class VotingRule
	{
		private string _voteRule;

		public string VoteRule
		{
			get
			{
				return _voteRule;
			}
			set
			{
				if (value == "1")
				{
					_voteRule = "Qualified Majority";
				}
				else if (value == "2")
				{
					_voteRule = "Reinforced Qualified Majority";
				}
				else if (value == "3")
				{
					_voteRule = "Simple Majority";
				}
				else if (value == "4")
				{
					_voteRule = "Unanimous";
				}
				else
				{
					throw new Exception("InvalidInput");
				}
			}
		}
		public void Votechoose()
		{
			Console.WriteLine("Please choose a Voting Rule by number: \n 1.Qualified Majority \n 2.Reinforced Qualified Majority \n 3.Simple Majority \n 4.Unanimous");
			string answer = Console.ReadLine();
			VoteRule = answer;
			Console.WriteLine($"You have chosen {VoteRule}");
		}
		public bool Result(double percentage, int countryYes)
		{//QM
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
			}
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
			}
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
			//unanimous
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
		public void Stats(double perYes, double perNo, double perAb, int noYes, int noNo, int noAb){
			Console.WriteLine("Would you like to see the final statistics? (y/n)");
			string input = Console.ReadLine();
			if (input == "y"){
				Console.WriteLine($"The total number of yes voting countries = {noYes}, or {perYes}%");
				Console.WriteLine($"The total number of no voting countries = {noNo}, or {perNo}%");
				Console.WriteLine($"The total number of countries abstaining from the vote = {noAb}, or {perAb}%");
			} else{
				Console.WriteLine("Thank you for using our European Voting Calculator");
			}
		}
	}
}
