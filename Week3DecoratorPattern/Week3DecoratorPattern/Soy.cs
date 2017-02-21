﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    public class Soy:CondimentDecorator
    {
        public Soy(IBeverage b)
            :base()
        {
            this.drink = b;
        }
    }
}
