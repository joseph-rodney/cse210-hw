public class EternalGoals : Goal
{
    public EternalGoals(string shortName, string description, int points) : base(shortName, description, points)
    {

    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}";
    }
}