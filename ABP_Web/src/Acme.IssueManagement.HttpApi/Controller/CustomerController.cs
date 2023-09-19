using Acme.IssueManagement.Customers;
using Acme.IssueManagement.Customers.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Acme.IssueManagement.Controller
{

    [Route("api/customer")]
    [AllowAnonymous]

    public class CustomerController : IssueManagementController
    {

        private readonly ICustomerService _iCustomerService;

        public CustomerController(ICustomerService iCustomerService) 
        { 
            _iCustomerService = iCustomerService;
        }



        [HttpGet]
        [Route("read")]
        public async Task<IActionResult> GetListAsync(PagedAndSortedResultRequestDto customer)
        {
            try
            {
                var data = await _iCustomerService.GetListAsync(customer);
                return Ok(data);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateCustomer([FromBody]CustomerRequest customer)
        {
            try
            {
await _iCustomerService.CreateAsync(customer);
            return Ok("Thêm thành công");
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateCustomer(Guid id, CustomerRequest customer)
        {
            try
            {
                await _iCustomerService.UpdateAsync(id, customer);
                return Ok("Cập nhật thành công");
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            try
            {
                await _iCustomerService.DeleteAsync(id);
                return Ok("Xoá thành công");
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
