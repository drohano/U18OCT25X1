using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U18OCT25X1
{
    public class Calculate : ICalulator
    {
        public decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        public decimal Div(decimal number1, decimal number2)
        {
            return number1 / number2;
        }

        public decimal Mult(decimal number1, decimal number2)
        {
            return number1 * number2;
        }

        public decimal Sub(decimal number1, decimal number2)
        {
            return number1 - number2;
        }
    }
}
