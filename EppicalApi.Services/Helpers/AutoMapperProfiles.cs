using AutoMapper;
using EppicalApi.Models;
using EppicalApi.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EppicalApi.Services.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Book, CreateBookDto>().ReverseMap();
            CreateMap<Library, LibraryDto>().ReverseMap();
            CreateMap<CreateLibraryDto, Library>().ReverseMap();
        }
    }
}
