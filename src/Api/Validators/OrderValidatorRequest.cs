

using C__RIWI.src.Api.Dtos.Request;
using FluentValidation;

namespace C__RIWI.src.Api.Validators
{
    public class OrderValidatorRequest : AbstractValidator<OrderRequest>
    {
        public OrderValidatorRequest()
        {
            RuleFor (o => o.UserId).NotNull();
            RuleFor(o => o.UserId).GreaterThan(0);
            
            RuleFor(o => o.ProductId).NotNull();
            RuleFor(o => o.ProductId).GreaterThan(0);
        }
    }
}