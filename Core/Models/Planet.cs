using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Planet
    {
        public Planet(string name)
        {
            Name = name;
        }
        public Planet()
        {
            
        }
        public Planet(Planet name)
        {
            
        }

        public int PlanetId { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
    }
}
