using Acme.IssueManagement.BookBorrows;
using Acme.IssueManagement.BookBorrows.Models;
using Acme.IssueManagement.BookReturns;
using Acme.IssueManagement.BookReturns.Models;
using Acme.IssueManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace Acme.IssueManagement.Controller
{

    [Route("api/BookBorrow")]
    [AllowAnonymous]
    public class BookBorrowController : IssueManagementController
    {

        private readonly IBookBorrowService _bookBorrowService;
        private readonly IRepository<Book, Guid> _bookRepository;
        private readonly IRepository<Customer, Guid> _customerRepository;
        private readonly IRepository<BookBorrow, Guid> _bookBorrowRepository;

        public BookBorrowController(IBookBorrowService bookBorrowService, IRepository<Book, Guid> bookRepository, IRepository<Customer, Guid> customerRepository, IRepository<BookBorrow, Guid> bookBorrowRepository)
        {
            _bookBorrowService = bookBorrowService;
            _bookRepository = bookRepository;
            _customerRepository = customerRepository;
            _bookBorrowRepository = bookBorrowRepository;
        }

        [HttpPost]
        [Route("borrow_books")]
        public async Task<IActionResult> CreateBookBorrow(BookBorrowRequest bookborrow)
        {
            try
            {
                var book = await _bookRepository.GetAsync(x => x.Id == bookborrow.BookId);
                var customer = await _customerRepository.GetAsync(x => x.Id == bookborrow.CustomerId);
                var bookborow = await _bookBorrowRepository.GetAsync(x => x.CustomerId == bookborrow.CustomerId);

                if(customer.Status == false)
                {
                    return BadRequest("Quý khách đã bị cấm không cho mượn sách");
                }

                if (bookborow.Status == false)
                {
                    return BadRequest("Khách hàng chưa trả sách. Không thể mượn thêm sách");
                }
                else
                {
                    if (book != null)
                    {
                        if (book.Quantity >= bookborrow.Quantity)
                        {
                            book.Quantity -= bookborrow.Quantity;
                            await _bookRepository.UpdateAsync(book);

                            //bookborrow.BorrowedDate = DateTime.Now;
                            bookborrow.Price = book.Price * bookborrow.Quantity;
                            //bookborrow.Status = false;

                            await _bookBorrowService.CreateAsync(bookborrow);

                            return Ok("Thêm thành công");
                        }
                        else
                        {
                            return BadRequest("Số lượng sách không đủ để mượn.");
                        }
                    }
                    else
                    {
                        return BadRequest("Không tìm thấy sách.");
                    }
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("read")]
        public async Task<IActionResult> GetListAsync(PagedAndSortedResultRequestDto bookborrow)
        {

            try
            {
                var data = await _bookBorrowService.GetListAsync(bookborrow);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateBookBorrow(Guid id, BookBorrowRequest bookborrow)
        {
            try
            {
                await _bookBorrowService.UpdateAsync(id, bookborrow);

                return Ok("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteBookBorrow(Guid id)
        {
            try
            {
                await _bookBorrowService.DeleteAsync(id);
                return Ok("Xoá thành công");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
