using System.Reflection.Metadata.Ecma335;

namespace AdventureConsoleApp;

public enum TypeEvent {Exploration, Fight, Gambling}

public class Event
{
    public int Number { get; set; }
    public string Description { get; set; }
    public TypeEvent Type { get; set; }
    public int Change { get; set; }

}
