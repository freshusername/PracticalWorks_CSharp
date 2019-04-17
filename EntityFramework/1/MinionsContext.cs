using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _1
{
    class MinionsContext : DbContext
    {
        public MinionsContext() 
            : base("DBConnection") { }

        public DbSet<Minion> Minions { get; set; }
        public DbSet<EvilnessFactor> EvilnessFactors { get; set; }
        public DbSet<Villain> Villains { get; set; }
        public DbSet<MinionsVillains> MinionsVillains { get; set; }
        public DbSet<Country>Countries  { get; set; }
        public DbSet<Town> Towns { get; set; }
    }
}
