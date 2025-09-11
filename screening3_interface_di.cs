// Question: Complete the implementation to make this code follow SOLID principles.
// What pattern is being demonstrated here?

public interface IEmailService
{
    void SendEmail(string to, string message);
}

public class UserService
{
    // TODO: Fix this class to use dependency injection
    
    public void NotifyUser(string email, string message)
    {
        var emailService = new SmtpEmailService();
        emailService.SendEmail(email, message);
    }
}

public class SmtpEmailService : IEmailService
{
    public void SendEmail(string to, string message)
    {
        // Email implementation
    }
}