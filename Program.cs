using System;
class Program
{
    static void Main(string[] args)
    {
        string userName = string.Empty;
        bool isNameSet = false;
        Console.WriteLine("Добро пожаловать в бот! Доступные команды: /start, /help, /info, /exit");
        while (true)
        {
            Console.Write("Введите команду: ");
            string command = Console.ReadLine();
            if (command == "/start")

            {
    Console.Write("Введите ваше имя: ");
    userName = Console.ReadLine();
    isNameSet = true;
    Console.WriteLine($"Привет, {userName}! Теперь вы можете использовать команды /help, /info и /echo.");
}
            else if (command == "/help")
{
    Console.WriteLine("Справка: Используйте команды /start для начала, /info для получения информации о программе, /echo для повторения текста и /exit для выхода.");
}
else if (command == "/info")
{
    Console.WriteLine("Версия программы: 1.0. Дата создания: Июнь 2025.");
}
else if (command.StartsWith("/echo") && isNameSet)
{
    string message = command.Substring(6); // Получаем текст после команды /echo
    Console.WriteLine(message);
}
else if (command == "/exit")
{
    Console.WriteLine("Выход из программы. До свидания!");
    break;
}
else
{
    Console.WriteLine("Неизвестная команда. Пожалуйста, используйте /help для получения списка команд.");
}
        }
    }
}