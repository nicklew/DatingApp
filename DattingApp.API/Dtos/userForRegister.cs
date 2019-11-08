using System.ComponentModel.DataAnnotations;

namespace DattingApp.API.Dtos
{
    public class userForRegisterDto
    {   
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "PW too short")]
        public string Password { get; set; }
    }
}