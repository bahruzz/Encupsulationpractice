

using ConsoleApp1.Service;

namespace ConsoleApp1.Services
{
    internal class AccountService : User
    {
        private readonly UserService _userService;
        public AccountService()
            {

            _userService=new UserService();

            }

        public bool Login(string email, string password)
        {
            var users = _userService.GetAll();
            return users.Any(m=>m.email==email && m.password==password);
           
        }

    }
}
