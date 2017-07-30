using Abp.Authorization;
using WeChat.Authorization.Roles;
using WeChat.MultiTenancy;
using WeChat.Users;

namespace WeChat.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
