using System;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;
using Abp.Extensions;
using Microsoft.AspNet.Identity;

namespace WeChat.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "000000";

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress, string password)
        {
            return new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Password = new PasswordHasher().HashPassword(password)
            };
        }

        /// <summary>
        /// 用户头像
        /// </summary>
        [StringLength(255)]
        public virtual string AvatarUrl { get; set; }

        /// <summary>
        /// 站点主题
        /// </summary>
        [StringLength(32)]
        public virtual  string Theme { get; set; }
    }
}