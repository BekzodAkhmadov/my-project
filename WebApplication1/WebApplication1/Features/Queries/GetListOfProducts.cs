using MediatR;
using WebApplication1.Features.Commands;

namespace WebApplication1.Features.Queries
{
    public class GetListOfProducts : IRequest<IEnumerable<Product>>
    {
    }

    public class GetListOfProductsHandler : IRequestHandler<GetListOfProducts, IEnumerable<Product>>
    {
        public async Task<IEnumerable<Product>> Handle(GetListOfProducts request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new List<Product>());
        }
    }
}
