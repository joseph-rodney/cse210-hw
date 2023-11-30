public class ChecklistGoal : Goal
{
    public ChecklistGoal(string shortName, string description, int points) : base (shortName, description, points)
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
        throw new NotImplementedException();
    }
}