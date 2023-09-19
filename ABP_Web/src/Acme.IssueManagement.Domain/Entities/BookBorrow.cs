using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.IssueManagement.Entities
{
    public class BookBorrow : AuditedAggregateRoot<Guid>
    {
        public Guid BookId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? BorrowedDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Quantity { get; set; }
        public double? Price { get; set; }
        public bool? Status { get; set; }
    }
}
