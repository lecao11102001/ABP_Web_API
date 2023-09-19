using Acme.IssueManagement.Books;
using Acme.IssueManagement.Entities;
using Acme.IssueManagement.Manager;
using Acme.IssueManagement.Specifications;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.IssueManagement.Service
{
    public class BookAppService : CrudAppService<
        Book, // Entity sách
        BookResponse, //Model sách
        Guid, // key chính sách
        PagedAndSortedResultRequestDto, // đc sử dụng cho Phân trang / sắp xếp
        //BookRequest,// Được sử dụng để tạo/cập nhật sách
        BookRequest>, IBookAppService // lớp interface sách        
    {
        private readonly BookAppManager _manager;
        private readonly IMapper _mapper;

        public BookAppService(IRepository<Book, Guid> repository, BookAppManager manager, IMapper mapper) : base(repository)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookResponse>> SearchAsync(string search)
        {
            var spec = new BookAppSpecifications(search);
            var data = await _manager.GetListAsync(spec);

            var bookResponses = _mapper.Map<IEnumerable<BookResponse>>(data);

            return bookResponses;
        }
        //var count = data.LongCount();

        //var dataPaging = data.OrderByDescending(s => s.CreationTime)
        //.Skip((pagingRequest.Page - 1) * pagingRequest.Limit).Take(pagingRequest.Limit).ToList();

        //var dataResult = ObjectMapper.Map<List<GopYPhanAnh>, List<GopYPhanAnhResponse>>(dataPaging);

        //var rsDataCache = new PagedResultDto<GopYPhanAnhResponse>(count, dataResult);



        //public IBookAppRepository _repository { get; set; }

        //public BookAppService(IBookAppRepository repository)
        //    : base(repository)
        //{
        //    //IRepository<Book, Guid> repository
        //    _repository = repository;
        //}
    }
}
