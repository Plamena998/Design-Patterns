public abstract class NotificationCreator
{
    public abstract Notification CreateNotification();

    public void Notify(string message)
    {
        Notification notification = CreateNotification();
        notification.Send(message);
    }
}