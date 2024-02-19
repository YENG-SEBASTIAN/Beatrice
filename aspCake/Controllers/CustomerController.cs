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
    }
}
