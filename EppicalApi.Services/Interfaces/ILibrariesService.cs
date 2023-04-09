using EppicalApi.Models;
using EppicalApi.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EppicalApi.Services.Interfaces
{
    public interface ILibrariesService
    {
        LibraryDto AddLibrary(CreateLibraryDto library);
        LibraryDto GetLibrary(int id);
        bool DeleteLibrary(int id);
    }
}
