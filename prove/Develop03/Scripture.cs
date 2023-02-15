


public class Scripture
{
    private string _book;
    private int _chapter;
    private List<Verse> _verses;

    // Declare getter and setter
    public string Book { get { return _book; } }
    public int Chapter { get { return _chapter; } }
    public List<Verse> Verses { get { return _verses; } }

    public Scripture(string book, int chapter, List<Verse> verses)
    {
        _book = book;
        _chapter = chapter;
        _verses = verses;
    }
    
    public string GetReference()
    { // return the Reference of the scripture and not the Text
        if (_verses.Count == 1)
        {
            return $"{_book} {_chapter}:{_verses[0].VerseNumber}";
        }
        else
        {
            return $"{_book} {_chapter}: {_verses[0].VerseNumber} - {_verses[_verses.Count-1].VerseNumber}";
        }
    }
}