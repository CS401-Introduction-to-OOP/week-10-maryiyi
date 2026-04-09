using System.Collections;

namespace AdventureConsoleApp;

public class Party : IEnumerable<Character>
{
    private List<Character> _characters = new List<Character>();
    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var c in _characters)
        {
            yield return c;
        }
    }
    public void Add(Character c)
    {
        _characters.Add(c);
    }

    public IEnumerable<Character> GetActiveCharacters()
    {
        foreach (var c in _characters)
        {
            if (c.Status == CharacterStatus.Active)
            {
                yield return c;
            }
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}