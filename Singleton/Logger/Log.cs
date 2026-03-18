using System;
using System.Collections.Generic;

public class Logger
{
    private static Logger _instance;

    private List<string> _logHistory;// = new List<string>();

    private Logger()
    {
        _logHistory = new List<string>();
        Console.WriteLine("--- Logger: Инициализиран за първи (и единствен) път. ---");
    }
    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    public void Log(string message)
    {
        string entry = $"[{DateTime.Now:HH:mm:ss}] {message}";
        _logHistory.Add(entry);
        Console.WriteLine($"Записано: {entry}");
    }

    public void ShowHistory()
    {
        Console.WriteLine("\n--- Пълна история на лога: ---");
        foreach (var log in _logHistory)
        {
            Console.WriteLine(log);
        }
    }
}