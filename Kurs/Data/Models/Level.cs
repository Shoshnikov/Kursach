using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Data.Models
{
    public class Level
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public List<Theme> Themes { get; set; }
    }
}
