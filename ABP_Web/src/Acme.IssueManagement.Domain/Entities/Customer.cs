using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;
using static Acme.IssueManagement.Constants.Enums;

namespace Acme.IssueManagement.Entities
{
    public class Customer :AuditedAggregateRoot<Guid>
    {
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string Phone { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        public bool Status { get; set; }

        public List<BookBorrow>? BookBorrows { get;set; }
    }
}
