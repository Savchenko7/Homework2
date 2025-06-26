using System;

class Program
{
    static void Main()
    {
        string userName = "";
        bool isNameSet = false;

        // Приветственное сообщение при старте программы
        Console.WriteLine("Добро пожаловать в бот! Доступные команды: /start, /help, /info, /exit");

        while (true)
        {
            Console.Write("Введите команду: ");
            string inputCommand = Console.ReadLine().Trim(); // Убираем лишние пробелы

            if (inputCommand.StartsWith("/"))
            {
                HandleCommand(inputCommand, ref userName, ref isNameSet);
            }
            else
            {
                Console.WriteLine("Команда должна начинаться с символа '/'. Повторите попытку.");
            }
        }
    }

    private static void HandleCommand(string command, ref string userName, ref bool isNameSet)
    {
        var parts = command.Split(' ', 2); // Разделяем команду и её аргументы
        string cmd = parts.Length > 0 ? parts[0].ToLower() : "";
        string arg = parts.Length > 1 ? parts[1].Trim() : null;

        switch (cmd)
        {
            case "/start":
                if (!isNameSet)
                {
                    Console.Write("Введите ваше имя: ");
                    userName = Console.ReadLine().Trim();
                    isNameSet = true;
                    Console.WriteLine($"Привет, {userName}! Теперь вы можете использовать команды /help, /info и /echo.");
                }
                else
                {
                    Console.WriteLine($"{userName}, имя уже установлено ранее.");
                }
                break;

            case "/help":
                if (isNameSet)
                {
                    Console.WriteLine($"{userName}, справочная информация:\nДоступные команды:\n/start — начало работы\n/help — получение справки\n/info — информация о боте\n/echo — отображение введённого текста\n/exit — завершение работы");
                }
                else
                {
                    Console.WriteLine("Сначала представьтесь командой /start.");
                }
                break;

            case "/info":
                if (isNameSet)
                {
                    Console.WriteLine($"{userName}, версия программы: 1.0\nДата создания: июнь 2025");
                }
                else
                {
                    Console.WriteLine("Сначала представьтесь командой /start.");
                }
                break;

            case "/echo":
                if (isNameSet && !string.IsNullOrEmpty(arg))
                {
                    Console.WriteLine($"{userName}, вы ввели: '{arg}'");
                }
                else if (!isNameSet)
                {
                    Console.WriteLine("Сначала представьтесь командой /start.");
                }
                else
                {
                    Console.WriteLine($"{userName}, введите текст после команды /echo.");
                }
                break;

            case "/exit":
                if (isNameSet)
                {
                    Console.WriteLine($"{userName}, выход из программы. До свидания!");
                }
                else
                {
                    Console.WriteLine("До свидания!");
                }
                Environment.Exit(0); // Завершение приложения
                break;

            default:
                if (isNameSet)
                {
                    Console.WriteLine($"{userName}, неверная команда. Используйте доступные команды.");
                }
                else
                {
                    Console.WriteLine("Неверная команда. Сначала представьтесь командой /start.");
                }
                break;
        }
    }
}
