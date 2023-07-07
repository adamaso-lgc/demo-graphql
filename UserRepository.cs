namespace Demo.GraphQL;

public sealed class UserRepository
{
    private readonly Dictionary<int, User> _users = new()
    {
        [1] = new User(1, "gamePlatformId1", "iLab", "technology", "André", "Dâmaso"),
        [2] = new User(2, "gamePlatformId2", "iLab", "technology", "André", "Braga"),
        [3] = new User(3,"gamePlatformId3", "iLab", "technology", "John", "Veevers"),
    };

    public User? GetById(int id)
        => _users.TryGetValue(id, out var user) ? user : null;

    public IEnumerable<User> GetAllUsers()
        => _users.Values;
    
    public User CreateUser(User user)
    {
        _users[user.Id] = user;
        return user;
    }

    public User UpdateUser(int id, User user)
    {
        if (_users.ContainsKey(id))
        {
            _users[id] = user;
        }
        else
        {
            throw new Exception($"User with id {id} does not exist.");
        }

        return user;
    }

    public User DeleteUser(int id)
    {
        if (_users.TryGetValue(id, out User value))
        {
            _users.Remove(id);
            return value;
        }
        else
        {
            throw new Exception($"User with id {id} does not exist.");
        }
    }

}