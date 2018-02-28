using Abp.Authorization;
using TG.Authorization.Roles;
using TG.Authorization.Users;

namespace TG.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
