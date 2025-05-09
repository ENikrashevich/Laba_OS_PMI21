using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_Никрашевич_ПМИ_21БО_3_вариант
{
    public class Display
    {
        public string state = "";
        public double tmp = 0.0;
        public int statePay = 0;
        Random random = new Random();
        public void display(double money, Bank bank, Management manage)
        {
            while(true) 
            {
                Console.WriteLine("Текущий счет: " + bank.balance);
                Console.WriteLine("Выберите операцию");
                Console.WriteLine("1. Внесение средств");
                Console.WriteLine("2. Снятие средств");
                Console.WriteLine("3. Оплата");
                Console.WriteLine("4. Выход из системы");
                state = Console.ReadLine();
                switch (state)
                {
                    case "1":
                        Console.WriteLine("Введите сумму");
                        tmp = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("Пополнение счета на " + tmp);
                        Console.WriteLine("Ожидание подтверждения пополнения");
                        if(random.Next(0, 100) == 1)
                        {
                            Console.WriteLine("Обнаружены фальшивые деньги, прекращение работы");
                            return;
                        }
                        Console.WriteLine("Все купюры прошли проверку");
                        Console.WriteLine("Печать чека");
                        Console.WriteLine("Счет был пополнен на " + tmp);
                        Console.WriteLine("\n");
                        InsertMoney Ins = new InsertMoney(bank, tmp);
                        manage.SetCommand(Ins);
                        manage.PressButton();
                        Console.WriteLine("\n");
                        break;
                    case "2":
                        if (bank.balance == 0)
                        {
                            Console.WriteLine("Проверка счета клиента");
                            Console.WriteLine("Невозможно произвести операцию");
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("Введите сумму до " + bank.balance);
                            tmp = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Проверка счета клиента");
                            Console.WriteLine("Списание суммы");
                            Console.WriteLine("Ожидание подтверждения списания");
                            Console.WriteLine("Выдача суммы " + tmp);
                            Console.WriteLine("Печать чека");
                            Console.WriteLine("Со счета списано " + tmp);
                            GetMoney Get = new GetMoney(bank, tmp);
                            manage.SetCommand(Get);
                            manage.PressButton();
                            Console.WriteLine("\n");
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n");
                        if (bank.balance < 350)
                        {
                            Console.WriteLine("Невозможно произвести операцию");
                            Console.WriteLine("\n");
                        }
                        else if (bank.balance >= 350 && bank.balance <= 1200)
                        {
                            Console.WriteLine("Текущий счет: " + bank.balance);
                            Console.WriteLine("Выберите что оплатить:");
                            Console.WriteLine("1. Сотовая связь - 350 рублей");
                            Console.WriteLine("2. Отмена операции");
                            statePay = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            displayPay1(statePay, bank, manage);
                            Console.WriteLine("\n");
                        }
                        else if(bank.balance >= 1200 && bank.balance <= 1500)
                        {

                            Console.WriteLine("Текущий счет: " + bank.balance);
                            Console.WriteLine("Выберите что оплатить:");
                            Console.WriteLine("1. Сотовая связь - 350 рублей");
                            Console.WriteLine("2. Водоснабжение - 1200 рублей");
                            Console.WriteLine("3. Отмена операции");
                            statePay = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            displayPay2(statePay, bank, manage);
                            Console.WriteLine("\n");
                        }
                        else if(bank.balance >= 1500 && bank.balance <= 2000)
                        {
                            Console.WriteLine("Текущий счет: " + bank.balance);
                            Console.WriteLine("Выберите что оплатить:");
                            Console.WriteLine("1. Сотовая связь - 350 рублей");
                            Console.WriteLine("2. Водоснабжение - 1200 рублей");
                            Console.WriteLine("3. Газоснабжение - 1500 рублей");
                            Console.WriteLine("4. Отмена операции");
                            statePay = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            displayPay3(statePay, bank, manage);
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("Текущий счет: " + bank.balance);
                            Console.WriteLine("Выберите что оплатить:");
                            Console.WriteLine("1. Сотовая связь - 350 рублей");
                            Console.WriteLine("2. Водоснабжение - 1200 рублей");
                            Console.WriteLine("3. Газоснабжение - 1500 рублей");
                            Console.WriteLine("4. Электроснабжение - 2000 рублей");
                            Console.WriteLine("5. Отмена операции");
                            statePay = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            displayPay4(statePay, bank, manage);
                            Console.WriteLine("\n");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Выход из системы");
                        return;
                }
            }
        }
        public void displayPay1(int state, Bank bank, Management manage)
        {
            switch (state)
            {
                case 1:
                    Console.WriteLine("Проверка счета клиента");
                    Console.WriteLine("Списание суммы");
                    Console.WriteLine("Ожидание подтверждения платежа");
                    Console.WriteLine("Печать чека");
                    PayCellularNetwork PSN = new PayCellularNetwork(bank);
                    manage.SetCommand(PSN);
                    manage.PressButton();
                    Console.WriteLine("Со счета списано 350 рублей на оплату сотовой связи");
                    break;
                case 2:
                    manage.UndoCommand();
                    break;
                default:
                    Console.WriteLine("Неверно выбранная операция");
                    break;
            }
        }
        public void displayPay2(int state, Bank bank, Management manage)
        {
            switch (state)
            {
                case 1:
                    Console.WriteLine("Проверка счета клиента");
                    Console.WriteLine("Списание суммы");
                    Console.WriteLine("Ожидание подтверждения платежа");
                    Console.WriteLine("Печать чека");
                    PayCellularNetwork PSN = new PayCellularNetwork(bank);
                    manage.SetCommand(PSN);
                    manage.PressButton();
                    Console.WriteLine("Со счета списано 350 рублей на оплату сотовой связи");
                    break;
                case 2:
                    Console.WriteLine("Проверка счета клиента");
                    Console.WriteLine("Списание суммы");
                    Console.WriteLine("Ожидание подтверждения платежа");
                    Console.WriteLine("Печать чека");
                    PayWaterSupply PWS = new PayWaterSupply(bank);
                    manage.SetCommand(PWS);
                    manage.PressButton();
                    Console.WriteLine("Со счета списано 1200 рублей на оплату водоснабжения");
                    break;
                case 3:
                    manage.UndoCommand();
                    break;
                default:
                    Console.WriteLine("Неверно выбранная операция");
                    break;
            }
        }
        public void displayPay3(int state, Bank bank, Management manage)
        {
            switch (state)
            {
                case 1:
                    Console.WriteLine("Проверка счета клиента");
                    Console.WriteLine("Списание суммы");
                    Console.WriteLine("Ожидание подтверждения платежа");
                    Console.WriteLine("Печать чека");
                    PayCellularNetwork PSN = new PayCellularNetwork(bank);
                    manage.SetCommand(PSN);
                    manage.PressButton();
                    Console.WriteLine("Со счета списано 350 рублей на оплату сотовой связи");
                    break;
                case 2:
                    Console.WriteLine("Проверка счета клиента");
                    Console.WriteLine("Списание суммы");
                    Console.WriteLine("Ожидание подтверждения платежа");
                    Console.WriteLine("Печать чека");
                    PayWaterSupply PWS = new PayWaterSupply(bank);
                    manage.SetCommand(PWS);
                    manage.PressButton();
                    Console.WriteLine("Со счета списано 350 рублей на оплату водоснабжения");
                    break;
                case 3:
                    Console.WriteLine("Проверка счета клиента");
                    Console.WriteLine("Списание суммы");
                    Console.WriteLine("Ожидание подтверждения платежа");
                    Console.WriteLine("Печать чека");
                    PayGasSupply PGS = new PayGasSupply(bank);
                    manage.SetCommand(PGS);
                    manage.PressButton();
                    Console.WriteLine("Со счета списано 350 рублей на газоснабжения");
                    break;
                case 4:
                    manage.UndoCommand();
                    break;
                default:
                    Console.WriteLine("Неверно выбранная операция");
                    break;
            }
        }
        public void displayPay4(int state, Bank bank, Management manage)
        {
            switch (state)
            {
                case 1:
                    Console.WriteLine("Проверка счета клиента");
                    Console.WriteLine("Списание суммы");
                    Console.WriteLine("Ожидание подтверждения платежа");
                    Console.WriteLine("Печать чека");
                    PayCellularNetwork PSN = new PayCellularNetwork(bank);
                    manage.SetCommand(PSN);
                    manage.PressButton();
                    Console.WriteLine("Со счета списано 350 рублей на оплату сотовой связи");
                    break;
                case 2:
                    Console.WriteLine("Проверка счета клиента");
                    Console.WriteLine("Списание суммы");
                    Console.WriteLine("Ожидание подтверждения платежа");
                    Console.WriteLine("Печать чека");
                    PayWaterSupply PWS = new PayWaterSupply(bank);
                    manage.SetCommand(PWS);
                    manage.PressButton();
                    Console.WriteLine("Со счета списано 1200 рублей на оплату водоснабжения");
                    break;
                case 3:
                    Console.WriteLine("Проверка счета клиента");
                    Console.WriteLine("Списание суммы");
                    Console.WriteLine("Ожидание подтверждения платежа");
                    Console.WriteLine("Печать чека");
                    PayGasSupply PGS = new PayGasSupply(bank);
                    manage.SetCommand(PGS);
                    manage.PressButton();
                    Console.WriteLine("Со счета списано 1500 рублей на оплату газоснабжения");
                    break;
                case 4:
                    Console.WriteLine("Проверка счета клиента");
                    Console.WriteLine("Списание суммы");
                    Console.WriteLine("Ожидание подтверждения платежа");
                    Console.WriteLine("Печать чека");
                    PayPowerSupply PPS = new PayPowerSupply(bank);
                    manage.SetCommand(PPS);
                    manage.PressButton();
                    Console.WriteLine("Со счета списано 2000 рублей на оплату электроснабжения");
                    break;
                case 5:
                    manage.UndoCommand();
                    break;
                default:
                    Console.WriteLine("Неверно выбранная операция");
                    break;
            }
        }
    }
}
