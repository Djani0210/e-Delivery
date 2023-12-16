using e_Delivery.Model.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface IRoleService
    {
        Task<Message> CreateRoleAsMessageAsync(RoleCreateVM roleCreateVM, CancellationToken cancellationToken);
        Task<Message> DeleteRoleAsMessageAsync(Guid roleId, CancellationToken cancellationToken);
        Task<Message> AddRoleToUserAsMessageAsync(UserRoleVM userRoleVM, CancellationToken cancellationToken);
        Task<Message> GetRolesAsMessageAsync(CancellationToken cancellationToken);
        Task<Message> UpdateRoleToUserAsMessageAsync(RoleUpdateVM userRoleVM, CancellationToken cancellationToken);
    }
}
