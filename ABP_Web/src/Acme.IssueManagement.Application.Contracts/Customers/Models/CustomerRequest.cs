using static Acme.IssueManagement.Constants.Enums;

namespace Acme.IssueManagement.Customers.Models
{
    public class CustomerRequest
    {
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool? Status { get; set; } = true;
    }
}
