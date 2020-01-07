using System;

namespace Tema_11._1_UnitTesting_Ex2
{
    public class Calculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Sub(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Mul(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Div(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new ArgumentException("Cannot divide by 0!");
            }
            return number1 / number2;
        }
    }
}
