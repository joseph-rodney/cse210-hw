public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int amountCompleted, int target, int bonus) : base (shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if(_amountCompleted == _target)
        {
            //Get bonus points
            _points += _bonus;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        return $"Checklist Goal: {_shortName}, {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}