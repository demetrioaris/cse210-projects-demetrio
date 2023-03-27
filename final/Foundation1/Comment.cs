public class Comment
{
    public string _name;
    public string _commentText;
    public void DisplayCommentList()
    {
        Console.WriteLine($" Name: {_name} - {_commentText}");
    }
}