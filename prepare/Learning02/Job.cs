class Job
{
    public string _title;
    public string _company;
    public int _startingYear;
    public int _endingYear;

    public  void DisplayJob()
    {
        Console.WriteLine($"{_title} {_company} {_startingYear}-{_endingYear}");
    }


}