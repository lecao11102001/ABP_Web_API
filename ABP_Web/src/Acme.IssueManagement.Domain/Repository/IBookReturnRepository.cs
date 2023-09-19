using Acme.IssueManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace Acme.IssueManagement.Repository
{
    public interface IBookReturnRepository : IRepository<BookReturn, Guid>
    {
    }
}
