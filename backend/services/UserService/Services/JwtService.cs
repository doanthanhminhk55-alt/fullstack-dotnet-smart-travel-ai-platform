using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace UserService.Services
{
    public class JwtService
    {
        private const string SECRET =
        "THIS_IS_A_SUPER_SECRET_JWT_KEY_FOR_TRAVEL_AI_PLATFORM_2026";

        public string GenerateToken(string userId)
        {
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(SECRET)
            );

            var creds = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256
            );

            var token = new JwtSecurityToken(
                issuer: "travel-ai",
                audience: "travel-ai",
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
