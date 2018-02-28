using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TG.Authorization.Roles;
using TG.Authorization.Users;
using TG.MultiTenancy;
using TG.Menu;

namespace TG.EntityFrameworkCore
{
    public class TGDbContext : AbpZeroDbContext<Tenant, Role, User, TGDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TGDbContext(DbContextOptions<TGDbContext> options)
            : base(options)
        {
        }
        public DbSet<MenuEntity> MenuEntitys { get; set; }
    }
}
