using Abp.Authorization;
using VR.Tian.Authorization.Roles;
using VR.Tian.Authorization.Users;

namespace VR.Tian.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
