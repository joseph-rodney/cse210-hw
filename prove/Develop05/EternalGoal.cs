public class EternalGoals : Goal
{
    public EternalGoals(string shortName, string description, int points) : base(shortName, description, points)
    {

    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"Eternal Goal: {_shortName}, {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}";
    }
}