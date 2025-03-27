using FluentValidation;

namespace WebApplication1.Features.Commands
{
    public class ProductValidator: AbstractValidator<CreateProductCommand>
    {
        public ProductValidator()
        {
            RuleFor(x=>x.Name).NotEmpty();
            RuleFor(x=>x.Price).GreaterThan(0);
        }
    }

}
