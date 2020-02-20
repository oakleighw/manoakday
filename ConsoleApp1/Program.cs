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
        {//creating voting rule and EU list objects to use in Main
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
            

            //loop through countries in list to vote for each one
            foreach (var country in elist.EUListMaker())

            {
               while(true)//covers for accidental incorrect inputs
               { 
                Console.WriteLine("Vote for {0}, please enter y for yes, n for no, or a for abstain.[Enter 'q' to exit]", country.Name);
                string input = Console.ReadLine();
                    if (input == "y")
                    {//VoteYes
                        totalYes += country.Population;
                        numberYes++;
                        break;

                    }
                    else if (input == "n")
                    {//voteNo
                        totalNo += country.Population;
                        numberNo++;
                        break;

                    }
                    else if (input == "a")
                    {//VoteAbstain
                        totalAbs += country.Population;
                        numberAbstain++;
                        break;

                    }
                    else if (input == "q")
                    {//quit program
                        Console.WriteLine("Goodbye");
                        Console.ReadLine();
                        System.Environment.Exit(0);
                    }
                    else
                    {//invalid input, asks again
                        try
                        {
                            throw new Exception("invalid input");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid input, please enter a valid option");
                        }
                    }  
                  

               }//gives updated stats after each vote
                Console.WriteLine($"The percentage yes vote is now {totalYes}%");
                Console.WriteLine($"The percentage no vote is now {totalNo}%");
                Console.WriteLine($"The percentage abstaining is now {totalAbs}%");
            }//final result
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
