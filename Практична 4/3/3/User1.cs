using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class User1 : AbstractElement
    {
        public bool IsTaken { get; set; }
        public string Name { get; set; }
        public string Narada { get; set; }
        public User1(string name, string narada, bool istaken)
        {
            this.Name = name;
            this.Narada = narada;
            this.IsTaken = istaken;
        }

        public override string Accept(AbstractVisitor visitor)
        {
            visitor.VisitUser1(this);
            return " ";
        }
    }
}
