public class Actor : ThingHolder
{
    private Room _location; //Room where Actor is at present;

    public Actor(string aName, string aDescription, Room aRoom, ThingList aThingList) : base(aName, aDescription, aThingList)
    {
            _location = aRoom;
    }

    public Room Location
    {
        get => _location;
        set => _location = value;
    }
}