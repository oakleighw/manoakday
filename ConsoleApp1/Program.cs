using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Country;
using Voting;
using List;

namespace Calculator
{
    public class Program
    {       

        static void Main(string[] args)
        {
            VotingRule vr = new VotingRule();
            vr.Votechoose();
            EUList elist = new EUList();
            
            //% vote
            double totalYes = 0;
            double totalNo = 0;
            double totalAbs = 0;
            //number votes
            int numberYes = 0;
            int numberNo = 0;
            int numberAbstain = 0;
            


            foreach (var country in elist.EUListMaker())

            {
               
                Console.WriteLine("Vote for {0}, please enter y for yes, n for no, or a for abstain", country.Name);
                string input = Console.ReadLine();
                if (input == "y")
                {
                    totalYes += country.Population;
                    numberYes++;
                    
                }
                else if (input == "n")
                {
                    totalNo += country.Population;
                    numberNo++;
                    
                }
                else if (input == "a")
                {
                    totalAbs += country.Population;
                    numberAbstain++;
                    
                }
                else
                {
                    throw new Exception("y, n, or a only");

                }
                Console.WriteLine($"The percentage yes vote is now {totalYes}%");
                Console.WriteLine($"The percentage no vote is now {totalNo}%");
                Console.WriteLine($"The percentage abstaining is now {totalAbs}%");
            }
            if (vr.Result(totalYes,numberYes)== true){
                Console.WriteLine("<<The motion is Approved>>");
            } else{
                Console.WriteLine("<<The motion is Rejected>>");
            }
            //ask if the user wants final stats
            vr.Stats(totalYes, totalNo, totalAbs, numberYes,numberNo,numberAbstain);
            
        }
    }
}
