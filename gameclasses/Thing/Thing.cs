public class Thing
{
    private string _name;
    private string _description;
    private bool _canTake;

    public Thing(string aName, String aDescription)
    {
        _name = aName;
        _description = aDescription;
        _canTake = true;
    }

    public Thing(string aName, String aDescription, bool aCanTake)
    {
        _name = aName;
        _description = aDescription;
        _canTake = aCanTake;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Description
    {
        get => _description;
        set => _description = value;
    }
}