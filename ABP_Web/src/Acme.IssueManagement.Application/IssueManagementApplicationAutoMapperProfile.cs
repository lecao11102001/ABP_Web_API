using Acme.IssueManagement.Books;
using AutoMapper;
using Volo.Abp.AutoMapper;

namespace Acme.IssueManagement;

public class IssueManagementApplicationAutoMapperProfile : Profile
{
    public IssueManagementApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookResponse>();
        CreateMap<BookRequest, Book>(MemberList.Source);
    }
}
