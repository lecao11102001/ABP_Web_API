using Acme.IssueManagement.BookBorrows.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.IssueManagement.BookBorrows
{
    public interface IBookBorrowService : ICrudAppService<BookBorrowResponse, Guid, PagedAndSortedResultRequestDto, BookBorrowRequest, BookBorrowRequest>
    {
        //Task<BookBorrowResponse> CreateBookBorrow(BookBorrowRequest bookborrow);
    }
}
