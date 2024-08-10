using JwtTest.Models;

namespace JwtTest.Interfaces
{
    public interface IAuthService
    {
        public Task<LoginResponse> LoginUserAsync(LoginRequest request);
    }
}
