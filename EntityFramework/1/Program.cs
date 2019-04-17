using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MinionsContext db = new MinionsContext())
            {
                //creating Minions
                

                Country country1 = new Country { Name = "USA",          Id = 1 };
                Country country2 = new Country { Name = "Ukraine",      Id = 2 };
                Country country3 = new Country { Name = "Germany",      Id = 3 };
                Country country4 = new Country { Name = "Italy",        Id = 4 } ;
                Country country5 = new Country { Name = "France",       Id = 5 };

                Town town1 = new Town { Name = "Kyiv",          CountryId = 2,      Id = 1 };
                Town town2 = new Town { Name = "Vancouver",     CountryId = 1,      Id = 2 };
                Town town3 = new Town { Name = "Washington",    CountryId = 1,      Id = 3 };
                Town town4 = new Town { Name = "New York",      CountryId = 1,      Id = 4 };
                Town town5 = new Town { Name = "Parise",        CountryId = 5,      Id = 5 };
                Town town6 = new Town { Name = "Munchen",       CountryId = 3,      Id = 6 };
                Town town7 = new Town { Name = "Frankfurt",     CountryId = 3,      Id = 7 };
                Town town8 = new Town { Name = "Rome",          CountryId = 4,      Id = 8 };
                Town town9 = new Town { Name = "Venezia",       CountryId = 4,      Id = 9 };
                Town town10 = new Town { Name = "Odessa",       CountryId = 2,      Id = 10 };
                  
                EvilnessFactor evilnessFactor1 = new EvilnessFactor { Name = "Bad",     Id = 3 };
                EvilnessFactor evilnessFactor2 = new EvilnessFactor { Name = "Good",    Id = 2 };
                EvilnessFactor evilnessFactor3 = new EvilnessFactor { Name = "Pretty",  Id = 1 };
                EvilnessFactor evilnessFactor4 = new EvilnessFactor { Name = "Evil",    Id = 4 };

                Villain villain1 = new Villain { Name = "Tominikano",   Id = 1,     EvilnessFactorId = 3 };
                Villain villain2 = new Villain { Name = "Zelenino",     Id = 2,     EvilnessFactorId = 4 };
                Villain villain3 = new Villain { Name = "Porohino",     Id = 3,     EvilnessFactorId = 2 };
                Villain villain4 = new Villain { Name = "Trumpino",     Id = 4,     EvilnessFactorId = 1 };

                MinionsVillains minionsVillains1 = new MinionsVillains { Id = 1, MinionId = 1, VillainId = 1 };
                MinionsVillains minionsVillains2 = new MinionsVillains { Id = 2, MinionId = 2, VillainId = 1 };
                MinionsVillains minionsVillains3 = new MinionsVillains { Id = 3, MinionId = 3, VillainId = 1 };
                MinionsVillains minionsVillains4 = new MinionsVillains { Id = 4, MinionId = 4, VillainId = 2 };
                MinionsVillains minionsVillains5 = new MinionsVillains { Id = 5, MinionId = 5, VillainId = 3 };
                MinionsVillains minionsVillains6 = new MinionsVillains { Id = 6, MinionId = 6, VillainId = 4 };
                MinionsVillains minionsVillains7 = new MinionsVillains { Id = 7, MinionId = 5, VillainId = 4 };
                MinionsVillains minionsVillains8 = new MinionsVillains { Id = 8, MinionId = 4, VillainId = 4 };


                Minion minion1 = new Minion { Name = "Tony",    Age = 19, Id = 1, TownId = 1 };
                Minion minion2 = new Minion { Name = "Gabriel", Age = 18, Id = 2, TownId = 1 };
                Minion minion3 = new Minion { Name = "Luiza",   Age = 18, Id = 3, TownId = 2 };
                Minion minion4 = new Minion { Name = "Jack",    Age = 14, Id = 4, TownId = 3 };
                Minion minion5 = new Minion { Name = "Tom",     Age = 13, Id = 5, TownId = 3 };
                Minion minion6 = new Minion { Name = "Mitty",   Age = 19, Id = 6, TownId = 4 };


                #region adding to DB
                Console.WriteLine("Processing...");
                db.Countries.Add(country1);
                db.Countries.Add(country2);
                db.Countries.Add(country3);
                db.Countries.Add(country4);
                db.Countries.Add(country5);

                db.Towns.Add(town1);
                db.Towns.Add(town2);
                db.Towns.Add(town3);
                db.Towns.Add(town4);
                db.Towns.Add(town5);
                db.Towns.Add(town6);
                db.Towns.Add(town7);
                db.Towns.Add(town8);
                db.Towns.Add(town9);
                db.Towns.Add(town10);

                db.EvilnessFactors.Add(evilnessFactor1);
                db.EvilnessFactors.Add(evilnessFactor2);
                db.EvilnessFactors.Add(evilnessFactor3);
                db.EvilnessFactors.Add(evilnessFactor4);

                db.Villains.Add(villain1);
                db.Villains.Add(villain2);
                db.Villains.Add(villain3);
                db.Villains.Add(villain4);

                db.MinionsVillains.Add(minionsVillains1);
                db.MinionsVillains.Add(minionsVillains2);
                db.MinionsVillains.Add(minionsVillains3);
                db.MinionsVillains.Add(minionsVillains4);
                db.MinionsVillains.Add(minionsVillains5);
                db.MinionsVillains.Add(minionsVillains6);
                db.MinionsVillains.Add(minionsVillains7);
                db.MinionsVillains.Add(minionsVillains8);

                db.Minions.Add(minion1);
                db.Minions.Add(minion2);
                db.Minions.Add(minion3);
                db.Minions.Add(minion4);
                db.Minions.Add(minion5);
                db.Minions.Add(minion6);

                db.SaveChanges();
                Console.WriteLine("Data Added!");
                Console.ReadLine();
                #endregion
            }
        }
        
    }
}
