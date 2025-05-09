class Resume
{
    public string _fname;
    public string _lname;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"{_fname} {_lname}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }
}