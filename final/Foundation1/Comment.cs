public class Comment
{
    private string Author { get; set; }
    private string Text { get; set; }

    public void Print()
    {
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Comment: {Text}");
        Console.WriteLine();
    }
    public void CreateRandomComment()
    {
        string[] authors = { "Author 1", "Author 2", "Author 3", "Author 4", "Author 5" };
        string[] texts = { "Text 1", "Text 2", "Text 3", "Text 4", "Text 5" };

        Random random = new Random();
        int authorIndex = random.Next(0, authors.Length);
        int textIndex = random.Next(0, texts.Length);

        Author = authors[authorIndex];
        Text = texts[textIndex];
    
    }
}