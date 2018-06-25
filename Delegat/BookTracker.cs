using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    public delegate void AddBookCallback(int i);
    class BookTracker
    {
        List<Book> books = new List<Book>();
        public void AddBook(string name, AddBookCallback callback)
        {
            books.Add(new Book(name));
            callback(books.Count);
        }
    }
    public class Book
    {
        string Name { get; set; }
        public Book(string name) { Name = name; }

        BookTracker bookTracker = new BookTracker();
        public void Add(string name)
        {
            this.Name = name;
            bookTracker.AddBook(Name, delegate (int i){ i++; });
            
            
        }


    }
}
