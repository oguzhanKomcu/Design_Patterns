﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_Pattern
{
    public class Impact : IStrategy
    {
        public int Opreation(int num1, int num2)
        {
           return num1 * num2;  
        }
    }
}
