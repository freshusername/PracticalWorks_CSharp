﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    abstract class AbstractCarManufaturer
    {
        public abstract AbstractChassis CreateChassis();
        public abstract AbstractEngine CreateEngine();
        public abstract AbstractSalon CreateSalon();
        
    }
}
