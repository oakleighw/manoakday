using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountryAttempt;

namespace ConsoleApp6
{
    public class Program{ 


        static void Main(string[] args)
        {
            List<Countries> countriesList = new List<Countries>();

            countriesList.Add(new Country() { Name = "Austria", Population = 1.98 });
            countriesList.Add(new Country() { Name = "Belgium", Population = 2.56 });
            countriesList.Add(new Country() { Name = "Bulgaria", Population = 1.56 });
            countriesList.Add(new Country() { Name = "Croatia", Population = 0.91 });
            countriesList.Add(new Country { Name = "Cyprus", Population = 0.20 });
            countriesList.Add(new Country { Name = "Czech Republic", Population = 2.35 });
            countriesList.Add(new Country { Name = "Denmark", Population = 1.30 });
            countriesList.Add(new Country { Name = "Estonia", Population = 0.30 });
            countriesList.Add(new Country { Name = "France", Population = 14.98 });
            countriesList.Add(new Country { Name = "Germany", Population = 18.54 });
            countriesList.Add(new Country { Name = "Greece", Population = 2.40 });
            countriesList.Add(new Country { Name = "Hungary", Population = 2.18 });
            countriesList.Add(new Country { Name = "Ireland", Population = 1.10 });
            countriesList.Add(new Country { Name = "Italy", Population = 13.65 });
            countriesList.Add(new Country { Name = "Latvia", Population = 0.43 });
            countriesList.Add(new Country { Name = "Lithuania", Population = 0.62 });
            countriesList.Add(new Country { Name = "Luxembourg", Population = 0.14 });
            countriesList.Add(new Country { Name = "Malta", Population = 0.11 });
            countriesList.Add(new Country { Name = "Netherlands", Population = 3.89 });
            countriesList.Add(new Country { Name = "Poland", Population = 8.49 });
            countriesList.Add(new Country { Name = "Portugal", Population = 2.30 });
            countriesList.Add(new Country { Name = "Romania", Population = 4.34 });
            countriesList.Add(new Country { Name = "Slovakia", Population = 1.22 });
            countriesList.Add(new Country { Name = "Slovenia", Population = 1.22 });
            countriesList.Add(new Country { Name = "Spain", Population = 10.49 });
            countriesList.Add(new Country { Name = "Sweden", Population = 2.29 });

            foreach (var country in countriesList)

            {
                double totalYes = 0;
                double totalNo = 0;
                double totalAbs = 0;
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

                }
                // set up voting rule section
            }
            }
        }
    }
}
