using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Comum
{
    public class MatematicaUtil
    {
        public static decimal Divisao(decimal a, decimal b)
        {
            if (b == 0)
                return 0;

            return a / b;
        }
    }
}
