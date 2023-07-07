namespace Demo.GraphQL;

public class Mutation
{
    public UserPayload CreateUser(User user, [Service] UserRepository repository)
    {
        var createdUser = repository.CreateUser(user);
        return new UserPayload(createdUser, "User successfully created.");
    }

    public UserPayload UpdateUser(User user, [Service] UserRepository repository)
    {
        var updatedUser = repository.UpdateUser(user.Id, user);
        return new UserPayload(updatedUser, "User successfully updated.");
    }

    public UserPayload DeleteUser(int id, [Service] UserRepository repository)
    {
        var deletedUser = repository.DeleteUser(id);
        return new UserPayload(deletedUser, "User successfully deleted.");
    }
}