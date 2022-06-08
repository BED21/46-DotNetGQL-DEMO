namespace DotNetGQL;
public class Blog
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }

    [UseFiltering]
    [UseSorting]
    public IList<Post> Posts { get; set; }
}
