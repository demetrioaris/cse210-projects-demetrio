


public class Assignment
{
    private  string _studentName = "";
    private string _topic = "";

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
    // public void SetStudentName(string studentName)
    // {
    //     studentName = _studentName;
    // }
        public string GetTopic()
    {
        return _topic;
    }
    // public void SetTopic(string topic)
    // {
    //     topic = _studentName;
    // }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}