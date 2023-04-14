public class RoomList : Dictionary<Rm, Room>
{
    public RoomList() 
    {

    }

    public Room RoomAt(Rm id)
    {
        return this[id];
    }
}