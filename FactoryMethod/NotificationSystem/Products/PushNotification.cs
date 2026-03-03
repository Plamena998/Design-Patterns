public class PushNotification : Notification
{
    public override void Send(string message)
    {
        Console.WriteLine($"Sending PUSH notification: {message}");
    }
}