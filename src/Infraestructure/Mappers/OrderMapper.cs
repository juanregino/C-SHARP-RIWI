using C__RIWI.src.Api.Dtos.Request;
using C__RIWI.src.Api.Dtos.Response;
using C__RIWI.src.Domain.Entities;

namespace C__RIWI.src.Infraestructure.Mappers
{
    public class OrderMapper : CommonMapper<OrderRequest, Order, OrderResponse>
    {
        public OrderMapper()
        {
            
        }
    }
}