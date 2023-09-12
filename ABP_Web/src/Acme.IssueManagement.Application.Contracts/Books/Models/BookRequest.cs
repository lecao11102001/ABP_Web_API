using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.IssueManagement.Books
{
    public class BookRequest
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public BookType Type { get; set; } = BookType.Undefined;

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        public float Price { get; set; }
    }
}
