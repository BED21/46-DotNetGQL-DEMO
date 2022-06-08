using DotNetGQL;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddFiltering()
    .AddSorting()
    .AddProjections();

builder.Services.AddDbContext<BlogsContext>(
        (s, opt) =>
            opt.UseSqlite($"Data Source=blogs.sqlite")
            .LogTo(Console.WriteLine, new[]
            {
                DbLoggerCategory.Database.Command.Name
            }));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetService<BlogsContext>();
    Seeder.CheckAndSeedAsync(context).Wait();
}

app.UseRouting();
app.MapGraphQL("/");

app.Run();
