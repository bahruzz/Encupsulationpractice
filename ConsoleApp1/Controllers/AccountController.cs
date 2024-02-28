

using ConsoleApp1.Helpers.Constants;
using ConsoleApp1.Services;

namespace ConsoleApp1.Controllers
{
    internal class AccountController
    {
        private readonly AccountService _accountService;
        public AccountController()
        {
            _accountService = new AccountService();
        }
        public void Login()
        {
            Console.WriteLine("Add your email:");
            Email: string email=Console.ReadLine();
            if (!email.Contains("@"))
            {
                Console.WriteLine(ResponseMessage.IncorrectEmailFormat);
                goto Email;
            }

            Console.WriteLine("Add your password:");
            string password=Console.ReadLine();

            var response=_accountService.Login(email, password);
            if (response)
            {
                Console.WriteLine(ResponseMessage.LoginSuccess);

            }
            else
            {
                Console.WriteLine(ResponseMessage.LoginFailed);
            }

        }




    }
}
