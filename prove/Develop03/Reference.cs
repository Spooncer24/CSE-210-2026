using System.Security.Cryptography;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructor that takes multiple verses in.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    
    // Constructor that takes only one verse.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;

        //Set _endVerse to zero if nothing is passed through
        _endVerse = 0;
    }

    public string ScriptureReference()
    {
        string _reference;

        // If/else that will see if _endVers was set to zero then  construct the reference accordingly
        if(_endVerse == 0)
        {
            _reference = $"{_book} {_chapter}:{_startVerse}";
            return _reference;
        }
        else
        {
            _reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
            return _reference;
        }
    }
}