using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    public class CalculatorFixture
    {
        public Calculator.Calculator calculator { get; set; }
        public CalculatorFixture()
        {
            calculator = new Calculator.Calculator();
        }
    }
}
