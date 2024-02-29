using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp
{
    internal class Login
    {

        public void Log_in (string username, string password)
        {
            if (username == "admin" &&  password == "admin")   Console.WriteLine("Ugurlu girsh");

            else Console.WriteLine("Isfadeci adi ve ya sifre yalnisdi");



        }


    }
}
