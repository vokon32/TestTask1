
namespace TestTask.BLL.Services.Interfaces
{
    public interface IAuthService
    {
        public Task<string> Login(string email, string password, bool isRememberMe = false);
        public Task<bool> Register(string email, string password);
    }
}
