using Acme.IssueManagement.Books;
using Acme.IssueManagement.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.IssueManagement.Repository
{
    public class BookAppRepository : EfCoreRepository<IIssueManagementDbContext, Book, Guid>, IBookAppRepository
    {
        public BookAppRepository(IDbContextProvider<IIssueManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
