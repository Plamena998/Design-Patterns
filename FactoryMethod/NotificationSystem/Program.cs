NotificationCreator creator;

creator = new EmailCreator();
creator.Notify("Hello via Email!");

creator = new SmsCreator();
creator.Notify("Hello via SMS!");

creator = new PushCreator();
creator.Notify("Hello via Push!");