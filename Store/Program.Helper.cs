using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.CMD
{
    public partial class Program
    {
        private static string ReadNotEmptyLine(string title)
        {
            while (true)
            {
                Console.Write($"Введите {title}: ");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }

                WriteErrorMessage($"Значение {title} не должен быть пустым");
            }
        }

        private static int ReadIntLine(string title)
        {
            while (true)
            {
                var input = ReadNotEmptyLine(title);
                if (int.TryParse(input, out int result))
                {
                    return result;
                }

                WriteErrorMessage($"Введите целое число");
            }
        }

        private static void WriteErrorMessage(string message)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ОШИБКА! {message}");
            Console.ForegroundColor = color;
        }

        private static Command ReadCommand()
        {
            while (true)
            {
                var input = ReadNotEmptyLine("команду");
                if (Enum.TryParse(input, true, out Command command))
                {
                    return command;
                }

                WriteErrorMessage("Не известная команда. Введите help для подсказки");
            }
        }

        private static void WriteHelpMessage()
        {
            Console.WriteLine($"{Command.AddComputer} - Добавить новый компьютер;");
            Console.WriteLine($"{Command.GetAllComputer} - Вывести полный список компьютеров;");
            Console.WriteLine($"{Command.GetAllComputerFromShoppingCart} - Вывести полный список компьютеров из своей корзины;");
            Console.WriteLine($"{Command.SellComputer} - Продать компьютер;");
            Console.WriteLine($"{Command.Exit} - Выход из приложения;");
            Console.WriteLine($"{Command.Help} - Помощь;");
            Console.WriteLine();
        }

    }
}
