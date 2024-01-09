using Microsoft.AspNetCore.Mvc;
using ProyectoPrueba.Services;

namespace ProyectoPrueba.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private const string Message = "error:";
        private readonly IProductService ProductService;

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = ProductService.GetProducts();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(message: Message, ex.Message);
                throw;
            }
        }
    }
}
