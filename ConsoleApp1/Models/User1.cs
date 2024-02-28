

namespace ConsoleApp1.Models
{
    internal class User1
    {
        public string name;
        public string surName;
        public int age;
        private string password;

        public User1()
        {

        }
        public User1(string name,string surName,int age)
        {
            this.name = name;
            this.surName = surName;
            this.age = age;
            
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }



    }
}
