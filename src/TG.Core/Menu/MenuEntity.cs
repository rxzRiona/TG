using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TG.Menu
{
    /// <summary>
    /// web端菜单实体
    /// </summary>

    [Table("Menus")]
    public class MenuEntity : FullAuditedEntity<int>, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
    }
}
