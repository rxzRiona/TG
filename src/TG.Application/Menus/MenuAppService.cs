using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using TG.Menu;
using TG.Menus.Dto;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Authorization;
using Microsoft.AspNetCore.Mvc;
using Abp.Dependency;

namespace TG.Menus
{
    /// <summary>
    /// web端菜单
    /// </summary>
    [AbpAuthorize]
    public class MenuAppService : AsyncCrudAppService<MenuEntity, MenuDto, int, PagedResultRequestDto, MenuDto, MenuDto>, IMenuAppService, ITransientDependency
    {
        public MenuAppService(IRepository<MenuEntity> repository) : base(repository)
        {

        }
    }
}
