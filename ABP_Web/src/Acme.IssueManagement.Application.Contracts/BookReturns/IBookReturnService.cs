using Acme.IssueManagement.BookReturns.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.IssueManagement.BookReturns
{
    public interface IBookReturnService : ICrudAppService<BookReturnResponse, Guid, PagedAndSortedResultRequestDto, BookReturnRequest, BookReturnRequest>
    {
    }
}
