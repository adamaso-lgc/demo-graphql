namespace Demo.GraphQL;

public class UserPayload
{
    public UserPayload(User user, string? message = null)
    {
        User = user;
        Message = message;
    }

    public User User { get; }
    public string? Message { get; }
}