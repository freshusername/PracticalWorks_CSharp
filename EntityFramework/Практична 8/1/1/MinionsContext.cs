using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace _1
{
    class MinionsContext : DbContext
    {
        public MinionsContext() : base("DbConnection")
        {

        }

        public DbSet<Minion> Minions {get;set;}

    }
}
