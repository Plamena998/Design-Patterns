public class EmailCreator : NotificationCreator
{
    public override Notification CreateNotification()
    {
        return new EmailNotification();
    }
}