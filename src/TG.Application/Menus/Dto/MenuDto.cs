using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TG.Menu;

namespace TG.Menus.Dto
{
    /// <summary>
    /// web端菜单DTO
    /// </summary>
    [AutoMap(typeof(MenuEntity))]
    public class MenuDto : EntityDto<int>
    {
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name{get;set;}
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}
