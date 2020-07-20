using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Gkdr.Consumer.Data.AppModel
{
    [Table("gdkr_users")]
    public class User
    {
        public int Id { get; set; }
        
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
    }
    
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
        
        public string Token { get; set; }
    }
    
    public class PasswordDto
    {
        public string OldPassword { get; set; }    
        public string NewPassword { get; set; }
    }
}