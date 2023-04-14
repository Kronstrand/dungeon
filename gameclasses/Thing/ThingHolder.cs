public class ThingHolder : Thing
{
    private ThingList _things = new ThingList();

    public ThingHolder(string aName, string aDescription, ThingList aThingList) : base(aName, aDescription)
    {
        _things = aThingList;
    }

    public ThingList Things
    {
        get => _things;
        set => _things = value;
    }

    public void AddThing(Thing aThing)
    {
        _things.Add(aThing);
    }

    public void AddThings(ThingList aThingList)
    {
        _things.AddRange(aThingList);
    }

    public string Describe()
    {
        return $"Name: {Name}, Description {Description} which contains -> {_things.Describe()}";
    }
}