class SimpleGoal : Goal
{
    public SimpleGoal(bool complete, string type, string name, string des, int points) : base(complete, type, name, des, points)
    {
        _isComplete = complete;
        _goalType = type;
        _name = name;
        _description = des;
        _points = points;
    }

    public override int SetComplete()
    {
        if(_isComplete == true)
        {
            Console.WriteLine();
            Console.WriteLine($"You already completed {_name}.");
            Console.WriteLine();
            return 0;
        }
        else
        {
            Console.WriteLine($"Congrats you completed {_name} you get {_points} points");
            _isComplete = true;
            return _points;
        }
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