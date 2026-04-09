using System.Collections;

namespace AdventureConsoleApp;

public class Party : IEnumerable<Character>
{
    private List<Character> _characters = new List<Character>();
    public IEnumerator<Character> GetEnumerator()
    {
        foreach (Character c in _characters)
        {
            yield return c;
        }
    }
    public void Add(Character c)
    {
        _characters.Add(c);
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}