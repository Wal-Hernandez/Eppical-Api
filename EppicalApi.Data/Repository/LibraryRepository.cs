using EppicalApi.Data.Interfaces;
using EppicalApi.Data.MyDbContext;
using EppicalApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EppicalApi.Data.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        private readonly DataContext _context;

        public LibraryRepository(DataContext context)
        {
            _context = context;
        }

        public Library AddLibrary(Library library)
        {
            _context.Libraries.Add(library);
            _context.SaveChanges();
            return library;
        }

        public Library GetLibrary(int id)
        {
            return _context.Libraries.Find(id);
        }

        public bool DeleteLibrary(int id)
        {
            var library = _context.Libraries.Find(id);
            if (library == null)
            {
                return false;
            }

            _context.Libraries.Remove(library);
            _context.SaveChanges();
            return true;
        }
    }
}
