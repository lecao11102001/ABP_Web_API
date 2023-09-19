using Acme.IssueManagement.Books;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Acme.IssueManagement.Controller
{
    [Route("api/book")]
    [AllowAnonymous]
    public class BookAppController : IssueManagementController
    {
        private readonly IBookAppService _iBookAppService;
        public BookAppController(IBookAppService iBookAppService)
        {
            _iBookAppService = iBookAppService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateAsync(BookRequest input)
        {
            var createdBook = await _iBookAppService.CreateAsync(input);
            return Ok(createdBook);
        }

        [HttpGet]
        [Route("read")]
        public async Task<IActionResult> GetList(PagedAndSortedResultRequestDto paging)
        {
            var data = await _iBookAppService.GetListAsync(paging);

            return Ok(data);
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            try
            {
                await _iBookAppService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex) 
            { 
               return BadRequest(ex) ; 
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateAsync(Guid id, BookRequest bookRequest)
        {
            var data = await _iBookAppService.UpdateAsync(id, bookRequest);
            return Ok(data);
        }

        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> SearchAsync(string search)
        {
            var data = await _iBookAppService.SearchAsync(search);
            return Ok(data);
        }
        //var result = new BaseResultResponse<PagedResultDto<ThuTucHanhChinhResponse>>
        //{
        //    Code = 200,
        //    Message = "Get thành công",
        //    Result = data
        //};


    }
}
