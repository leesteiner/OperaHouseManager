using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Date = DateTime.Today;
            string SelectedOption;
            

            SetConsoleColors("DarkBlue", "White");
            Console.WriteLine("==================================");
            Console.WriteLine("||Welcome to Opera House Manager||");
            Console.WriteLine("==================================\n\n");
            Console.ResetColor();
            City playerCity = SetCity();
            int PlayerMoney = playerCity.StartingMoney;
            List<Employee> CurrentFullTimeEmployees = new List<Employee> { };
            Singer Lee = new Singer("Lee Steiner", 31, VoiceType.Tenor);
            Employee Sandy = new Employee("Sandy Taylor", "Executive", 2000, 0);
            CurrentFullTimeEmployees.Add(Lee);
            CurrentFullTimeEmployees.Add(Sandy);

            Console.WriteLine("Your city is: {0}.", playerCity.CityName);

            do
            {
                Console.WriteLine($"Today is: {Date.ToShortDateString()}.");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. View Finances");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Program Opera");
                Console.WriteLine("4. Next Week");
                Console.WriteLine("5. Exit Game");
                SelectedOption = Console.ReadLine();
                if (int.TryParse(SelectedOption, out int choice))
                {
                    switch(choice)
                    {
                        case 1:
                            ViewFinances();
                            break;
                        case 2:
                            ViewEmployees();
                            break;
                        case 3:
                            ProgramOpera();
                            break;
                        case 4:
                            IncrementWeek();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
            } while (int.Parse(SelectedOption) != 5);





            //   Singer LeeSteiner = new Singer { Name = "Lee Steiner", Age = 31, Type = "Tenor" };
            Singer LeeSteiner = new Singer("Lee Steiner", 31, VoiceType.Tenor);
        //    LeeSteiner.DisplayStats();

            /*for (int i = 0;i<10;i++) {
                Singer joe = new Singer("Joe");
                joe.DisplayStats();
            }
            */

            Opera MagicFlute = new Opera("Magic Flute", "Mozart", Language.German, 100, true, 20, new List<Role>());
         //   MagicFlute.DisplayStats();
         //   Console.WriteLine("Adding in three roles: ");
            MagicFlute.AddRole("Tamino", VoiceType.Tenor, RoleClass.Leading);
            MagicFlute.AddRole("Pamina", VoiceType.Soprano, RoleClass.Leading);
            MagicFlute.AddRole("Queen of the Night", VoiceType.Soprano, RoleClass.Featured);
        //    MagicFlute.DisplayStats();
            for (int i = 0; i<200;i++)
            {
                MagicFlute.IncreasePopularity();
            }

          //  MagicFlute.DisplayStats();

            void SetConsoleColors(string background, string foreground)
            {

                if (Enum.TryParse(background, out ConsoleColor back))
                {
                    Console.BackgroundColor = back;
                }
                else { Console.BackgroundColor = ConsoleColor.Black; }

                if (Enum.TryParse(foreground, out ConsoleColor fore))
                {
                    Console.ForegroundColor = fore;
                }
                else { Console.ForegroundColor = ConsoleColor.White; }
            }

            City SetCity()
            {
                List<City> Cities = ImportCityChoices();
                City city;
                do
                {
                    Console.WriteLine("Choose a city:");
                    foreach (City c in Cities)
                    {
                        if (c.CityEnum != 0)
                        {
                            Console.WriteLine($"{(byte)c.CityEnum}. {c.CityName} - Population: {c.StartingPopulation} - Starting Funds: {c.StartingMoney}");
                        }
                        
                    }


                    if (int.TryParse((Console.ReadLine()), out int cit))
                    {
                        if (cit < Cities.Count)
                        {
                            city = Cities[(byte)cit];
                        }
                        else city = Cities[0];
                    }
                    else city = Cities[0];
                }
                while (city.CityEnum == PlayerCity.Undefined);

                return city;
            }

            List<City> ImportCityChoices()
            {
                List<City> Cities = new List<City>();
                Cities.Add(new City("Undefined", PlayerCity.Undefined, 0, 0));
                Cities.Add(new City("New York City, NY", PlayerCity.NYC, 1_000_000, 100_000_000));
                Cities.Add(new City("Pittsburgh, PA", PlayerCity.Pittsburgh, 500_000, 10_000_000));
                Cities.Add(new City("Des Moines, IA", PlayerCity.DesMoines, 250_000, 500_000));
                Cities.Add(new City("Latrobe, PA", PlayerCity.Latrobe, 100_000, 30_000));
                Cities.Add(new City("Landing, NJ", PlayerCity.Landing, 50_000, 25_000));
                return Cities;
            }

            void ViewFinances()
            {
                Console.WriteLine("In View Finances");
                Console.WriteLine("Available funds: {0}", PlayerMoney);
            }
            void ProgramOpera() { Console.WriteLine("In Program Opera"); }
            void IncrementWeek()
            {
                Date = Date.AddDays(7);
                AddWeeklyRevenue();
                SubtractWeeklyExpenses();
            }

            void AddWeeklyRevenue()
            {
                PlayerMoney += 100;
            }

            void SubtractWeeklyExpenses()
            {
                PlayerMoney -= 2000;
            }

            void ViewEmployees()
            {
                int i = 0;
                foreach (Employee e in CurrentFullTimeEmployees)
                {
                    if (e.Position == "Singer")
                    {
                        Console.WriteLine("{0}. {1}, {2} - {3}", i, e.Name, e.Position, "Opera List here!");
                    }
                    else { Console.WriteLine("{0}. {1}, {2}", i, e.Name, e.Position); }

                    i++;
                }
            }
            void HireOfficeEmployees()
            {
                byte HireOption = 0;
                do
                {
                    Console.WriteLine("Hire Office Employees:");
                    
                
                }
                while (HireOption!=5);


            }
        }

        


    }
}
