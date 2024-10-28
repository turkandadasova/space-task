using Core.Helpers.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public double Area { get; set; }
        public  string Anthem { get; set; }
        public Region region { get; set; }
    }
}
