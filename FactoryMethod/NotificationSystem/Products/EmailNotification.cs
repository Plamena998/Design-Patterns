public class EmailNotification : Notification
{
    public override void Send(string message)
    {
        Console.WriteLine($"Sending EMAIL: {message}");
    }
}