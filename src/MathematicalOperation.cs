using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_csharp
{
    public class MathematicalOperation : ICommand
    {
        private char _operator;
        private int _value;
        private Calculator _calculator;

        public MathematicalOperation(Calculator calculator, char operator_, int value)
        {
            this._calculator = calculator;
            this._operator = operator_;
            this._value = value;
        }

        public void Execute()
        {
            _calculator.ExecuteOperation(_operator, _value);
        }

        public void Back()
        {
            _calculator.ExecuteOperation(GetInverseOperator(_operator), _value);
        }

        private char GetInverseOperator(char operator_)
        {
            switch (operator_)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new Exception();
            }
        }
    }
}
