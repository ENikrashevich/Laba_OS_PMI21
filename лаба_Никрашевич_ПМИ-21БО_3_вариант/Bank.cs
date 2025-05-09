using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace лаба_Никрашевич_ПМИ_21БО_3_вариант
{
    public class Bank
    {
        public double balance;
        public Bank()
        { 
            balance = 0.0;
        }

        public void Insert(double money) // пополнение
        {
            balance += money;
        }

        public void Get(double money) // снятие
        {
            if (balance < money)
                Console.WriteLine("Операция невозможна");
            else
            {
                balance -= money;
                Console.WriteLine("Снятие произведено успешно");
            }
        }

        public void PayCellularNetwork() // оплата сотовой связи
        {
            if (balance < 350)
                Console.WriteLine("Операция невозможна");
            else
            {
                balance -= 350;
                Console.WriteLine("Оплата прошла успешно");
            }
        }

        public void PayGasSupply() // оплата газоснабжения
        {
            if (balance < 1500)
                Console.WriteLine("Операция невозможна");
            else
            {
                balance -= 1500;
                Console.WriteLine("Оплата прошла успешно");
            }
        }

        public void PayWaterSupply() // оплата водоснабжения
        {
            if (balance < 1200)
                Console.WriteLine("Операция невозможна");
            else
            {
                balance -= 1200;
                Console.WriteLine("Оплата прошла успешно");
            }
        }

        public void PayPowerSupply() // оплата электроснабжения
        {
            if (balance < 2000)
                Console.WriteLine("Операция невозможна");
            else
            {
                balance -= 2000;
                Console.WriteLine("Оплата прошла успешно");
            }
        }
    }
}
