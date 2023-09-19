using System;
using Volo.Abp.Domain.Entities.Auditing;
using static Acme.IssueManagement.Constants.Enums;

namespace Acme.IssueManagement.Entities
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public BookTypeEnums Type { get; set; }

        public DateTime PublishDate { get; set; }

        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
