using System.ComponentModel.DataAnnotations;

namespace Gkdr.Consumer
{
    public class AuthenticateModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}