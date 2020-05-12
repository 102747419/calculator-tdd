using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public abstract class Operator
    {
        private static Dictionary<string, Type> _operators = new Dictionary<string, Type>();

        public static void RegisterOperator(string op, Type t)
        {
            _operators[op] = t;
        }

        public static double Calculate(double first, string op, double second)
        {
            Operator opInstance = CreateOperator(op);
            return opInstance.Calculate(first, second);
        }

        public static bool OperatorExists(string op)
        {
            return _operators.Keys.Contains(op);
        }

        private static Operator CreateOperator(string op)
        {
            return (Operator) Activator.CreateInstance(_operators[op]);
        }

        public abstract double Calculate(double first, double second);
    }
}
