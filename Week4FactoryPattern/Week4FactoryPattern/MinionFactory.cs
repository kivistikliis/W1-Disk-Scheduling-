﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    class MinionFactory:IFactory
    {
        public IFigure createFigure(string name)
        {
            return (new Minion(name));
        }
        public IHouse createHouse()
        {
            return (new MinionHouse());
        }
    }
}
