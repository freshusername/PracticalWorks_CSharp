using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Queries
    {
        public void Query2()
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

        public void Query3()
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

        public void Query9()
        {
            MinionsContext context = new MinionsContext();
            Console.WriteLine("Input minions' id: ");
            int id = int.Parse(Console.ReadLine());

            var test = (from p in context.Minions
                        where p.Id == id
                        select p).ToList();
            foreach (var item in test)
            {
                Console.WriteLine(item.Name + "  -  " + item.Age);
            }

            (from p in context.Minions
             where p.Id == id
             select p).ToList().ForEach(x => x.Age += 1);

            Console.WriteLine("New ages: ");

            foreach (var item in test)
            {
                Console.WriteLine(item.Name + "  -  " + item.Age);
            }


            // Сохранить изменения
            context.SaveChanges();
            Console.ReadLine();
        }

        public void Query8()
        {
            MinionsContext context = new MinionsContext();
            Console.WriteLine("Input minions' id: ");
            int id = int.Parse(Console.ReadLine());

            var test = (from p in context.Minions
                        where p.Id == id
                        select p).ToList();
            foreach (var item in test)
            {
                Console.WriteLine(item.Name + "  -  " + item.Age);
            }

            (from p in context.Minions
             where p.Id == id
             select p).ToList().ForEach(x => x.Age += 1);

            Console.WriteLine("New ages: ");

            foreach (var item in test)
            {
                Console.WriteLine(item.Name + "  -  " + item.Age);
            }


            // Сохранить изменения
            context.SaveChanges();
            Console.ReadLine();
        }
        public void Query7()
        {
            MinionsContext context = new MinionsContext();

            var names = context.Minions
                .Where(b => b.Id != 0)
                .ToArray();
            Console.WriteLine("Original order: ");
            foreach (var name in names)
            {
                Console.WriteLine(name.Name + " ");
            }
            Console.WriteLine("New order: ");
            for (int first = 0, last = names.Length - 1; first <= last; first++, last--)
            {
                Console.WriteLine(names[first].Name);
                if (first != last)
                {
                    Console.WriteLine(names[last].Name);
                }
            }

            context.SaveChanges();
            
        }
        public void Query6()
        {
            MinionsContext context = new MinionsContext();
            Console.WriteLine("Input villains' Ids: ");
            var IdData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < IdData.Length; i++)
            {
                var names = context.Villains
                .Where(b => b.Id == IdData[i])
                .ToArray();
               
            }
            

            foreach (var item in IdData) //ERRORR
                {
                    Console.WriteLine(item + " ");
                
                }
            
            


            
        }
    }
}
