using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TG.Menus.Dto
{
   public interface IMenuAppService : IAsyncCrudAppService<MenuDto, int, PagedResultRequestDto, MenuDto>, ITransientDependency
    {
    }
}
