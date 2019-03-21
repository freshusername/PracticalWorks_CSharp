using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class AmericanLocale : AbstractLocale
    {
        public override string locStr()
        {
            string l = "We’re off to a place of towering sky scrapers, beautiful beaches, \n breath-taking canyons, cool cowboys and mega movie stars! \n Fancy joining? Then check out our fab facts about the USA…";
            string l1 = "Official Name: United States of America\nPopulation: 324, 057, 300\nForm of Government: Constitution - based federal republic\nCapital: Washington, D.C.\nArea: 9, 826, 630 square kilometres\nMajor Mountain Ranges: Rocky Mountains, Appalachian Mountains\nMajor Rivers: Mississippi, Missouri, Colorado\nLanguages: English, Spanish\nMoney: U.S.dollar";
            return l + l1;

        }
    }
}
