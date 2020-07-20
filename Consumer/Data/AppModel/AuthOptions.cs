using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Gkdr.Consumer.Data.AppModel
{
    public static class AuthOptions
    {
        public const string Issuer = "ГКДР КР";
        public const string Audience = "GKDRClient";
        public const int Lifetime = 60;
        
        public static SymmetricSecurityKey GetSymmetricSecurityKey(string key)
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key));
        }
    }
}