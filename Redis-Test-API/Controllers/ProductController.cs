using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Redis_Test_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(Product product)
        {

            var result = await _productService.Add(product);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetList()
        {

            var result =  await _productService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }
    }
}
