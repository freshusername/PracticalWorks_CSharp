using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class _9
    {
        public void Query()
        {
            MinionsContext context = new MinionsContext();

            //var v2 = from m in context.Minions
            //         join vm in context.Minions on new { MinionId = m.Id } equals new { vm.Id } into vm_join
            //         from vm in vm_join.DefaultIfEmpty()
            //         join a in context.Minions on new { Id = vm.MinionId } equals new { a.Id } into a_join
            //         from a in a_join.DefaultIfEmpty()
            //         where
            //           m.Id >= 0
            //         select new
            //         {
            //             MinionName = m.Name,
            //             MinionAge = a.Age
            //         };

            //foreach (var i in v2)
            //{
            //    t++;
            //    if (t == 1)
            //        Console.WriteLine(i.VillainName);
            //    Console.WriteLine(t + "." + i.MinionName + " " + i.MinionAge);
            //}


            var test = context.Minions
                .Where(c => c.Age >= 0)
                .Select(c => c);

                var age = context.Minions
                .Where(c => c.Age >= 0)
                .FirstOrDefault();

            // Внести изменения
            age.Age += 1;

            // Сохранить изменения
            context.SaveChanges();
        }
    }
}
