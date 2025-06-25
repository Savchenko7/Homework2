using System;

string userName = "";
bool isNameSet = false;

// Приветственное сообщение при старте программы
Console.WriteLine("Добро пожаловать в бот! Доступные команды: /start, /help, /info, /exit");

while (true)
{
    Console.Write("Введите команду: ");
    string inputCommand = Console.ReadLine().Trim(); // Убираем лишние пробелы

    switch (inputCommand)
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
                Console.WriteLine("Имя уже установлено ранее.");
            }
            break;

        case "/help":
            Console.WriteLine("Справка:\nИспользуйте команды:\n/start — начать работу\n/info — информация о программе\n/echo — повторить введённый текст\n/exit — выход из программы");
            break;

        case "/info":
            Console.WriteLine("Версия программы: 1.0\nДата создания: июнь 2025");
            break;

        case "/echo":
            if (isNameSet)
            {
                Console.Write("Введите текст для эха: ");
                string echoText = Console.ReadLine().Trim();
                Console.WriteLine(echoText);
            }
            else
            {
                Console.WriteLine("Сначала представьтесь командой /start.");
            }
            break;

        case "/exit":
            Console.WriteLine("Выход из программы. До свидания!");
            return; // Завершаем выполнение программы

        default:
            Console.WriteLine("Неизвестная команда. Попробуйте снова.");
            break;
    }
}
