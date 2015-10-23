using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_csharp
{
    public class Mathematical
    {
        private Calculator _calculator = new Calculator();
        private List<ICommand> _commands = new List<ICommand>();
        private int _current = 0;

        public void BackOperations(int numberOfOperations)
        {
            Console.WriteLine("\n---- Desfazendo {0} operações matemáticas \n", numberOfOperations);

            for (int i = 0; i < numberOfOperations; i++)
            {
                if (_current > 0)
                {
                    ICommand command = _commands[--_current];
                    command.Back();
                    _commands.Remove(command);
                }
            }
            Console.WriteLine("\n---- {0} operações matemáticas desfeitas \n", numberOfOperations);
        }

        public void ExecuteOperation(char operator_, int value)
        {
            ICommand comando = new MathematicalOperation(_calculator, operator_, value);
            comando.Execute();

            _commands.Add(comando);
            _current++;
        }
    }
}
