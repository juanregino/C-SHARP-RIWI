

namespace C__RIWI.src.Api.Dtos.Request
{
    public class ProductRequest
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required double Price { get; set; }
        public required int Stock { get; set; }
        
    }
}