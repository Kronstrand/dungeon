public class ThingList : List<Thing>
{
    public string Describe()
    {
        string s = "";

        if (this.Count == 0)
        {
            s = "nothing.";
        }
        else
        {
            foreach (Thing thing in this)
            {
                s = s + thing.Description + "; ";
            }
        }
        return s;
    }
    
    public Thing ThisOb(string aName)
    {
        Thing aThing = null;
        string thingName = "";
        string aNameLowCase = aName.Trim().ToLower();

        foreach (Thing thing in this)
        {
            thingName = thing.Name.Trim().ToLower();
            if (thingName.Equals(aNameLowCase))
            {
                aThing = thing;
            }
        }
        return aThing;
    }
}