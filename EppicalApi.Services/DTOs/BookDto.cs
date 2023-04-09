using System;
using System.Collections.Generic;
using System.Text;

namespace EppicalApi.Services.DTOs
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int LibraryId { get; set; }
    }
    public class CreateBookDto
    {
        public string Name { get; set; }
        public string Category { get; set; }
    }
}
