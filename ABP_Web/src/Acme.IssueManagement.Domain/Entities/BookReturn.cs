using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.IssueManagement.Entities
{
    public class BookReturn : AuditedAggregateRoot<Guid>
    {
        public Guid BookBorrowId { get; set; }
        public Guid BookId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Quantity { get; set; }
        public double? FineAmount { get; set; }
    }
}
