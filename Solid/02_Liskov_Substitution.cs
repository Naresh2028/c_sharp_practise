using System;

namespace C_Sharp_Concepts_And_OOP.Solid
{
    // 3. Liskov Substitution Principle (LSP)
    // A derived class should be able to replace its base class without breaking the application.
    public class MainClass
    {
        // Step 4: Demonstrate that derived classes can replace the base class.
        public void DemonstrateLSP()
        {
            SendNotification(new Notification());
            SendNotification(new EmailNotification());
            SendNotification(new SmsNotification());
        }

        // Step 3: Accept the base class so any valid derived class can be used.
        public void SendNotification(Notification notify)
        {
            notify.Send();
        }
    }

    // Step 1: Create a base class.
    public class Notification
    {
        public virtual void Send()
        {
            Console.WriteLine("Sending Notification");
        }
    }

    // Step 2: Create derived classes.
    public class EmailNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Sending Email Notification");
        }
    }

    public class SmsNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Sending SMS Notification");
        }
    }
}