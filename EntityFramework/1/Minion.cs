using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Minion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int TownId { get; set; }
        public List<MinionsVillains> MinionsVillains1 { get; set; }
        public Town Town1 { get; set; }
    }
}
