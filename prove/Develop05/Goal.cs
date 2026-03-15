using System.ComponentModel.DataAnnotations.Schema;

abstract class Goal
{
    protected string _goalType;
    protected string _description;
    protected string _name;
    protected int _points;
    protected bool _isComplete;

    public Goal(bool complete, string type, string name, string des, int points )
    {
        _goalType = type;
        _name = name;
        _description = des;
        _points = points;
        _isComplete = complete;
    }

    abstract public int SetComplete();
    abstract public List<dynamic> GetGoal();
    public virtual void CompletionEvent()
    {
        
    }
}