using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Area
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Location> Locations { get; set; } = new List<Location>();
    }
}
