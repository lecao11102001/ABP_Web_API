using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.IssueManagement.BookBorrows.Models
{
    public class BookBorrowResponse : AuditedEntityDto<Guid>
    {
        public Guid BookId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? BorrowedDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Quantity { get; set; }
        public double? Price { get; set; }
        public bool? Status {get; set;}
    }
}
