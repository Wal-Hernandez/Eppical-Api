using System.Collections.Generic;
using EppicalApi.Models;
using EppicalApi.Services.Interfaces;
using EppicalApi.Data.Interfaces;
using EppicalApi.Services.DTOs;
using AutoMapper;

namespace LibraryManagement.Services
{
    public class BooksService : IBooksService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BooksService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public BookDto AddBook( int libraryId, CreateBookDto bookDto)
        {

            var book = _mapper.Map<Book>(bookDto);
            book.LibraryId = libraryId;
            var addedBook = _bookRepository.AddBook(book);
            var addedBookDto = _mapper.Map<BookDto>(addedBook);
            return addedBookDto;
        }

        public List<BookDto> GetBooksByLibrary(int libraryId)
        {
            var books = _bookRepository.GetBooksByLibrary(libraryId);
            var bookDtos = _mapper.Map<List<BookDto>>(books);
            return bookDtos;
        }
    }
}
