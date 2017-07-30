using System.Threading.Tasks;
using Abp.Application.Services;
using WeChat.Roles.Dto;

namespace WeChat.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
