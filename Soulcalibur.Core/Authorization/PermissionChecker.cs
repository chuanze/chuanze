using Abp.Authorization;
using Soulcalibur.Authorization.Roles;
using Soulcalibur.MultiTenancy;
using Soulcalibur.Users;

namespace Soulcalibur.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
