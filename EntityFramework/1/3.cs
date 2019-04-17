using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class _3
    {
        public void Query()
        {
            MinionsContext context = new MinionsContext();

            //var test = context.MinionsVillains.GroupBy(x => x.VillainId)
            //    .Where(w => w.Count() == 3)
            //    .Select(w => w.Key)
            //    .ToList();


            //foreach (var mv in test)
            //{
            //    Console.WriteLine(mv + " ");
            //}
            //Console.ReadLine();

            int t = 0;
            Console.Write("Enter villain id: ");

            int villainId = int.Parse(Console.ReadLine());

            var v2 = from v in context.Villains
                     join vm in context.MinionsVillains on new { VillainId = v.Id } equals new { vm.VillainId } into vm_join
                     from vm in vm_join.DefaultIfEmpty()
                     join m in context.Minions on new { Id = vm.MinionId } equals new { m.Id } into m_join
                     from m in m_join.DefaultIfEmpty()
                     where
                       v.Id == villainId
                     select new
                     {
                         VillainName = v.Name,
                         MinionName = m.Name,
                         MinionAge = m.Age
                     };

            foreach (var i in v2)
            {
                t++;
                if (t == 1)
                    Console.WriteLine(i.VillainName);
                Console.WriteLine(t + "." + i.MinionName + " " + i.MinionAge);
            }
           
            Console.ReadLine();
        }
    }
}
