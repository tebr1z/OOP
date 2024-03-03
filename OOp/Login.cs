using System;

namespace OOp
{
    internal class Login
    {
        public string[] userNames = { "admin", "user1", "user2" };
        public string[] passwords = { "admin", "user1", "user2" };

        public void Log_in(string username, string password)
        {
            bool isAuthenticated = false;

            for (int i = 0; i < userNames.Length; i++)
            {
                if (userNames[i] == username && passwords[i] == password)
                {
                    isAuthenticated = true;
                    break;
                }
            }

            if (isAuthenticated)
            {
                Atm atm = new Atm();
                atm.Start();
            }
            else
            {
                Console.WriteLine("UserName veya sifre yalnisdir.");
            }
        }
    }
}
