class Eternal : Goal
{
    public Eternal(bool complete, string type, string name, string des, int points) : base(complete, type, name, des, points)
    {
        _isComplete = complete;
        _goalType = type;
        _name = name;
        _description = des;
        _points = points;
    }

    public override int SetComplete()
    { 
        Console.WriteLine();
        Console.WriteLine($"You completed {_name} and got {_points} points, keep it up!!!");
        Console.WriteLine();
        return _points;
    }

    public override List<dynamic> GetGoal()
    {
        List<object> item = new List<object>();

        item.Add(_isComplete);
        item.Add(_goalType);
        item.Add(_name);
        item.Add(_description);
        item.Add(_points);

        return item;
    }
}