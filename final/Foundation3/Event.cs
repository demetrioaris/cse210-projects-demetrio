public class Event
{
    private string _title;
    private string _description;
    private string _dateEvent;
    private string _timeEvent;
    private string _typeOfEvent;
    private List<Address> _address = new List<Address>();
    private List<Lectures> _lectures = new List<Lectures>();
    private List<Receptions> _receptions = new List<Receptions>();
    private List<Outdoor> _outdoor = new List<Outdoor>();
    public Event(string title, string description, string dateEvent, string timeEvent, string typeOfEvent)
    {
        _title = title;
        _description = description;
        _dateEvent = dateEvent;
        _timeEvent = timeEvent;
        _typeOfEvent = typeOfEvent;
    }
    public Event(){}

    public string GetTitle() 
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetDescription() 
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDateEvent()
    {
        return _dateEvent;
    }
    public void SetDateEvent(string dateEvent)
    {
        _dateEvent = dateEvent;
    }
    public string GetTimeEvent() 
    {
        return _timeEvent;
    }
    public void SetTimeEvent(string timeEvent)
    {
        _timeEvent = timeEvent;
    }
    public string GetTypeOfEvent()
    {
        return _typeOfEvent;
    }
    public void SetTypeOfEvent(string typeOfEvent)
    {
        _typeOfEvent = typeOfEvent;
    }
    public List<Address> GetAddress()
    {
        return _address;
    }
    public void SetAddress(List<Address> address)
    {
        _address = address;
    }
    public List<Lectures> GetLectures()
    {
        return _lectures;
    }
    public void SetLectures(List<Lectures> lectures)
    {
        _lectures = lectures;
    }
    public List<Receptions> GetReceptions()
    {
        return _receptions;
    }
    public void SetReceptions(List<Receptions> receptions)
    {
        _receptions = receptions;
    }
    public List<Outdoor> GetOutdoor()
    {
        return _outdoor;
    }
    public void SetOutdoor(List<Outdoor> outdoor)
    {
        _outdoor = outdoor;
    }

    public string GetListAddress()
    {
        string output = "";
        for (int i=0;i <_address.Count; i++)
        {
            output += $"{_address[i].GetAddress()}";
        }
        return output;
    }
    public string GetListLectures()
    {
        string output = "";
        for (int i=0;i <_lectures.Count; i++)
        {
            output += $"{_lectures[i].GetLecturesInformation()}";
        }
        return output;
    }
    public string GetListReceptions()
    {
        string output = "";
        for (int i=0;i <_receptions.Count; i++)
        {
            output += $"{_receptions[i].GetReceptionsInformation()}";
        }
        return output;
    }
    public string GetListOutdoor()
    {
        string output = "";
        for (int i=0;i <_outdoor.Count; i++)
        {
            output += $"{_outdoor[i].GetOutdoorInformation()}";
        }
        return output;
    }
    public string GetStandardMsg()
    {
        return $"{GetTitle()} \n{GetDescription()} \nDate of the Event: {GetDateEvent()} \ntime: {GetTimeEvent()} \n{GetListAddress()}";
    }
    public string GetTypeOfEventMsg()
    {
        switch(GetTypeOfEvent())
        {
            case "Lectures":
                return GetListLectures();
            case "Receptions":
                return GetListReceptions();
            case "Outdoor":
                return GetListOutdoor();
            default:
                return "Error";
        }
    }
    public string GetFullMsg()
    {
        return $"{GetStandardMsg()} \n{GetTypeOfEventMsg()} \nDo not loose this oportunity and be part of this great event";
    }
    public string GetShortMsg()
    {
        return $"type of Event {GetTypeOfEvent()} \n{GetTitle()} \nDate of the Event: {GetDateEvent()}";
    }
}