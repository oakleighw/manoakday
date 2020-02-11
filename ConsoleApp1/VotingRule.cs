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
					throw new Exception("Sorry you have not chose an option by number");
				}
			}
		}
		public void Votechoose()
		{
			Console.WriteLine("Please choose a Voting Rule by number: \n 1.Qualified Majority \n 2. Reingforced Qualified Majority \n 3. Simple Majority \n 4.Unanimous");
			string answer = Console.ReadLine();
			this.VoteRule = answer;
		}
		
	}
}
