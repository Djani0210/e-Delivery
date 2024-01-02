using e_Delivery.Entities;
using e_Delivery.Model.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface IAuthContext
    {
        Task<GetLoggedUserVM> GetLoggedUser();
    }
}
