using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class CalendarVisitor : AbstractVisitor
    {
        public override string VisitUser1(AbstractElement element)
        {
            string s;
            User1 user1 = element as User1;
            user1.IsTaken = true;
            return s = $"User {user1.Name} set new narada *{user1.Narada}* in: {user1.Date} - this date is taken!";
        }
    }
}
