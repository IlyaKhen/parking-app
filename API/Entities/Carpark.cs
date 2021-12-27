using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Carpark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Area> Areas { get; set; } = new List<Area>();
    }
}