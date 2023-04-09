using EppicalApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EppicalApi.Data.Interfaces
{
    public interface IBookRepository
    {
        Book AddBook(Book book);
        List<Book> GetBooksByLibrary(int libraryId);
    }
}
