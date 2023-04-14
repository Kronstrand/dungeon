RoomList map = new RoomList();
Actor player;

bool runGame = true;
ConsoleKeyInfo pressedKey;

InitGame();
StartGame();

while (runGame)
{
    pressedKey = Console.ReadKey();
    
    if (pressedKey.KeyChar == 'n')
    {
        MovePlayer(player.Location.N);
    }
    else if (pressedKey.KeyChar == 's')
    {
        MovePlayer(player.Location.S);
    }
    else if (pressedKey.KeyChar == 'w')
    {
        MovePlayer(player.Location.W);
    }
    else if (pressedKey.KeyChar == 'e')
    {
        MovePlayer(player.Location.E);
    }
}

void MovePlayer(Rm newLocation)
{
    if (newLocation == Rm.NOEXIT)
    {
        Console.WriteLine("There is no exit in that direction");
    } 
    else
    {
        player.Location = map[newLocation];
        Console.WriteLine($"You are now in the {player.Location.Name}");
        Console.WriteLine($"It is {player.Location.Description}");
    }

}

void StartGame()
{
    Console.WriteLine("Welcome to the Great Adventure!");
    Console.WriteLine($"You are in the {player.Location.Name}.");
    Console.WriteLine($"It is {player.Location.Description}");
    Console.WriteLine("Enter a direction: (n)orth, (s)outh, (w)est or (e)ast.");
}

void InitGame()
{
    /*
Troll Room -- Forest
    |
  Cave ------ Dungeon
*/

    map.Add(
        Rm.TrollRoom, 
        new Room(
            "Troll Room", 
            "a dank room that smells of troll. To the east you can see trees. To the south, you see the mouth of a cave entrance",
            Rm.NOEXIT,Rm.Cave,Rm.NOEXIT,Rm.NOEXIT,
            new ThingList()));

    map[Rm.TrollRoom].AddThing(new Thing("carrot", "It is a very crunchy carrot"));


    map.Add(
        Rm.Forest,
        new Room(
            "Forest",
            "a forest of pure love. To the west, you can see a room",
            Rm.NOEXIT,Rm.NOEXIT,Rm.TrollRoom,Rm.NOEXIT,
            new ThingList()));

    map[Rm.Forest].AddThing(new Thing("sausage", "It is a plump pork sausage"));
    map[Rm.Forest].AddThing(new Thing("tree", "It is a gigantic oak tree", false));


    map.Add(
        Rm.Cave,
        new Room(
        "Cave",
        "a dark cave where light fear to be found. To the north, you see a room. To the east you see the entrance to a dungeon",
        0,Rm.NOEXIT,Rm.NOEXIT,Rm.Dungeon,
        new ThingList()));


    map.Add(
        Rm.Dungeon,
        new Room(
        "Dungeon",
        "the dungeon is dripping with fear and bad memories. To the west, you see light",
        Rm.NOEXIT,Rm.NOEXIT,Rm.Cave,Rm.NOEXIT,
        new ThingList()));


    player = new Actor("You", "The Player", map[Rm.TrollRoom],new ThingList());
}

