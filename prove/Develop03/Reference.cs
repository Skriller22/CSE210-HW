public class Reference
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int Verse { get; set; }
    public int EndVerse { get; set; }
    public string DisplayText { get; set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = 0;

        DisplayText = GetDisplayText();
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;

        DisplayText = GetDisplayText();
    }

    private string GetDisplayText()
    {
        if (EndVerse == 0)
        {
            return $"{Book} {Chapter}:{Verse}";
        }
        else
        {
            return $"{Book} {Chapter}:{Verse}-{EndVerse}";
        }
    }

}