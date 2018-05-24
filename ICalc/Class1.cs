using System;
﻿using System.Runtime.InteropServices;

namespace ICalc
{
    public static class ICalc
    {
        [DllImport("../Calc/calc")]
        public static extern Int32 Add(Int32 a, Int32 b);
    }
}