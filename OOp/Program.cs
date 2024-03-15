using System.Threading.Channels;

namespace OOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            Register register = new Register();
            Console.WriteLine("1 Login in");
            Console.WriteLine("2 Register");
            Console.WriteLine("3 Exit");

            int secim = Convert.ToInt32(Console.ReadLine());
            while (true) { 

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


                    DateTime DogumTarixi = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                      
                           int   yas = (DateTime.Now.Year - DogumTarixi.Year);

                        
                       


                        //DateTime DogumTarixi = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);








                        Console.WriteLine("Sifre daxil edin.");
                    string Newpassword = Console.ReadLine(); 

                    register.register(Newuser, Email, Phonenumber, DogumTarixi.ToString("MM/dd/yyyy"), Newpassword, yas);
                  
                    break
                      ;

                    case 3:
                        Console.WriteLine("Cixh olundu");

                        return;

                default:
                    Console.WriteLine("Sef sechim");


                    break;
            }

            }



        }
    }
}
