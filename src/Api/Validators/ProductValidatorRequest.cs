

using C__RIWI.src.Api.Dtos.Request;
using FluentValidation;

namespace C__RIWI.src.Api.Validators
{
    public class ProductValidatorRequest : AbstractValidator<ProductRequest>
    {
        public ProductValidatorRequest()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).Length(2, 32);

            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).Length(2, 32);

            RuleFor(p => p.Price).NotNull();
            RuleFor(p => p.Price).GreaterThan(0);

            RuleFor(p => p.Stock).NotNull();
            RuleFor(p => p.Stock).GreaterThan(0);
        }
    }
}