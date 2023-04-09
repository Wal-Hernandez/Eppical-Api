using EppicalApi.Data.Interfaces;
using EppicalApi.Data.MyDbContext;
using EppicalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EppicalApi.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }

        public Book AddBook(Book book)
        {   
            _context.Books.AddAsync(book);
            _context.SaveChanges();
            return book;
        }

        public List<Book> GetBooksByLibrary(int libraryId)
        {
            return _context.Books.Where(b => b.LibraryId == libraryId).ToList();
        }
    }
}
