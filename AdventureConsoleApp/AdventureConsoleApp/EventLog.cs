using System.Collections;

namespace AdventureConsoleApp;

public class EventLog : IEnumerable<Event>
{
    private List<Event> _events = new List<Event>();

    public IEnumerator<Event> GetEnumerator()
    {
        foreach (Event ev in _events)
        {
            yield return ev;
        }
    }
    public void Add(Event ev)
    {
        _events.Add(ev);
    }

    public IEnumerable<Event> GetChonological()
    {
        foreach (var ev in _events)
        {
            if (ev.Type == TypeEvent.Fight)
            {
                yield return ev;
            }
        }
    }
    

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}