namespace DEA_Program.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class Login
    {

        public static bool IsLoginIn(string userName, string password)
        {

            if (CheckUsernamePassword(userName,password))
            {
                Console.WriteLine("Welcome!");
                return true;
            }

            Console.WriteLine("Invalid Username/Password");
            return false;
        }

        private static bool CheckUsernamePassword(string userName, string password)
        {
            Console.WriteLine("Person logged!");

            //TODO get the UserName and Password from the DB and return true or false
            return false;
        }
    }
}
