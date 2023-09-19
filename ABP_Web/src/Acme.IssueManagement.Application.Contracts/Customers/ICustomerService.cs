using Acme.IssueManagement.Customers.Models;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.IssueManagement.Customers
{
    public interface ICustomerService : ICrudAppService<CustomerResponse,Guid, PagedAndSortedResultRequestDto, CustomerRequest, CustomerRequest>
    {
    }
}
