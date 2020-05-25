using System;

namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {
            Operator.RegisterOperator("%", typeof(Modulo));
            Operator.RegisterOperator("+", typeof(Addition));

        }

        public void Calculate()
        {
            decimal first = AskForNumber("First number: ");
            string op = AskForOperator("Operator: ");
            decimal second = AskForNumber("Second number: ");

            decimal result = Operator.Calculate(first, op, second);
            Console.WriteLine($"Result: {first} {op} {second} = {result}");
        }

        private decimal AskForNumber(string prompt)
        {
            decimal value;
            bool valid;

            do
            {
                Console.Write(prompt);
                valid = decimal.TryParse(Console.ReadLine().Trim(), out value);
                if (!valid)
                {
                    Console.WriteLine("Invalid number");
                }
            } while (!valid);

            return value;
        }

        private string AskForOperator(string prompt)
        {
            string op;

            do
            {
                Console.Write(prompt);
                op = Console.ReadLine().Trim();
                if (!Operator.OperatorExists(op))
                {
                    Console.WriteLine("Invalid operator");
                }
            } while (!Operator.OperatorExists(op));

            return op;
        }
    }
}
