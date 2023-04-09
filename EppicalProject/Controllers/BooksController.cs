using EppicalApi.Services.DTOs;
using EppicalApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EppicalProject.Controllers
{
    [ApiController]
    [Route("api/libraries/{libraryId}/books")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;
        private readonly ILibrariesService _librariesService;

        public BooksController(IBooksService booksService, ILibrariesService librariesService)
        {
            _booksService = booksService;
            _librariesService = librariesService;
        }

        [HttpPost]
        public IActionResult AddBook(int libraryId, CreateBookDto book)
        {
            var library = _librariesService.GetLibrary(libraryId);
            if (library == null)
            {
                return NotFound();
            }
            var newBook = _booksService.AddBook(libraryId, book);
            return Ok(newBook);
        }

        [HttpGet]
        public IActionResult GetBooksByLibrary(int libraryId)
        {
            var library = _librariesService.GetLibrary(libraryId);
            if (library == null)
            {
                return NotFound();
            }

            var books = _booksService.GetBooksByLibrary(libraryId);
            return Ok(books);
        }
    }
}
