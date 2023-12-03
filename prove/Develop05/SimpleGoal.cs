public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(bool isComplete, string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}: {_description}, {_isComplete}";
    }

    public override string GetDetailsString()
    {
        return $"Simple Goal: {_shortName} - {_description}";
    }
}