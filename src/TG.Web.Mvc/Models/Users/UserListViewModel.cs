using System.Collections.Generic;
using TG.Roles.Dto;
using TG.Users.Dto;

namespace TG.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
