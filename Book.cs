using System;

public class Book
{
	public string Title { get; set; }
	public string Author { get; set; }
	public string ISBN { get; set; }
	public int Publicationyear { get; set; }
	public Book (string title, string author, string isbn, int publicationYear)
	{
		Title = title;
		Author = author;
		ISBN = isbn;
		Publicationyear = publicationYear;
	}
	public void PrintBook()
	{
		Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Publicationyear: {Publicationyear}");
	}
}

