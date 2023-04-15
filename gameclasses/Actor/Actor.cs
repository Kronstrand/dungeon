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
    public Rm Move(Direction direction)
    {
        Rm newRoomEnum = Rm.NOEXIT;

        switch (direction)
        {
            case Direction.NORTH:
                newRoomEnum = Location.N;
                break;
            case Direction.SOUTH:
                newRoomEnum = Location.S;
                break;
            case Direction.WEST:
                newRoomEnum = Location.W;
                break;
            case Direction.EAST:
                newRoomEnum = Location.E;
                break;
        }

        if (newRoomEnum != Rm.NOEXIT)
            Location = GlobalValues.map[newRoomEnum];

        return newRoomEnum;
    }
}