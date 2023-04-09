using AutoMapper;
using EppicalApi.Data.Interfaces;
using EppicalApi.Models;
using EppicalApi.Services.DTOs;
using EppicalApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EppicalApi.Services.Services
{
    public class LibrariesService : ILibrariesService
    {
        private readonly ILibraryRepository _libraryRepository;
        private readonly IMapper _mapper;

        public LibrariesService(ILibraryRepository libraryRepository, IMapper mapper)
        {
            _libraryRepository = libraryRepository;
            _mapper = mapper;
        }

        public LibraryDto AddLibrary(CreateLibraryDto libraryDto)
        {
            var library = _mapper.Map<Library>(libraryDto);
            var addedLibrary = _libraryRepository.AddLibrary(library);
            var addedLibraryDto = _mapper.Map<LibraryDto>(addedLibrary);
            return addedLibraryDto;
        }


        public LibraryDto GetLibrary(int id)
        {
            var library = _libraryRepository.GetLibrary(id);
            var libraryDto = _mapper.Map<LibraryDto>(library);
            return libraryDto;
        }

        public bool DeleteLibrary(int id)
        {
            return _libraryRepository.DeleteLibrary(id);
        }
    }
}
