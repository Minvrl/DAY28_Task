using LibraryTask;

Library library = new Library();

string opt;


do
{
    string bookName,search;
    bool found = false;
    int i = 1;
    Console.WriteLine("\n1. Add new book");
    Console.WriteLine("2. Remove book");
    Console.WriteLine("3. Show all books");
    Console.WriteLine("4. Search book");
    Console.WriteLine("0. Exit");
    opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            do
            {
                Console.Write("\nEnter the book's name - ");
                bookName = Console.ReadLine();
            } while (string.IsNullOrEmpty(bookName));
            library.AddBook(bookName);
            break;
        case "2":
            do
            {
                Console.Write("\nEnter the book to remove - ");
                bookName = Console.ReadLine();
            } while (string.IsNullOrEmpty(bookName));
            Console.WriteLine(library.RemoveBook(bookName)); 
            break;
        case "3":
            Console.WriteLine("\n === Books === ");
            if(library.Books.Count == 0) Console.WriteLine("No books at the moment.");
            foreach (string book in library.Books)
            {
                Console.WriteLine($"{i}. {book}");
                i++;
            }  
            break;
        case "4":
            do
            {
                Console.Write("\nSearch for a book - ");
                search = Console.ReadLine();
            } while (string.IsNullOrEmpty(search));
            foreach (var book in library.Books)
            {
                if(book.Contains(search))
                    Console.WriteLine(book);
                    found = true;
            }
            if (!found)
            {
                Console.WriteLine("Not found !");
            }
            break;
        case "0":
            Console.WriteLine("Goodbye !");
            break;
        default:
            Console.WriteLine("Please enter a correct operator.");
            break;
    }
} while (opt != "0");