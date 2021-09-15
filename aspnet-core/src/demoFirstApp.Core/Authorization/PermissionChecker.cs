using Abp.Authorization;
using demoFirstApp.Authorization.Roles;
using demoFirstApp.Authorization.Users;

namespace demoFirstApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
