using MediatR;

namespace WebApplication1.Features.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        public readonly ICollection<Product> _products;
        public CreateProductCommandHandler(ICollection<Product> product)
        {
            _products = product;
        }
        public Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price
            };
            _products.Add(product);
            return Task.FromResult(product.Id);
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
