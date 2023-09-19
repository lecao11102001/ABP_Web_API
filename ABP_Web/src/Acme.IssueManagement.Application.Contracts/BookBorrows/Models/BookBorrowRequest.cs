using System;

namespace Acme.IssueManagement.BookBorrows.Models
{
    public class BookBorrowRequest
    {
        public Guid BookId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? BorrowedDate { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; }
        public int Quantity { get; set; }
        public double? Price { get; set; }
        public bool? Status { get; set; } = false;
    }
}
