using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Portal.API.Models;

namespace Portal.API.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int RoleId { get; set; }
        public virtual IList<UserRole> UserRoles { get; set; }
    }
}