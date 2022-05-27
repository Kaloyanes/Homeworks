namespace ex._4;

public class Book
{
    private string title;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    private string author;

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    private int pagesCount;

    public int PagesCount
    {
        get { return pagesCount; }
        set { pagesCount = value; }
    }

    private int year;

    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    
    public Book(string title, string author, int pagesCount, int year)
    {
        this.title = title;
        this.author = author;
        this.pagesCount = pagesCount;
        this.year = year;
    }

    public override string ToString()
    {
        return $"{title} by {author} is published in {year} and has {pagesCount} pages";
    }
}