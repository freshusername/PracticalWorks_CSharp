using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._2
{
    public class _2
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


            var v1 = from vm in context.MinionsVillains
                     group new { vm.Villain1, vm } by new
                     {
                         vm.Villain1.Name
                     } into g
                     where g.Count() >= 3
                     orderby
                       g.Count() descending
                     select new
                     {
                         g.Key.Name,
                         NumberOfMinions = g.Count()
                     };

            foreach (var i in v1)
            {
                Console.WriteLine(i.Name + " - " + i.NumberOfMinions);
            }



            Console.ReadLine();

        }

    }
}
