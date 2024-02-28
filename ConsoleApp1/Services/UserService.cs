

using ConsoleApp1.Models;
using System.Xml.Linq;

namespace ConsoleApp1.Service
{
    internal class UserService
    {
        public user[] GetAll()
        {
            return new user[]
            {
                new user
                {
                    id = 1,
                    fullName="Fatime Qayxanova",
                    age = 22,
                    email="fatime@code.edu.az",
                    password="fatime123"
                },
                new user
                {
                    id = 2,
                    fullName="Fexriyye Tagizade",
                    age = 21,
                    email="fexriyye@code.edu.az",
                    password="fexriyye123"
                },
                new user
                {
                    id = 3,
                    fullName="Emirastan Miriyev",
                    age = 33,
                    email="emirastan@code.edu.az",
                    password="emirastan123"
                },
            };


        }

        public user GetUsersById(user[] users,int id) 
        {

            return users.FirstOrDefault(m => m.id ==id);


        }




    }
}
