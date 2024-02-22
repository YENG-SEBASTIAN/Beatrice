using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspCake.Data.Service.Products;
using aspCake.Data.DTOs;

namespace aspCake.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("product")]
        public async Task<IActionResult> AddProduct(ProductDTO productDTO){
            try
            {
                bool result = await _productService.InsertData(productDTO);
                if(result){
                    return Ok(result);
                }
                return BadRequest();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetAllDataAsync(){
            try
            {
                var products = await _productService.GetAllDataAsync();
                return Ok(products);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("product/{id}")]
        public async Task<IActionResult> GetDataAsync(int id){
            try
            {
                var product = await _productService.GetDataAsync(id);
                if(product != null){
                    return Ok(product);
                }

                return NotFound();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("product/{id}")]
        public async Task<IActionResult> UpdateProduct(ProductDTO productDTO, int id){
            try
            {
                bool result = await _productService.UpdateData(productDTO, id);
                if(result == true){
                return Ok(result);
                }
                return BadRequest();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("product/{id}")]
        public async Task<IActionResult> DeleteProduct(int id){
            try
            {
                bool result = await _productService.DeleteData(id);
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
    }
}