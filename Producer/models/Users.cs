using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace Gkdr.Producer.models
{
    public class Users
    {
        public Users()
        {
            UserRegions = new HashSet<UserRegions>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        
        [JsonIgnore]
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public short IdType { get; set; }
        public short Read { get; set; }
        public short Add { get; set; }
        public short Modify { get; set; }
        public int? IdRegion { get; set; }
        
        [NotMapped]
        public string Token { get; set; }

        public virtual ICollection<UserRegions> UserRegions { get; set; }
    }
}
