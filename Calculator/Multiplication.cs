using System;
namespace Calculator
{
    public class Multiplication : Operator
    {
        public override decimal Calculate(decimal first, decimal second)
        {
            return first * second;
        }
    }
}
