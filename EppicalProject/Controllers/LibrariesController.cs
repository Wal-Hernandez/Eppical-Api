using EppicalApi.Services.DTOs;
using EppicalApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EppicalProject.Controllers
{
    [ApiController]
    [Route("api/libraries")]
    public class LibrariesController : ControllerBase
    {
        private readonly ILibrariesService _librariesService;

        public LibrariesController(ILibrariesService librariesService)
        {
            _librariesService = librariesService;
        }

        [HttpPost]
        public IActionResult AddLibrary(CreateLibraryDto library)
        {
            var newLibrary = _librariesService.AddLibrary(library);
            return Ok(newLibrary);
        }

        [HttpGet("{id}")]
        public IActionResult GetLibrary(int id)
        {
            var library = _librariesService.GetLibrary(id);
            if (library == null)
            {
                return NotFound();
            }

            return Ok(library);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLibrary(int id)
        {
            var deleted = _librariesService.DeleteLibrary(id);
            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
