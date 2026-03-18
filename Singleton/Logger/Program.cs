namespace LoggerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стартиране на програмата...\n");

            Logger logger1 = Logger.GetInstance();
            logger1.Log("Потребителят влезе в профила си.");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Потребителят промени паролата си.");

            if (ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("\nРЕЗУЛТАТ: logger1 и logger2 сочат към ЕДИН И СЪЩ обект в паметта!");
            }

            logger1.ShowHistory();
        }
    }
}
