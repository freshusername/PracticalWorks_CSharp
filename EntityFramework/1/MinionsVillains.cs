using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace _1
{
    public class MinionsVillains
    {
        public int Id { get; set; }
        public int MinionId { get; set; }
        public int VillainId { get; set; }
        public Minion Minion1 { get; set; }
        public Villain Villain1 { get; set; }
    }
}
