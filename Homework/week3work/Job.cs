public class Job
{
    private string _jobTitle;

    private string _company;

    private int _startYear;

    private int _endYear;

    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    public void showJobInfo()
    {
        Console.WriteLine($"JOB: {_jobTitle}");
        Console.WriteLine($"COMPANY: {_company}");
        Console.WriteLine($"YEARS: {_startYear} - {_endYear}");
    }
}