using System;
using System.ComponentModel.DataAnnotations;
using static Acme.IssueManagement.Constants.Enums;

namespace Acme.IssueManagement.Books
{
    public class BookRequest
    {
        [StringLength(128)]
        public string? Name { get; set; }

        public BookTypeEnums? Type { get; set; } = BookTypeEnums.Undefined;

        [DataType(DataType.Date)]
        public DateTime? PublishDate { get; set; } = DateTime.Now;

        public float? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
