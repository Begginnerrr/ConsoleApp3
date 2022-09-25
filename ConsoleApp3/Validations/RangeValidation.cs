﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Validations
{
    public static class RangeValidation
    {
        public static bool validate(int number, int minRange=0, int MaxRange=int.MaxValue )
        {
            if (number > minRange && number < MaxRange) { return true; }
            else { return false; }
        }
    }
}
