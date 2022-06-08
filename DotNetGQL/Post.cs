namespace DotNetGQL;
public class Post
{
    public int Id { get; set; }
    public DateTime Posted { get; set; }
    public string Title { get; set; }
    public Blog Blog { get; set; }
}
