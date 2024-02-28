

using ConsoleApp1.Helpers.Constants;
using ConsoleApp1.Models;
using ConsoleApp1.Service;

namespace ConsoleApp1.Controllers
{
    internal class UserController
    {
        private readonly UserService _userService ;
       

        public UserController()
        {
            _userService = new UserService();
        }

        public void GetAll()
        {
            var users= _userService.GetAll();
            foreach(var user in users)
            {
                string result = $"{user.fullName} - {user.email} - {user.age}";
                Console.WriteLine(result);
            }
        }

        public void GetUserByID()
        {
            Console.WriteLine("Enter user id");
            UserId: string strid=Console.ReadLine();

            int id;
            bool isCorrectID=int.TryParse(strid, out id);
            if( isCorrectID )
            {
                var user = _userService.GetUsersById(_userService.GetAll(), id);
                if (user == null)
                {
                    Console.WriteLine(ResponseMessage.NotFound);
                    return;
                }
                string result = $"{user.fullName} - {user.email} - {user.age}";
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine(ResponseMessage.IncorrectNumberFormat);
                goto UserId;
            }







        }


    }
}
