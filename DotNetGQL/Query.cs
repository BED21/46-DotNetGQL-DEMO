namespace DotNetGQL;
public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Blog> GetBlogs([Service] BlogsContext context) => context.Blogs;

    //public IQueryable<Blog> GetBlogs()
    //{

        //var blog = new Blog
        //{
        //    Id = 1,
        //    Name = "Developer for Life",
        //    Url = "https://blog.jeremylikness.com",
        //    Posts = new List<Post>
        //    {
        //        new Post
        //        {
        //            Id = 1,
        //            Title = "GraphQL on .NET",
        //            Posted = DateTime.UtcNow.AddDays(-1)
        //        }
        //    }
        //};

        //blog.Posts[0].Blog = blog;
        //return new[] { blog }.AsQueryable();
    //}
}
