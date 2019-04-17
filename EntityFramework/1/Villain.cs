using System.Collections.Generic;
using System.Data.Entity;
namespace _1
{
    public class Villain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EvilnessFactorId { get; set; }
        public List<MinionsVillains> minionsVillains { get; set; }
        public EvilnessFactor EvilnessFactor1 { get; set; }
    }
}