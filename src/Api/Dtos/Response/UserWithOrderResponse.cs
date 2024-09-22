

using C__RIWI.src.Api.Dtos.Response.BasicResponse;

namespace C__RIWI.src.Api.Dtos.Response
{
    public class UserWithOrderResponse : UserResponse
    {
        public IEnumerable<OrderResponse>? Orders { get; set; }
    }
}