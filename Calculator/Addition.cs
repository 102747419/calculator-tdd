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
            return first + second;
        }
    }
}
