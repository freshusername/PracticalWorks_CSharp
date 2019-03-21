using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace _4
{
    public abstract class AbstractDatabase
    {
        public abstract DbConnection Connection { get; set; }
        public abstract DbCommand Command { get; set; }
    }
}
