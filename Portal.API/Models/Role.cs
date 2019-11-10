using System.Collections.Generic;

namespace Portal.API.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public virtual IList<UserRole> UserRoles { get; set; }
        public RolePermission RolePermission { get; internal set; }
    }
}