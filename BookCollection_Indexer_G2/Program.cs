//Program.cs
using BookCollection_Indexer_G2;

class Program {
    static void Main(String[] args) 
    {
        //Create an instance of the BookCollection
        BookCollection myBooks = new BookCollection();

        //Add some books to the collection
        myBooks.AddBook("The Great Gatsby");
        myBooks.AddBook("1984");
        myBooks.AddBook("To Kill a Mockingbird");

        //Demo the use of the indexer (access & modifying book collection)
        Console.WriteLine("Book title at index 1: " + myBooks[1]);

        //Change the title stored at index[1] using the indexer
        myBooks[1] = "Brave New World!";

        //Access the updated title after modification via the indexer
        Console.WriteLine("Book title at index 1 after modification: " + myBooks[1]);

        //Loop through the collection & print all book titles
        Console.WriteLine("\nAll Books in the collection:");
        for (int i = 0; i < myBooks.Count; i++) 
        {
            Console.WriteLine("Book at index " + i + ": " + myBooks[i]); 
        }

    }

}
