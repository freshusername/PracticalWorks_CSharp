using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Queries
    {
        MinionsContext context = new MinionsContext();
        public void Query2()
        {
            Console.WriteLine("Query2: ");
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
            Console.WriteLine("Query3: ");
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
        public void Query4()
        {
            string name;
            int age;

            string townName;
            string villainName;

            String s;
            Console.WriteLine("Add Minion : ");

            Console.WriteLine("Input name of minion: ");
            Console.WriteLine("Input age of minion: ");
            Console.WriteLine("Input town of minion: ");

            s = Console.ReadLine();
            String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            name = words[0].ToString();
            age = Convert.ToInt32(words[1]);
            townName = words[2];

            Minion minions = new Minion();

            Console.WriteLine("Input name of Villain : ");
            villainName = Console.ReadLine();

            Town towns = new Town();
            var Ttowns = context.Towns.ToList();

            bool flag = false;
            bool flag1 = false;
            int idd = 0;
            foreach (var t in Ttowns)
            {
                if (t.Name == words[2])
                {
                    idd = t.Id;
                    flag = true;
                    break;

                }
                else if (t.Name != words[2])
                {

                    flag = false;
                }
            }

            if (flag == true)
            {
                minions.TownId = idd;
                minions.Name = name;
                minions.Age = age;
                context.Minions.Add(minions);
                context.SaveChanges();
                Console.WriteLine("You have this town ");
            }
            else
            {
                towns.Name = words[2];
                context.Towns.Add(towns);
                context.SaveChanges();

                var newtowns = context.Towns.ToList();
                minions.Name = name;
                minions.Age = age;
                foreach (var t in newtowns)
                {
                    if (t.Name == townName)
                    {
                        minions.TownId = t.Id;
                    }
                }

                context.Minions.Add(minions);
                context.SaveChanges();
                Console.WriteLine("This town were added to DB");
            }



            Villain villains = new Villain();
            var villainss = context.Villains.ToList();
            int idvillain = 0;
            int idminion = 0;
            var minionss = context.Minions.ToList();
            MinionsVillains minionsVillains = new MinionsVillains();

            foreach (var v in villainss)
            {
                if (villainName == v.Name)
                {
                    idvillain = v.Id;
                    flag1 = true;
                    break;
                }
                else if (villainName != v.Name)
                {
                    flag1 = false;
                }
            }

            if (flag1 == true)
            {

                idminion = minionss.Last().Id;
                minionsVillains.MinionId = idminion;
                minionsVillains.VillainId = idvillain;
                context.MinionsVillains.Add(minionsVillains);
                context.SaveChanges();
                Console.WriteLine("You have this villain ");
            }
            else
            {
                villains.Name = villainName;
                villains.EvilnessFactorId = 5;
                context.Villains.Add(villains);
                context.SaveChanges();

                var newvillains = context.Villains.ToList();////////////

                idminion = minionss.Last().Id;
                minionsVillains.MinionId = idminion;
                minionsVillains.VillainId = newvillains.Last().Id;

                context.MinionsVillains.Add(minionsVillains);
                context.SaveChanges();

                Console.WriteLine("This villain were added to DB");

            }

        }
        public void Query5()
        {
            Console.WriteLine("Query4: ");
            Console.WriteLine("Choose country from the list below: ");
            var v4 = context.Countries;
            foreach (var item in v4)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
            Console.WriteLine("Input digit of country: ");
            int temp = int.Parse(Console.ReadLine());

            var v5 = context.Towns;
            foreach (var item in v5)
            {
                if (item.Id == temp)
                {
                    item.Name = item.Name.ToUpper();
                }
            }
            context.SaveChanges();
            var v6 = context.Towns;
            foreach (var item in v6)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
        public void Query6()
        {
            var v5 = context.Villains;
            foreach (var item in v5)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
            int temp = int.Parse(Console.ReadLine());

            MinionsVillains minionsVillains = context.MinionsVillains
                .Where(o => o.VillainId == temp)
                .FirstOrDefault();

            context.MinionsVillains.Remove(minionsVillains);
            context.SaveChanges();

            var v6 = context.MinionsVillains;
            foreach (var i in v6)
            {
                Console.WriteLine(i.MinionId + " " + i.VillainId);
            }

            Villain villain = context.Villains
                .Where(o => o.Id == temp)
                .FirstOrDefault();

            context.Villains.Remove(villain);
            context.SaveChanges();

        }
        public void Query9()
        {
            Console.WriteLine("Query5: ");
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
            Console.WriteLine("Query8: ");
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
            Console.WriteLine("Query7: ");

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
            Console.ReadLine();

        }


    }
}
