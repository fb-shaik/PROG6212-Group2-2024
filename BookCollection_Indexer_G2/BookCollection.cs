using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection_Indexer_G2
{
    class BookCollection
    {
        //Should contain a List<string> store book titles
        private List<string> books = new List<string>();
    
        //Define an indexer to get/set book titles at specified indexes
            public string this[int index]
        {
            get 
            { if(index <0 || index >= books.Count)
                { throw new IndexOutOfRangeException("Index out of range"); }
                return books[index];
            }
            
            set 
            { if(index <0 || index >= books.Count)
                    { throw new IndexOutOfRangeException("Index out of range"); }
                    books[index] = value;
            }
        }

        //AddBook method: Add a book to the collection 
        public void AddBook(string book) 
        { 
            books.Add(book);
        }


        //Count property to get the number of books in the collection
        public int Count
        {
            get { return books.Count; }
        }
    }
}
