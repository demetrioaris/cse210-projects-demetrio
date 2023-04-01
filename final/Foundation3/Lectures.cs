
public class Lectures : Event
{
    private string _speaker;
    private int _capacity;
    public Lectures(string speaker, int capacity) 
    : base()
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public string GetLecturesInformation()
    {
        return $"Type of Event Lectures \nMore information about the event \nSpeaker name: {_speaker}\nCapacity: {_capacity}";
    }
}