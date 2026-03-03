public class SmsNotification : Notification
{
    public override void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}