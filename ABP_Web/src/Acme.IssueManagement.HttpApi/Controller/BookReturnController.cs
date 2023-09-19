using Acme.IssueManagement.BookReturns;
using Acme.IssueManagement.BookReturns.Models;
using Acme.IssueManagement.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.IssueManagement.Controller
{
    public class BookReturnController : IssueManagementController
    {
        private readonly IBookReturnService _bookReturnService;
        private readonly IRepository<Book, Guid> _bookRepository;
        private readonly IRepository<Customer, Guid> _customerRepository;
        private readonly IRepository<BookBorrow, Guid> _bookBorrowRepository;
        private readonly IRepository<BookReturn, Guid> _bookReturnRepository;

        public BookReturnController(IRepository<BookReturn, Guid> bookReturnRepository,IBookReturnService bookReturnService,IRepository<Book, Guid> bookRepository, IRepository<Customer, Guid> customerRepository, IRepository<BookBorrow, Guid> bookBorrowRepository)
        {
            _bookReturnService = bookReturnService;
            _bookRepository = bookRepository;
            _customerRepository = customerRepository;
            _bookBorrowRepository = bookBorrowRepository;
            _bookReturnRepository = bookReturnRepository;
        }
        [HttpPost]
        [Route("give_books_back")]
        public async Task<IActionResult> BackBookBorrow(BookReturnRequest bookback)
        {
            try
            {
                var bookborrow = await _bookBorrowRepository.GetAsync(x => x.Id == bookback.BookBorrowId);
                var book = await _bookRepository.GetAsync(x => x.Id == bookback.BookId);
                var customer = await _customerRepository.GetAsync(x => x.Id == bookback.CustomerId);
                var bookreturn = await _bookReturnRepository.GetAsync(x=> x.BookBorrowId == bookback.BookBorrowId && x.BookId == bookback.BookId && x.CustomerId == bookback.CustomerId);

                if (bookborrow != null)
                {
                    if (bookborrow.Quantity >= bookback.Quantity)
                    {
                        if (bookborrow.Quantity == bookback.Quantity + bookreturn.Quantity)
                        {
                            bookborrow.Status = true;
                            await _bookBorrowRepository.UpdateAsync(bookborrow);
                        }
                        book.Quantity += bookback.Quantity;
                        await _bookRepository.UpdateAsync(book);
                    }
                    else
                    {
                        return BadRequest("Sai số lượng sách");
                    }

                    if (bookback.ReturnDate > bookborrow.DueDate)
                    {
                        var day = bookback.ReturnDate - bookborrow.DueDate;
                        bookback.FineAmount = day.Days * 5000;
                    }
                    else
                    {
                        bookback.FineAmount = 0;
                    }

                    await _bookReturnService.CreateAsync(bookback);

                    return Ok();
                }
                else
                {
                    return BadRequest("Không tìm thấy thông tin đã mượn sách.");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
