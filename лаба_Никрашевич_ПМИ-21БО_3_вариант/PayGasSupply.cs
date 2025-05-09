using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_Никрашевич_ПМИ_21БО_3_вариант
{
    public class PayGasSupply : ICommand
    {
        private Bank _bank;

        public PayGasSupply(Bank bank)
        {
            _bank = bank;
        }
        public void Execute()
        {
            _bank.PayGasSupply();
        }
        public void Undo()
        {
            _bank = null;
        }
    }
}
