using System;
using System.Transactions;

class Q2
{
    static void Main(string[] args)
    {
        Book myBook = new Book("Pride and Prejudice", "Jane Austen", 5.97, "0141439513");
        string bookinfo = myBook.PrintInformation();
        Console.WriteLine(bookinfo);
    }
}

public class Book
{
    private string title;
    private string author;
    private double price;
    private string isbn;

    public Book(string title, string author, double price, string isbn)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.isbn = isbn;
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public string ISBN
    {
        get { return isbn; }
        set { isbn = value; }
    }

    public string PrintInformation()
    {
        return $"{title} written by {author} is {price:C2}, with ISBN {isbn}.";
    }
}