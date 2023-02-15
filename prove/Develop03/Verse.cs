


public class Verse
{
    private int _verseNumber;
    private string _text;

    // Declare getter and setter
    public int VerseNumber { get { return _verseNumber; } }
    public string Text { get { return _text; } }

    // Contructor for if there more than 2 verses
    public Verse(int verseNumber, string text)
    {
        _verseNumber = verseNumber;
        _text = text;
    }
    // Contructor for one verse
    public Verse(string text)
    {
        _verseNumber = 1;
        _text = text;
    }
}