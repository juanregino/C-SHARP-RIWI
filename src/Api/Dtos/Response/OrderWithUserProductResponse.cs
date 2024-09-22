

using C__RIWI.src.Api.Dtos.Response.BasicResponse;

namespace C__RIWI.src.Api.Dtos.Response
{
    public class OrderWithUserProductResponse : OrderResponse
    {
        public UserResponse? User { get; set; }
        public ProductResponse? Product { get; set; }
    }
}