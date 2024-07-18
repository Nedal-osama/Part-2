namespace Part_2
{
    using System;

    #region Q1
    /*  public interface IShape
      {
          double Area { get; }
          void DisplayShapeInfo();
      }


      public interface ICircle : IShape
      {
      }

      public interface IRectangle : IShape
      {
      }


      public class Circle : ICircle
      {
          private double radius;

          public Circle(double radius)
          {
              this.radius = radius;
          }

          public double Area
          {
              get { return Math.PI * radius * radius; }
          }

          public void DisplayShapeInfo()
          {
              Console.WriteLine("Circle with radius " + radius);
          }
      }


      public class Rectangle : IRectangle
      {
          private double length;
          private double width;

          public Rectangle(double length, double width)
          {
              this.length = length;
              this.width = width;
          }

          public double Area
          {
              get { return length * width; }
          }

          public void DisplayShapeInfo()
          {
              Console.WriteLine("Rectangle with length " + length + " and width " + width);
          }
      }*/
    #endregion

    #region Q2
    /*  public interface IAuthenticationService
      {
          bool AuthenticateUser(string username, string password);
          bool AuthorizeUser(string username, string role);
      }


      public class BasicAuthenticationService : IAuthenticationService
      {
          private string storedUsername;
          private string storedPassword;
          private string storedRole;

          public BasicAuthenticationService(string username, string password, string role)
          {
              storedUsername = username;
              storedPassword = password;
              storedRole = role;
          }

          public bool AuthenticateUser(string username, string password)
          {
              return username == storedUsername && password == storedPassword;
          }

          public bool AuthorizeUser(string username, string role)
          {
              return username == storedUsername && role == storedRole;
          }
      }*/
    #endregion

    #region Q3
    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine("Sending email to " + recipient + ": " + message);
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine("Sending SMS to " + recipient + ": " + message);
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine("Sending push notification to " + recipient + ": " + message);
        }
    }

    #endregion

    class Program
    {
        static void Main( string[] args)
        {
            #region Q1
            /*   Circle circle = new Circle(5.0);
               Rectangle rectangle = new Rectangle(4.0, 6.0);

               circle.DisplayShapeInfo();
               Console.WriteLine("Area: " + circle.Area);
               Console.WriteLine();

               rectangle.DisplayShapeInfo();
               Console.WriteLine("Area: " + rectangle.Area);*/
            #endregion
            #region Q2
            /*  IAuthenticationService authService = new BasicAuthenticationService("admin", "password", "admin");

              string username = "admin";
              string password = "password";
              string role = "admin";

              if (authService.AuthenticateUser(username, password) && authService.AuthorizeUser(username, role))
              {
                  Console.WriteLine("User is authenticated and authorized.");
              }
              else
              {
                  Console.WriteLine("User is not authenticated or authorized.");
              }*/
            #endregion
            #region Q3
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("Nedal@gmail", "Email message");
            smsService.SendNotification("01141638796", "SMS message");
            pushService.SendNotification("1234567", "Push notification message");
            #endregion

        }
    }
}
