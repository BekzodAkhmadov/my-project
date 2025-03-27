using FluentValidation;

namespace WebApplication1.Features.Queries
{
    public class GetProductByNameRequestValidator : AbstractValidator<GetProductByNameRequest>
    {
        public GetProductByNameRequestValidator()
        {
            RuleFor(name => name.Name).NotEmpty().MaximumLength(45);
        }
    }
}
