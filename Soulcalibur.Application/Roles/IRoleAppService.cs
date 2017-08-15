using System.Threading.Tasks;
using Abp.Application.Services;
using Soulcalibur.Roles.Dto;

namespace Soulcalibur.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
