using System;
using System.Collections.Generic;
using System.Text;

namespace EppicalApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int LibraryId { get; set; }
        public Library Library { get; set; }
    }
}
