using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Addition : Operator
    {
        public override decimal Calculate(decimal first, decimal second)
        {
            if (second == 0)
            {
                return first;
            }
            return first + second;
        }
    }
}
