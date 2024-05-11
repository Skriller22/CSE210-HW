using System;

public class Word
{
    public string Text { get; set; }
    public bool isHidden { get; set; }
    public Word(string text)
    {
        this.Text = text;
        this.isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public void Show()
    {
        isHidden = false;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public string GetDisplayText()
    {
        if (isHidden == true)
        {
            return "______";
        }
        else
        {
            return Text;
        }
    }
}