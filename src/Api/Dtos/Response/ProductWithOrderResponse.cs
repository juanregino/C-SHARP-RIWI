
namespace C__RIWI.src.Api.Dtos.Response.BasicResponse
{
    public class ProductWithOrderResponse : ProductResponse
    {
        public IEnumerable<OrderResponse>? Orders { get; set; }
    }
}