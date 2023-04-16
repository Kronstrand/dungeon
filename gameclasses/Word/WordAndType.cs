public class WordAndType
{
    private string _word;
    private WT _wordtype;

    public WordAndType(string word, WT wordtype)
    {
        _word = word;
        _wordtype = wordtype;
    }

    public string word
    {
        get => _word;
        set => _word = value;
    }

    public WT Type
    {
        get => _wordtype;
        set => _wordtype = value;
    }
}