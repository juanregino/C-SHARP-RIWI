
using C__RIWI.src.Api.Dtos.Request;
using FluentValidation;

namespace C__RIWI.src.Api.Validators
{
    public class UserValidatorRequest : AbstractValidator<UserRequest>
    {
        public UserValidatorRequest()
        {
            RuleFor(u => u.Name).NotEmpty();
            RuleFor(u => u.Name).Length(2, 32);

            RuleFor(u => u.Phone).NotEmpty();
            RuleFor(u => u.Phone).Length(2, 32);

            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).EmailAddress();
        }
    }
}