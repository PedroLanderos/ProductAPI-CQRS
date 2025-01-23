using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Application.Comands;
using ProductApi.Application.Queries;

namespace ProductApi.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator m)
        {
            _mediator = m;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _mediator.Send(new GetProductsQuery());
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductComand command)
        {
            var productId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAll), new { id = productId }, null);
        }
    }
}
