using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.IssueManagement.BookReturns.Models
{
    public class BookReturnRequest
    {
        public Guid BookBorrowId { get; set; }
        public Guid BookId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Quantity { get; set; }
        public double? FineAmount { get; set; }
    }
}
