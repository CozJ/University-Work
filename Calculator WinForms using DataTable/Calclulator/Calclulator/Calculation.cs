using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Calclulator
{
    class Calculation
    {
        private string expression;
        private bool isLastOperator = false;
        private Display Display = new Display();

        public void addNumber(char operand)
        {
            expression = Display.getDisplay() + (operand.ToString());
            Display.updateDisplay(expression);
            isLastOperator = false;
        }

        public void addOperator(char Operator)
        {
            if (isLastOperator != true)
            {
                expression = Display.getDisplay() + (Operator.ToString());
                Display.updateDisplay(expression);
                isLastOperator = true;
            }
        }

        public void ParseResult()
        {
            DataTable dt = new DataTable();
            var result = dt.Compute(expression,"");
            Display.clearDisplay();
            Display.updateDisplay(result.ToString());
        }

        public void undo()
        {
            Display.undo();
        }

        public void AllClear()
        {
            Display.clearDisplay();
        }

        public string DisplayValue()
        {
            return (Display.getDisplay());
        }
    }
}
