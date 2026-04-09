namespace AdventureConsoleApp;

public enum CharacterClass
{
    Druid,
    Wizard,
    Fighter,
    Elf
};
public enum CharacterStatus {Active, Unactive}


public class Character
{
    public string Name { get; set; }
    public CharacterClass Class { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int Gold { get; set; }
    public CharacterStatus Status { get; set; }
    
}