using System.Collections.Generic;
using System.Data.Entity;
namespace _1
{
    public class EvilnessFactor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MinionsVillains> MinionsVillains1 { get; set; }
    }
}