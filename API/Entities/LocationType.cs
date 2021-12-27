using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class LocationType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
    }
}