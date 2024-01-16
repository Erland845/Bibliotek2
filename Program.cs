namespace Bibliotek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("Gjenferd", "Jo Nesbø", "9788203350245", 2009),
                new Book("Marekors", "Jo Nesbø", "9788203361616", 2003),
                new Book("Rødstrupe", "Jo Nesbø", "9788203361593", 2000)
            };
            foreach (Book b in books)
            {
                b.PrintBook();
            }
            
            Console.WriteLine("Would you like to add another book to the list?");
            var input = Console.ReadLine().ToLower();
            bool isAdding = false;

            if (input == "yes" || input == "ok")
            {
                isAdding = true;
                while (isAdding)
                {
                    AddBook(books);
                    Console.WriteLine("Would you like to add another book?");
                    input = Console.ReadLine().ToLower();
                    Console.ReadLine();
                    if (input == "no")
                    {
                        isAdding = false;   
                    }
                }
            }
            else
            {
                Console.WriteLine("No changes made");
            }
            Console.WriteLine("Here's the finished list");
            foreach (Book b in books)
            {
                b.PrintBook();
            }

        }
        static void AddBook(List<Book> books)
        {
            Console.WriteLine("Submit the Title of the book");
            string title = Console.ReadLine();

            Console.WriteLine("Submit the author of the book");
            string author = Console.ReadLine();

            Console.WriteLine("Submit the ISBN of the book");
            string isbn = Console.ReadLine();

            Console.WriteLine("Submit the year of publication");
            int publicationYear;
            while (!int.TryParse(Console.ReadLine(), out publicationYear))
            {
                Console.WriteLine("Invalid input. Submit a valid year.");
            }
            Book newbook = new Book(title, author, isbn, publicationYear);
            books.Add(newbook);

        }
    }
}
/*gj: 9788203350245
    mar: 9788203361616
    rød: 9788203361593
   C&P 9788256012275*/