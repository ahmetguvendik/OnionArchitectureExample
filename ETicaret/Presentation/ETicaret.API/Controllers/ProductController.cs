using ETicaret.Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _product;
        public ProductController(IProductService product)
        {
            _product = product;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var product = await _product.GetProducts();
            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _product.GetProductById(id);
            return Ok(product);
        }

    }
}
