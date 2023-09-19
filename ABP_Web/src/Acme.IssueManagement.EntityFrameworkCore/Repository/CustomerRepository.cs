using Acme.IssueManagement.Entities;
using Acme.IssueManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.IssueManagement.Repository
{
    public class CustomerRepository : EfCoreRepository<IIssueManagementDbContext, Customer, Guid>, ICustomerRepository
    {

        public CustomerRepository(IDbContextProvider<IIssueManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<IQueryable> ThongTinMuonSach()
        {
            var data = GetDbContextAsync().Result.Customers.Include(x => x.BookBorrows);

            return data;
        }
    }
}
