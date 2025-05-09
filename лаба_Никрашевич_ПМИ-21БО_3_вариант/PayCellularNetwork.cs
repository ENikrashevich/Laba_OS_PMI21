using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_Никрашевич_ПМИ_21БО_3_вариант
{
    public class PayCellularNetwork : ICommand
    {
        private Bank _bank;

        public PayCellularNetwork(Bank bank)
        {
            _bank = bank;
        }
        public void Execute()
        {
            _bank.PayCellularNetwork();
        }
        public void Undo()
        {
            _bank = null;
        }
    }
}
