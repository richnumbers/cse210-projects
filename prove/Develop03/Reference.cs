public class Reference
{

    private string _book;
    private int _chapter;
    private int _startV;
    private int _endV;

    public Reference(string book, int chapter, int startV)
    {
        _book = book;
        _chapter = chapter;
        _startV = startV;
        _endV = -1;
    }

    public Reference(string book, int chapter, int startV, int endV)
    {
        _book = book;
        _chapter = chapter;
        _startV = startV;
        _endV = endV;
    }

    public void GetFullReference()
    {
        if (_endV == -1)
        {
            Console.Write($"{_book}  {_chapter} : {_startV} ");
        }
        else
        {
            Console.Write($"{_book} {_chapter} : {_startV} - {_endV} ");
        }
    }
    

}