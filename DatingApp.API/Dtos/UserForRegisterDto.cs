using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength=4,ErrorMessage="The length of password should be between 4 to 8 character")]
        public string Password { get; set; }
    }
}