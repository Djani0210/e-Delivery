using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.JwtConfiguration
{
    public class JwtConfiguration
    {
        public string Issuer { get; set; }
        public string Secret { get; set; }
        public int ExpirationAccessTokenInMinutes { get; set; }
        public int ExpirationRefreshTokenInMinutes { get; set; }
    }
}
