using Demo.GraphQL;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<UserRepository>();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscription>()
    .AddRedisSubscriptions((sp) => 
        ConnectionMultiplexer.Connect(builder.Configuration["RedisConnection"]));

builder.Services
    .AddAWSLambdaHosting(LambdaEventSource.HttpApi);

var app = builder.Build();

//app.UseWebSockets();
app.MapGraphQL();

app.Run();