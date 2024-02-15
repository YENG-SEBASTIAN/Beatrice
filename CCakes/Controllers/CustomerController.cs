
using CCakes.Models.Data.DTOs.Customer;
using CCakes.Models.Data.Repository.CustomerRepo;
using Microsoft.AspNetCore.Mvc;

namespace CCakes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer _db;
        public CustomerController(ICustomer db)
        {
            _db = db;
        }

        [HttpPost("customer")]
        public async Task<IActionResult> AddCustomer([FromBody] AddCustomerDTO model){
            try
            {
                bool result = await _db.AddCustomerAsync(model);
                if(result == true){
                    return Ok();
                }
                return BadRequest();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("customers")]
        public async Task<IActionResult> GetCustomers(){
            try
            {
                var result = await _db.GetMCustomerAsync();
                return Ok(result);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("customer/{id}")]
        public async Task<IActionResult> GetCustomerById(int id){
            try
            {
                var result = await _db.GetCustomerByIdAsync(id);
                return Ok(result);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("updatecustomer/{id}")]
        public async Task<IActionResult> UpdateCustomer([FromBody] AddCustomerDTO model, int id){
            try
            {
                bool result = await _db.UpdateCustomerAsync(model, id);
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

        [HttpDelete("deleteCustomer/{id}")]
        public async Task<IActionResult> DeleteCustomer(int id){
            try
            {
                bool result = await _db.DeleteCustomerAsync(id);
                return Ok();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }
    }
}