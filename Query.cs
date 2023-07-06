namespace Demo.GraphQL;

public class Query
{
    public User? GetUserById(int id, [Service] UserRepository repository)
        => repository.GetById(id);

    public IEnumerable<User> GetUsers([Service] UserRepository repository)
        => repository.GetAllUsers();
}