using BookStore.API.Data;
using BookStore.API.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
           this._customerRepository = customerRepository;
        }

        //[HttpGet]
        //public ActionResult Add(int a ,int b)
        //{
        //    int c = a + b;
        //    return  Ok(c);
        //}


        [HttpPost("AddNewCustomer")]
        //[Route("AddNewCustomer")]
        public async Task<IActionResult> AddNewBook([FromBody] CustomerModel model)
        {
            var data = await _customerRepository.AddCustomer(model);
            return CreatedAtAction(nameof(AddNewBook), new {  Response = "Customer Created Successfully" } );
            //return Ok(data);
        }


        [HttpGet("GetAllCustomer")]
        //[Route("GetAllCustomer")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _customerRepository.GetAllBooksAsync();
            return Ok(books);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetByIdCustomer(int Id)
        {
            var customer = await _customerRepository.GetCustomerByIdAsync(Id);
            return Ok(customer);
        }


        [HttpPut("UpdateCustomer{id}")]
        public async Task<IActionResult> UpdateBook([FromBody] CustomerModel bookModel, [FromRoute] int id)
        {
            await _customerRepository.UpdateCustomerAsync(id, bookModel);
            return CreatedAtAction(nameof(UpdateBook), new { Response = "Customer Updated Successfully" });
        }


        [HttpDelete("DeleteCustomer/{id}")]
        public async Task<IActionResult> DeleteCustomer([FromRoute] int Id)
        {
            await _customerRepository.DeleteCustomerAsync(Id);
            return CreatedAtAction(nameof(DeleteCustomer), new { Response = "Customer Deleted Successfully" });
        }

    }
}
