using System.Collections.Generic;

namespace bookallocationsystem.Models.Books
{
    public class BookViewIndex
    {
        public BookViewIndex()
        {
            this.BookList=new  List<Book>();
        }
        public List<Book> BookList { get; set; }
        
        
    }
}