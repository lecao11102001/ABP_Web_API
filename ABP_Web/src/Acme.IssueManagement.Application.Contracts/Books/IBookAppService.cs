using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.IssueManagement.Books
{
    public interface IBookAppService :
    ICrudAppService< // xác định phương thức CRUD
        BookResponse, // Model của sách
        Guid, // Key chính của sách
        PagedAndSortedResultRequestDto, // đc sử dụng cho Phân trang / sắp xếp
        //BookRequest,
        BookRequest> // Được sử dụng để tạo/cập nhật sách
    {
        Task<IEnumerable<BookResponse>> SearchAsync(string search);
    }
}
