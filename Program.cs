using System;

namespace ConsoleFinancialAccounting
{
    class Program
    { 
        static void Main(string[] args)
        {
            bool activeApp = true;
              double expences = 0;
            double earnings = 0;
            double balance = 0;
            while (activeApp)
            {
                 Console.WriteLine("Оберiть операцiю: \n 1 - Внести витрату \n2 - Переглянути витрати \n3 - Внести дохiд \n4 - Переглянути доходи \n5 - Переглянути загальний баланс \n exit - Закрити програму");
                string operation = Console.ReadLine();

                switch (operation)
                {
                     case "1": 
                        EnterExpence(ref expences, ref balance); 
                        break;
                    case "2": ViewExpences(); break;
                    case "3": EnterEarning(ref earnings, ref balance); break;
                    case "4": ViewEarnings(); break;
                    case "5": ViewBalance(); break;
                    case "exit": activeApp = false; break;
                    default: Console.WriteLine("Ви не обрали операцiю"); break;
                }

                 void EnterExpence(ref double allExpences, ref double fullBalance)
                {
                    Console.WriteLine("Введiть суму:");
                    double newExpence = Convert.ToDouble(Console.ReadLine());
                    allExpences += newExpence;
                    fullBalance -= newExpence;
                }

                void ViewExpences()
                {
                    Console.WriteLine($"Cума витрат: {expences}");
                }
                void EnterEarning(ref double allEarnings, ref double fullBalance)
                {
                    Console.WriteLine("Введiть суму:");
                    double newExpence = Convert.ToDouble(Console.ReadLine());
                    allEarnings += newExpence;
                    fullBalance += newExpence;
                }

                void ViewEarnings()
                {
                    Console.WriteLine($"Cума доходiв: {earnings}");
                }
                void ViewBalance()
                {
                    Console.WriteLine($"Баланс: {balance}");
                }
            }
        }
    }
}
