using Acme.IssueManagement.BookBorrows.Models;
using Acme.IssueManagement.BookReturns.Models;
using Acme.IssueManagement.Books;
using Acme.IssueManagement.Customers.Models;
using Acme.IssueManagement.Entities;
using AutoMapper;
using Volo.Abp.AutoMapper;

namespace Acme.IssueManagement;

public class IssueManagementApplicationAutoMapperProfile : Profile
{
    public IssueManagementApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookResponse>();
        CreateMap<BookRequest, Book>(MemberList.Source);

        CreateMap<Customer, CustomerResponse>();
        CreateMap<CustomerRequest, Customer>(MemberList.Source);

        CreateMap<BookBorrow, BookBorrowResponse>();
        CreateMap<BookBorrowRequest, BookBorrow>(MemberList.Source);

        CreateMap<BookReturn, BookReturnResponse>();
        CreateMap<BookReturnRequest, BookReturn>(MemberList.Source);
    }
}
