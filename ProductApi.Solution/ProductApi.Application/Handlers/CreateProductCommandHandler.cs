using MediatR;
using ProductApi.Application.Comands;
using ProductApi.Domain.Entities;
using ProductApi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Application.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductComand, Guid>
    {
        private readonly IProduct _productRepository;
        public CreateProductCommandHandler(IProduct productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Guid> Handle(CreateProductComand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                Price = request.Price
            };

            await _productRepository.AddAsync(product);
            return product.Id;
        }
    }
}
