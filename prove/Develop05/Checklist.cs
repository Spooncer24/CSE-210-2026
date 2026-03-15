using System.Drawing;

class Checklist : Goal
{
    private int _bonus;
    private int _completionCount;
    private int _amountCompleted;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="des"></param>
    /// <param name="name"></param>
    /// <param name="points"></param>
    /// <param name="complete"></param>
    /// <param name="bonus"></param>
    /// <param name="count"></param>
    /// <param name="amount"></param>
    public Checklist(bool complete, string type, string name, string des, int points, int bonus, int amount, int count) : base(complete, type, name, des, points)
    {
        _bonus = bonus;
        _completionCount = count;
        _amountCompleted = amount;
    }

    public override int SetComplete()
    {
        _amountCompleted++;
        // No more points if goal is already completed
        if (_isComplete == true)
        {
            Console.WriteLine($"You already completed {_name}");
            return 0;
        }

        // Bonus points if person completed the amount they specified
        else if (_amountCompleted == _completionCount)
        {
            _isComplete = true;
            Console.WriteLine();
            Console.WriteLine($"Congrats you completed {_name} and get {_bonus} bonus points ontop of {_points} points");
            Console.WriteLine();
            return _bonus + _points;
        }

        //Points returned with a check marked of
        else
        {
            Console.WriteLine();
            Console.WriteLine($"You Get {_points} and have completed {_amountCompleted}/{_completionCount} of {_name}");
            Console.WriteLine();
            return _points;
        }
    }

    public override List<dynamic> GetGoal()
    {
        // return $"{_isComplete} - {_name} - {_description} - {_points} - {_bonus} - {_amountCompleted}/{_completionCount}";
        List<object> item = new List<object>();
        item.Add(_isComplete);
        item.Add(_goalType);
        item.Add(_name);
        item.Add(_description);
        item.Add(_points);
        item.Add(_bonus);
        item.Add(_amountCompleted);
        item.Add(_completionCount);

        return item;
    }
} 