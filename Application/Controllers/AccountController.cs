using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Account;
using Service.Services.Interfaces;

namespace Application.Controllers
{
    public class AccountController : AppController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<ApiResponse> Register([FromBody] RegisterDto user)
        {
            return await _accountService.RegisterAsync(user);
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto user)
        {
            return Ok(await _accountService.LoginAsync(user));
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] RoleDto role)
        {
            await _accountService.CreateRole(role);
            return Ok();
        }
    }
}
