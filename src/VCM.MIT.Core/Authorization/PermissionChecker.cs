using Abp.Authorization;
using VCM.MIT.Authorization.Roles;
using VCM.MIT.Authorization.Users;

namespace VCM.MIT.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
