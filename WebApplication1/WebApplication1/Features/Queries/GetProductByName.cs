using MediatR;
using WebApplication1.Features.Commands;

namespace WebApplication1.Features.Queries
{
    public class GetProductByNameRequest : IRequest<Product>
    {
        public string Name { get; set; } = string.Empty;

        public class GetProductByNameRequestHandler : IRequestHandler<GetProductByNameRequest, Product>
        {
            private readonly IProductRepository _productRepository;
            public GetProductByNameRequestHandler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }
            public async Task<Product> Handle(GetProductByNameRequest request, CancellationToken cancellationToken)
            {
                return await _productRepository.GetProductByName(request.Name);
            }
        }
    }
}
