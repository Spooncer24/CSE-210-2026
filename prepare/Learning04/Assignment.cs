public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummery()
    {
        string summery = $"{_studentName}-{_topic}";
        return summery;
    }
}