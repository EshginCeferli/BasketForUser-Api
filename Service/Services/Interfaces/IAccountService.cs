using Service.Services.DTOs.Account;

namespace Service.Services.Interfaces
{
    public interface IAccountService
    {
        Task<string?> LoginAsync(LoginDto model);
        Task<ApiResponse> RegisterAsync(RegisterDto model);
        Task CreateRole(RoleDto model);
    }
}
