using EppicalApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EppicalApi.Data.Interfaces
{
    public interface ILibraryRepository
    {
        Library AddLibrary(Library library);
        Library GetLibrary(int id);
        bool DeleteLibrary(int id);
    }
}
