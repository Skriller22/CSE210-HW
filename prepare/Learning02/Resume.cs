public class Resume
{
    public string Name {get; set;} 
    public List<Job> Jobs {get; set;}

    public Resume()
    {
        Jobs = new List<Job>();
    }

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in Jobs)
        {
            job.DisplayJob();
        }
    }
}