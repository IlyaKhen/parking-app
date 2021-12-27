using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public LocationStatus LocationStatus { get; set; }

    }
}
