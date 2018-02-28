using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TG.Roles.Dto;

namespace TG.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        /// <summary>
        /// 呵呵呵呵呵呵
        /// </summary>
        /// <returns></returns>
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
