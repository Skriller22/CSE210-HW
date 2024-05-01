public class Job
{
    public string Company {get; set;}
    public string JobTitle {get; set;}
    public int StartYear {get; set;}
    public int EndYear {get; set;}

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        Company = company;
        JobTitle = jobTitle;
        StartYear = startYear;
        EndYear = endYear;
    }

    public void DisplayJob()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}


//--Example of creating a Job object--//
// Job microsoftJob = new Job();
// microsoftJob.Company = "Microsoft";
// microsoftJob.JobTitle = "Software Engineer";
// microsoftJob.StartYear = 2015;
// microsoftJob.EndYear = 2018;