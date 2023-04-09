using EppicalApi.Models;
using EppicalApi.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EppicalApi.Services.Interfaces
{
    public interface IBooksService
    {
        BookDto AddBook(int libraryId, CreateBookDto book);
        List<BookDto> GetBooksByLibrary(int libraryId);
    }
}
