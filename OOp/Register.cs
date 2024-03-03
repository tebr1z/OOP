using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp
{
    internal class Register
    {
        public void register(string Newuser ,string Email, string PhoneNumber, string DogumTarixi1, string Newpassowrd ,int yas) 
        {



           
            Console.WriteLine("Yeni Istifadeci yaradildi");
            Console.WriteLine("User  :  " +Newuser);
            Console.WriteLine("Email :  " +Email);
            Console.WriteLine("Phone Number" +PhoneNumber);
            Console.WriteLine("Dogum taxiniz " + DogumTarixi1);
            Console.WriteLine("Yasiniz"+yas);
            Console.WriteLine("Password:  "+Newpassowrd);


        }



    }
}
