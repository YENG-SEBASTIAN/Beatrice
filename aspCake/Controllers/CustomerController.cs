using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspCake.Data.DTOs;
using aspCake.Data.Service.Customer;

namespace aspCake.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("customer")]
        public async Task<IActionResult> AddCustomer([FromBody] CustomerDTO customerDTO)
        {
            try
            {
                bool result = await _customerService.InsertData(customerDTO);
                if (result)
                {
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("customers")]
        public async Task<IActionResult> GetCustomers(){
            try
            {
                var customers = await _customerService.GetAllDataAsync();
                return Ok(customers);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("customer/{id}")]
        public async Task<IActionResult> GetCustomer(int id){
            try
            {
                var customer = await _customerService.GetDataAsync(id);
                if(customer != null){
                    return Ok(customer);
                }
                return BadRequest();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("customer/{id}")]
        public async Task<IActionResult> UpdateData([FromBody] CustomerDTO customerDTO, int id){
            try
            {
                bool result = await _customerService.UpdateData(customerDTO, id);
                if(result == true){
                    return Ok(result);
                }
                return BadRequest();
            }
            catch (System.Exception)
            {
                return BadRequest("Failed to update customer details");
            }
        }

        [HttpDelete("customer/{id}")]
        public async Task<IActionResult> DeleteCustomer(int id){
            try
            {
                bool result = await _customerService.DeleteData(id);
                if(result == true){
                    return Ok();
                }
                return BadRequest();
            }
            catch (System.Exception)
            {
                return BadRequest("An error occured whiles deleting data");
            }
        }
    }
}
