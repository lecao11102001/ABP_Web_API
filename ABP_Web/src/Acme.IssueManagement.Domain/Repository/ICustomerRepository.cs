using Acme.IssueManagement.Entities;
using System;
using Volo.Abp.Domain.Repositories;

namespace Acme.IssueManagement.Repository
{
    public interface ICustomerRepository : IRepository<Customer, Guid>
    {
    }
}
