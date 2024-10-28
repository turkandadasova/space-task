using Core.Data;
using Core.Models;

namespace ConsoleAppWithList
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            bool f = false;
            bool t = false;
            bool a = false;
            string choice;
            
            do
            {
                Console.WriteLine("1.Country menusuna daxil olun   2.Planet menusuna daxil olun.   0.EXIT.");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Sistemden cixis edildi.");
                        f = true;
                        break;


                    case "1":
                        Console.WriteLine("Country menusuna daxil olundu :)");

                        do
                        {
                            Console.WriteLine("1.olke yarat   2.olke gor  3.Evvelki menuya qayit.  0.Exit");

                            switch (choice)
                            {
                                case "1":
                                    Console.WriteLine("Olke adi daxil edin.");
                                    string name = Console.ReadLine();
                                    Country country = new Country();
                                    AppDbContext.CreatePlanet(name);
                                    break;

                                    case "2":
                                    Console.WriteLine("Olkeler asagidakilardi:");
                                    AppDbContext.GetAllCountries("name");
                                    Console.WriteLine(AppDbContext.GetAllCountries("name"));
                                    break;

                                    case "3":
                                    break;
                                
                                    case "0":
                                    Console.WriteLine("Cixis edildi.");
                                    a = true;
                                    break;
                                    
                            }



                        } while (!t);

                        break;

                        case "2":
                        Console.WriteLine("Planet menusuna daxil olundu :)");

                        do
                        {
                            Console.WriteLine("1.planet yarat  2.Butun Planetleri gor  3.Planet sec  0.Exit");

                            switch (choice)
                            {
                                case "1":
                                    Console.WriteLine("Planet adi daxil edin.");
                                    string name = Console.ReadLine();
                                    Planet planet = new Planet(name);
                                    AppDbContext.CreatePlanet(name);

                                    break;

                                case "2":
                                    Console.WriteLine("Planetler asagidakilardi:");
                                    AppDbContext.GetAllPlanets("name");
                                    Console.WriteLine(AppDbContext.GetAllPlanets("name"));
                                    break;

                                case "3":
                                    Console.WriteLine("Planet adi daxil edin.");
                                    string name1 = Console.ReadLine();
                                    AppDbContext.GetPlanet(name1); 
                                    
                                    break;
                                case "0":
                                    Console.WriteLine("Cixis edildi.");
                                    t = true;
                                    break;

                            }

                        } while (!t);

                        break;

                        
                }

            } while (!f);
        }
    }
}