using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_Никрашевич_ПМИ_21БО_3_вариант
{
    public class Management
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
        public void UndoCommand()
        { 
            _command.Undo();
        }
    }
}
