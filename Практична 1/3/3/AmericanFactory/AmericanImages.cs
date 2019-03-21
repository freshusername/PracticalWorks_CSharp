using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class AmericanImages : AbstractImages
    {
        public override string imgStr(int n)
        {
            List<string> imgs = new List<string>();
            imgs.Add("D:/course 2/c#/Практичні/Практична 1/3/pics/0.jpg");
            imgs.Add("2.gif");
            imgs.Add("2.jpg");
            imgs.Add("3.jpg");
            imgs.Add("4.jpg");
            return imgs[n];
        }
    }
}
