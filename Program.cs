using Demo.GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<UserRepository>();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL();

app.Run();