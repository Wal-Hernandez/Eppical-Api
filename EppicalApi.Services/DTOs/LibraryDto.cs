using System;
using System.Collections.Generic;
using System.Text;

namespace EppicalApi.Services.DTOs
{
    public class LibraryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
    public class CreateLibraryDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
