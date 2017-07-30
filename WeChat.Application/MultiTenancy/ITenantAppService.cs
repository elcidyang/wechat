using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WeChat.MultiTenancy.Dto;

namespace WeChat.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
