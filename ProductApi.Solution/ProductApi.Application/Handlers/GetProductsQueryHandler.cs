using MediatR;
using ProductApi.Application.DTOs;
using ProductApi.Application.Queries;
using ProductApi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Application.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<ProductDTO>>
    {
        private readonly IProduct _productRepository;

        public GetProductsQueryHandler(IProduct p)
        {
            _productRepository = p;
        }
        public async Task<IEnumerable<ProductDTO>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync();
            return products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price
            });
        }
    }
}
