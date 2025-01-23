using MediatR;
using ProductApi.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Application.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<ProductDTO>> 
    {

    }
}
