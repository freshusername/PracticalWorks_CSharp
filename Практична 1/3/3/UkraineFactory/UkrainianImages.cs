using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class UkrainianImages : AbstractImages
    {
        public override string imgStr(int n)
        {
            List<string> imgs = new List<string>();
            imgs.Add("D:/course 2/c#/Практичні/Практична 1/3/pics/00.jpg");
            imgs.Add("D:/course 2/c#/Практичні/Практична 1/3/pics/11.jpg");
            imgs.Add("D:/course 2/c#/Практичні/Практична 1/3/pics/22.jpg");
            imgs.Add("D:/course 2/c#/Практичні/Практична 1/3/pics/33.jpg");
            imgs.Add("D:/course 2/c#/Практичні/Практична 1/3/pics/44.jpg");
            return imgs[n];
        }
    }
}
