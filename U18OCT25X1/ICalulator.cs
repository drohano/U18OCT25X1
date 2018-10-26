using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U18OCT25X1
{
    public interface ICalulator
    {
        decimal Add(decimal number1, decimal number2);
        decimal Sub(decimal number1, decimal number2);
        decimal Div(decimal number1, decimal number2);
        decimal Mult(decimal number1, decimal number2);
    }
}
