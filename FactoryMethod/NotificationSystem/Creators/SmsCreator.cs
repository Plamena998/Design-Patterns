public class SmsCreator : NotificationCreator
{
    public override Notification CreateNotification()
    {
        return new SmsNotification();
    }
}