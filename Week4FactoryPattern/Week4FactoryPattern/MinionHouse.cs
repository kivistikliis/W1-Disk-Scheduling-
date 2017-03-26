﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    class MinionHouse:IHouse
    {
        private bool broken;
        private int size;
        public MinionHouse()
        {
            broken=true;
            size = 100;
        }
        public string repair()
        {
            if (broken)
            {
                broken = false;
                return "Minion house is now fixed";
            }
            else return "Minion house is already fixed!";

        }
        public string measure()
        {
            return "Minion house size is: " + size;
        }
    }
}
