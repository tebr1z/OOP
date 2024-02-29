using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp
{
    internal class Register
    {
        public void register(string Newuser ,string Email, string PhoneNumber, string dogumtarixi, string Newpassowrd ) 
        {
           
            Console.WriteLine("Yeni User yardildi");
            Console.WriteLine("User  :  " +Newuser);
            Console.WriteLine("Email :  " +Email);
            Console.WriteLine("Phone Number" +PhoneNumber);
            Console.WriteLine("Dogum taxiniz " + dogumtarixi + " Yasniz");
            Console.WriteLine("Password:  "+Newpassowrd);
           


        }



    }
}
