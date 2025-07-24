public class Scripture
{
    private string _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _random = new Random();
        _words = new List<Word>();
}
}