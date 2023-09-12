using Acme.IssueManagement.Books;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.IssueManagement.Repository
{
    public interface IBookAppRepository : IRepository<Book,Guid>
    {
    }
}
