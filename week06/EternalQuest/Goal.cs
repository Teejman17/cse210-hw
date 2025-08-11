public abstract class Goal
{
    private string _shortname;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortname;
    }

    public void SetName(string name)
    {
        _shortname = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public void SetPoints(string points)
    {
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}