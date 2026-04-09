using System;
using System.Linq;
using AdventureConsoleApp;

Party myParty = new Party();

myParty.Add(new Character { Name = "Lara", Class = CharacterClass.Elf, Level = 12, Health = 85, Gold = 150, Status = CharacterStatus.Active });
myParty.Add(new Character { Name = "Geralt", Class = CharacterClass.Wizard, Level = 20, Health = 100, Gold = 500, Status = CharacterStatus.Active });
myParty.Add(new Character { Name = "Dante", Class = CharacterClass.Fighter, Level = 8, Health = 30, Gold = 50, Status = CharacterStatus.Unactive });
myParty.Add(new Character { Name = "Zoltan", Class = CharacterClass.Druid, Level = 10, Health = 95, Gold = 300, Status = CharacterStatus.Active });

EventLog myLog = new EventLog();

myLog.Add(new Event { Number = 1, Description = "Meeting with wolfs in forest", Type = TypeEvent.Fight, Change = -20 });
myLog.Add(new Event { Number = 2, Description = "Finding an ancient altar", Type = TypeEvent.Exploration, Change = 5 });
myLog.Add(new Event { Number = 3, Description = "Dice game in a tavern", Type = TypeEvent.Gambling, Change = 100 });
myLog.Add(new Event { Number = 4, Description = "Orc ambush", Type = TypeEvent.Fight, Change = -40 });
Console.WriteLine("Full Party");
foreach (var c in myParty)
{
    Console.WriteLine($"{c.Name} ({c.Class}) - Level: {c.Level}, HP: {c.Health}");
}
Console.WriteLine("Full Event Log");
foreach (var e in myLog)
{
    Console.WriteLine($"{e.Number} ({e.Type}) - Description: {e.Description }Change: {e.Change}");
}
Console.WriteLine("Active characters only");
foreach (var active in myParty.GetActiveCharacters())
{
    Console.WriteLine($"{active.Name} ready to fight!");
}
Console.WriteLine("Only fights");
foreach (var e in myLog)
{
    if (e.Type == TypeEvent.Fight)
    {
        Console.WriteLine($"{e.Number} ({e.Type}) - Description: {e.Description }Change: {e.Change}");
    }
}
var onlyExploration = myLog.Where(e => e.Type == TypeEvent.Exploration ).ToList();
var sortedByHealth = myParty.OrderBy(c => c.Health).ToList();
var resetHp = myParty.Select(c => c.Level == 100);
var howManyGamb = myLog.Count(e => e.Type == TypeEvent.Gambling );
var maxGold = myParty.Max(c => c.Gold);
var averageChange = myLog.Average(e => e.Change);
var groupedByClass = myParty.GroupBy(c => c.Class);

Console.WriteLine($"only exploration {onlyExploration.Select(e => e.Description)}\n" +
                  $"sorted by health {sortedByHealth.Select(c => $"{c.Name}({c.Health}HP)")}\n" +
                  $"reset HP {resetHp}\n" +
                  $"how many gambling was {howManyGamb}\n" +
                  $"max gold is {maxGold}\n" +
                  $"average change after events {averageChange}\n" +
                  $"groups {string.Join(" | ", groupedByClass.Select(g => $"{g.Key}: {g.Count()}"))}");
