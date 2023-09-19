using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;
using static Acme.IssueManagement.Constants.Enums;

namespace Acme.IssueManagement.Customers.Models
{
    public class CustomerResponse : AuditedEntityDto<Guid>
    {
        [MaxLength(255)]
        public string? Name { get; set; }
        [MaxLength(10)]
        public string? Phone { get; set; }
        [MaxLength(255)]
        public string? Email { get; set; }
        public bool Status { get; set; }
    }
}
