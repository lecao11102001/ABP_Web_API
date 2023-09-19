using Acme.IssueManagement.Customers;
using Acme.IssueManagement.Customers.Models;
using Acme.IssueManagement.Entities;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.IssueManagement.Services
{
    public class CustomerService : CrudAppService<Customer, CustomerResponse, Guid, PagedAndSortedResultRequestDto, CustomerRequest, CustomerRequest>, ICustomerService
    {
        public CustomerService(IRepository<Customer, Guid> repository) : base(repository)
        {
        }
    }
}
