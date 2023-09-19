using Acme.IssueManagement.BookReturns;
using Acme.IssueManagement.BookReturns.Models;
using Acme.IssueManagement.Entities;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.IssueManagement.Services
{
    public class BookReturnService : CrudAppService<BookReturn, BookReturnResponse, Guid, PagedAndSortedResultRequestDto, BookReturnRequest, BookReturnRequest>, IBookReturnService
    {
        public BookReturnService(IRepository<BookReturn, Guid> repository) : base(repository)
        {
        }
    }
}
