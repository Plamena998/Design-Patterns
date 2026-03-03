public class PushCreator : NotificationCreator
{
    public override Notification CreateNotification()
    {
        return new PushNotification();
    }
}
