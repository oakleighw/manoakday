using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting;

namespace Calculator
{
    public class Program
    {       

        static void Main(string[] args)
        {
            List<Countries> countriesList = new List<Countries>();

            countriesList.Add(new Countries() { Name = "Austria", Population = 1.98 });
            countriesList.Add(new Countries() { Name = "Belgium", Population = 2.56 });
            countriesList.Add(new Countries() { Name = "Bulgaria", Population = 1.56 });
            countriesList.Add(new Countries() { Name = "Croatia", Population = 0.91 });
            countriesList.Add(new Countries() { Name = "Cyprus", Population = 0.20 });
            countriesList.Add(new Countries() { Name = "Czech Republic", Population = 2.35 });
            countriesList.Add(new Countries() { Name = "Denmark", Population = 1.30 });
            countriesList.Add(new Countries() { Name = "Estonia", Population = 0.30 });
            countriesList.Add(new Countries() { Name = "France", Population = 14.98 });
            countriesList.Add(new Countries() { Name = "Germany", Population = 18.54 });
            countriesList.Add(new Countries() { Name = "Greece", Population = 2.40 });
            countriesList.Add(new Countries() { Name = "Hungary", Population = 2.18 });
            countriesList.Add(new Countries() { Name = "Ireland", Population = 1.10 });
            countriesList.Add(new Countries() { Name = "Italy", Population = 13.65 });
            countriesList.Add(new Countries() { Name = "Latvia", Population = 0.43 });
            countriesList.Add(new Countries() { Name = "Lithuania", Population = 0.62 });
            countriesList.Add(new Countries() { Name = "Luxembourg", Population = 0.14 });
            countriesList.Add(new Countries() { Name = "Malta", Population = 0.11 });
            countriesList.Add(new Countries() { Name = "Netherlands", Population = 3.89 });
            countriesList.Add(new Countries() { Name = "Poland", Population = 8.49 });
            countriesList.Add(new Countries() { Name = "Portugal", Population = 2.30 });
            countriesList.Add(new Countries() { Name = "Romania", Population = 4.34 });
            countriesList.Add(new Countries() { Name = "Slovakia", Population = 1.22 });
            countriesList.Add(new Countries() { Name = "Slovenia", Population = 1.22 });
            countriesList.Add(new Countries() { Name = "Spain", Population = 10.49 });
            countriesList.Add(new Countries() { Name = "Sweden", Population = 2.29 });
            
            double totalYes = 0;
            double totalNo = 0;
            double totalAbs = 0;

            foreach (var country in countriesList)

            {
               
                Console.WriteLine("Vote for {0}, please enter y for yes, n for no, or a for abstain", country.Name);
                string input = Console.ReadLine();
                if (input == "y")
                {
                    totalYes += country.Population;
                    
                }
                else if (input == "n")
                {
                    totalNo += country.Population;
                    
                }
                else if (input == "a")
                {
                    totalAbs += country.Population;
                    
                }
                else
                {
                    throw new Exception("y, n, or a only");
                }
                Console.WriteLine($"The percentage yes vote is now {totalYes}");
                Console.WriteLine($"The percentage no vote is now {totalNo}");
                Console.WriteLine($"The percentage abstaining is now {totalAbs}");
            }
            
        }
    }
}
