using Acme.IssueManagement.Entities;
using Acme.IssueManagement.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.IssueManagement.Repository
{
    public class BookReturnRepository : EfCoreRepository<IIssueManagementDbContext, BookReturn, Guid>, IBookReturnRepository
    {
        public BookReturnRepository(IDbContextProvider<IIssueManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
