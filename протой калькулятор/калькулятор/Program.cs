using System;
using System.Globalization;
using System.Threading;

namespace калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0,
                  a1 = 0,
                  sum = 0;
            int i = 0;

            Console.WriteLine("Начало программы");
            Console.WriteLine();

            for (; ;)
            {
                for (; ; )
                {
                    Console.WriteLine("Введите число А");
                    string ch = Console.ReadLine();

                    bool result = float.TryParse(ch, out a);
                    if (result == true)
                    {
                        break;
                    }
                    else
                    {
                        try
                        {
                            a = float.Parse(ch, CultureInfo.InvariantCulture.NumberFormat);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Проверьте число А");
                        }
                    }
                }

                Console.WriteLine();

                for (; ; )
                {
                    Console.WriteLine("Введите число B");
                    string ch = Console.ReadLine();

                    bool result = float.TryParse(ch, out a1);
                    if (result == true)
                    {
                        break;
                    }
                    else
                    {
                        try
                        {
                            a1 = float.Parse(ch, CultureInfo.InvariantCulture.NumberFormat);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Проверьте число B");
                        }
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Введите знаком, что требуется сделать с числами (+,-,*,/)");
                for (;i < 1;)
                {
                    string vibor = Console.ReadLine();
                    
                    switch (vibor)
                    {
                        case "+":
                            sum = a + a1;
                            i++;
                            break;
                        case "-":
                            sum = a - a1;
                            i++;
                            break;
                        case "*":
                            sum = a * a1;
                            i++;
                            break;
                        case "/":
                            sum = a / a1;
                            i++;
                            break;
                        default:
                            Console.WriteLine("Вы ввели не верное значение");
                            break;

                    }
                }

                i = 0;
                Console.WriteLine("Вывод  "+sum);

                Console.WriteLine();

                Console.WriteLine("Закончить работу прогрммы?");
                string ActUser = Console.ReadLine();
                switch (ActUser)
                {
                    case "Да":
                        Console.WriteLine("Конец программы");
                        Environment.Exit(0);
                        break;
                    case "да":
                        Console.WriteLine("Конец программы");
                        Environment.Exit(0);
                        break;
                    case "Lf":
                        Console.WriteLine("Конец программы");
                        Environment.Exit(0);
                        break;
                    case "lf":
                        Console.WriteLine("Конец программы");
                        Environment.Exit(0);
                        break;
                    case "LF":
                        Console.WriteLine("Конец программы");
                        Environment.Exit(0);
                        break;
                    case "ДА":
                        Console.WriteLine("Конец программы");
                        Environment.Exit(0);
                        break;
                    default:
                        for(int t = 0; t < 4; t++)
                        {
                            Console.Clear();
                            Console.WriteLine("Перезапуск программы");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                        }
                        break;
                        
                }
            }
        }
    }
}
