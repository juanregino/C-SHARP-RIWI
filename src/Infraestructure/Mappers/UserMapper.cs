
using C__RIWI.src.Api.Dtos.Request;
using C__RIWI.src.Api.Dtos.Response.BasicResponse;
using C__RIWI.src.Domain.Entities;

namespace C__RIWI.src.Infraestructure.Mappers
{
    public class UserMapper : CommonMapper<UserRequest, User, UserResponse>
    {
        public UserMapper() 
        {
            
        }
    }
}