public class Room : ThingHolder {
    private string name;
    private Rm _n;
    private Rm _s;
    private Rm _w;
    private Rm _e;

    public Room(string aName, string aDescription, Rm aN, Rm aS, Rm aW, Rm aE, ThingList aThingList) : base(aName, aDescription, aThingList)
    {
        _n = aN;
        _s = aS;
        _w = aW;
        _e = aE;
    }

    public Rm N
    {
        get => _n;
        set => _n = value;
    }

    public Rm S 
    {
        get => _s;
        set => _s = value;
    }

    public Rm W
    {
        get => _w;
        set => _w = value;
    }

    public Rm E
    {
        get => _e;
        set => _e = value;
    }
}