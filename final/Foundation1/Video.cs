public class Video
{
    private string Title { get; set; }
    private string Author { get; set; }
    private int Duration { get; set; }
    private List<Comment> Comments { get; set; }

    private void AppendComment(Comment comment)
    {
        Comments.Add(comment);
    }

    private int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void Print()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine();
    }

    public void PrintComments()
    {
        foreach (Comment comment in Comments)
        {
            comment.Print();
        }
    }

    public void GenerateRandomVideo()
    {
        string[] titles = { "Cat Video", "Prank Video", "Instructional Video", "Unsolved Crime Video", "Video Game Video" };
        string[] authors = { "Author 1", "Author 2", "Author 3", "Author 4", "Author 5" };
        int[] durations = { 60, 120, 180, 240, 300 };

        Random random = new Random();
        int titleIndex = random.Next(0, titles.Length);
        int authorIndex = random.Next(0, authors.Length);
        int durationIndex = random.Next(0, durations.Length);

        Title = titles[titleIndex];
        Author = authors[authorIndex];
        Duration = durations[durationIndex];
    }

    public void CreateRandomComments(int numberOfComments)
    {
        Comments = new List<Comment>();

        for (int i = 0; i < numberOfComments; i++)
        {
            Comment comment = new Comment();
            comment.CreateRandomComment();
            AppendComment(comment);
        }
    }

}
