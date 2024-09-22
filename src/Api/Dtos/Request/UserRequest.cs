using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__RIWI.src.Api.Dtos.Request
{
    public class UserRequest
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
    }
}