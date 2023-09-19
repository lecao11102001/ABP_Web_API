using Acme.IssueManagement.BookBorrows;
using Acme.IssueManagement.BookBorrows.Models;
using Acme.IssueManagement.Entities;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.IssueManagement.Services
{
    public class BookBorrowService : CrudAppService<BookBorrow, BookBorrowResponse, Guid, PagedAndSortedResultRequestDto, BookBorrowRequest, BookBorrowRequest>, IBookBorrowService
    {

        //private readonly IBookBorrowService _bookBorrowService;
        //private readonly IRepository<Book, Guid> _bookRepo;
        //private readonly IRepository<Customer, Guid> _customerRepo;

        public BookBorrowService(IRepository<BookBorrow, Guid> repository) : base(repository)
        {
            //_bookBorrowService = bookBorrowService;
            //_bookRepo = bookRepo;
            //_customerRepo = customerRepo;
        }

        //public async Task<BookBorrowResponse> CreateBookBorrow(BookBorrowRequest bookborrow)
        //{
        //    var book = await _bookRepo.GetAsync(x => x.Id == bookborrow.BookId);
        //    var customer = await _customerRepo.GetAsync(x => x.Id == bookborrow.CustomerId);

        //    book.Quantity -= bookborrow.Quantity;
        //    await _bookRepo.UpdateAsync(book);

        //    customer.Status = true;
        //    await _customerRepo.UpdateAsync(customer);

        //    return await _bookBorrowService.CreateAsync(bookborrow);

        //}
    }
}
