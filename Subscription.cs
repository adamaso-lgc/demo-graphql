using System.Runtime.CompilerServices;
using HotChocolate.Subscriptions;

namespace Demo.GraphQL;

public class Subscription
{
    public async IAsyncEnumerable<User> OnUserCreatedStream([Service] ITopicEventReceiver eventReveicer, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var sourceStream =
            await eventReveicer.SubscribeAsync<User>(nameof(Mutation.CreateUser), cancellationToken);
        
        yield return new User(3, "gamePlatformId3", "iLab", "technology", "John", "Veevers");

        await Task.Delay(5000, cancellationToken);

        await foreach (var user in sourceStream.ReadEventsAsync())
        {
            yield return user;
        }
        
    }

    [Subscribe(With = nameof(OnUserCreatedStream))]
    public User OnUserCreated([EventMessage] User userCreated)
        => userCreated;
}