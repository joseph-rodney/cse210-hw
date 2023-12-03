public class Goal
{
    public string _name { get; set; }
    public string _type { get; set; }
    public int _scoreValue { get; set; }

    public Goal(string name, string type, int scoreValue)
    {
        _name = name;
        _type = type;
        _scoreValue = scoreValue;
    }

    public virtual void TrackProgress() { }

    public virtual int CalculateScore() { return _scoreValue; }

    public override string ToString() { return base.ToString(); }
}