﻿namespace OOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            Register register = new Register();
            Console.WriteLine("1 Login in");
            Console.WriteLine("2 Register");

            int secim = Convert.ToInt32(Console.ReadLine());


            switch (secim)
            {
                case 1:
                    Console.WriteLine("User Name");
                    string username = Console.ReadLine();
                    Console.WriteLine("User password");
                    string password = Console.ReadLine();
                    login.Log_in(username, password);
                    break;

                    case 2:
                    Console.WriteLine("User name add");
                    string Newuser = Console.ReadLine();
                    

                    Console.WriteLine("Email adresi daxil edin");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Telfon nomresini daxil edin");
                    string Phonenumber = Console.ReadLine();

                    Console.WriteLine("Doğum tarihini gün/ay/yıl ");
                    string dogumInput = Console.ReadLine();



                    DateTime dogumtarixi;

                    if (DateTime.TryParse(dogumInput, out dogumtarixi))
                    { }
                       
                    
                    else
                    {
                        Console.WriteLine("duzgun dogum taixi yazin");
                    }

                    Console.WriteLine("Sifre daxil edin");
                    string Newpassword = Console.ReadLine();

                    register.register(Newuser, Email, Phonenumber, dogumtarixi.ToString("MM/dd/yyyy"), Newpassword);

                    break
                      ;

                default:
                    Console.WriteLine("Sef sechim");


                    break;
            }





        }
    }
}