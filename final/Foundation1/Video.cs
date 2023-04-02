public class Video
{
    public string _title;
    public string _autor;
    public int _lengthSec;
    public List<Comment> _comments = new List<Comment>();

    public void CommentCount()
    {
        Console.WriteLine($"Total Comments: {_comments.Count}");
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Length: {_lengthSec} seconds");
        CommentCount();

        for (int i=0; i < _comments.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _comments[i].DisplayCommentList();
        }
        Console.WriteLine();
    }
}