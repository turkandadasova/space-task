using Core.Helpers.Enum;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Data
{
    public static class AppDbContext
    {
        static List<Country> Countries = new List<Country>();
        static List<Planet> Planets = new List<Planet>();
        static Region Region = new Region();
        

        public static void CreateCountry(Planet planet)
        {
            Countries.Add(new Country());
        }
        public static void RemoveCountry()
        {
            Countries.Remove(new Country());
        }

        public static void UpdateCountry()
        {
            Country country = new Country();
            string newname = Console.ReadLine();

             
        }

        public static List<Country> GetAllCountries(string name)
        {
            return Countries.FindAll(x => x.CountryName == name);
        }

        public static List<Country> GetCountryByRegion(Region region)
        {
            return Countries.FindAll(x => x.region == region);
        }

        public static void CreatePlanet(string name)
        {
             Planets.Add(new Planet(name));
        }
        public static void RemovePlanet()
        {
            Planets.Remove(new Planet());
        }

        public static void UpdatePlanet()
        {

        }

        public static void GetPlanet(string name)
        {
            Planets.Find(x => x.Name == name);
        }

        public static List<Planet> GetAllPlanets(string name)
        {
            return Planets.FindAll(x => x.Name == name);
        }
    }
}
