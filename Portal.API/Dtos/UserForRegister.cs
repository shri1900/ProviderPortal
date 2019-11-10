using System.ComponentModel.DataAnnotations;

namespace Portal.API.Dtos
{
    public class UserForRegister
    {
        [Required]
        public string Username { get; set; }
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Your password must consist of mim 4 and max 8 characters")]
        public string Password { get; set; }
    }
}