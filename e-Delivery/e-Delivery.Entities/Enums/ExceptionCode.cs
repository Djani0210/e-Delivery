using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities.Enums
{
    public enum ExceptionCode
    {
        Success = 200,
        Created = 201,
        NoContent = 204,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        BadRequest = 400,
    }
}
