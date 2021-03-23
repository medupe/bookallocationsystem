using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace bookallocationsystem.Models.Books
{
    public class BookViewUpload
    {
        public IFormFile  FileUpload { get; set; }
        
        
    }
}