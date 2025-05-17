class Books
{

    public string _title;
    public string _author;
    public int _pageCount;

    string GetSummary()
    {
        return $"{_title} by {_author}, {_pageCount} pages";
    }



}