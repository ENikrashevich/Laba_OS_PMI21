using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_Никрашевич_ПМИ_21БО_3_вариант
{
    public class GetMoney : ICommand
    {
        private Bank _bank;
        private double _money;

        public GetMoney(Bank bank, double money)
        {
            _bank = bank;
            _money = money;
        }
        public void Execute()
        {
            _bank.Get(_money);
        }
        public void Undo()
        {
            _bank = null;
        }
    }
}
