using System;
using System.Numerics;

namespace OOp
{
    public class Atm
    {
       public int balans = 345;

        public void Start()
        {
            Console.WriteLine("WELCOME TO ATM");

            while (true)
            {

                Console.WriteLine("======================================================================================");
                Console.WriteLine("Bir Reqem secin");

                Console.WriteLine("======================================================================================");
                Console.WriteLine("1- Balans goster");

                Console.WriteLine("======================================================================================");
                Console.WriteLine("2- Pul cek");

                Console.WriteLine("======================================================================================");
                Console.WriteLine("3- Pul elave et");

                Console.WriteLine("======================================================================================");
                Console.WriteLine("4- Market");

                Console.WriteLine("======================================================================================");
                Console.WriteLine("5- Chixis et");

                Console.WriteLine("===================================================================" +
                    "===================");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ShowBalance();
                        break;

                    case "2":
                        WithdrawMoney();
                        break;

                    case "3":
                        AddMoney();
                        break;

                    case "4":
                        Shops();
                        break;

                    case "5":
                        Exit();
                        return;

              

                    default:
                        Console.WriteLine("Duzgun deyer daxil et");
                        break;
                }
            }
        }

     public void ShowBalance()
        {
            Console.WriteLine("Balansiniz: " + balans);
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Chekmek istediyiniz miqdar daxil edin:");
            int cekilecek_miqdar = Convert.ToInt32(Console.ReadLine());

            if (cekilecek_miqdar > balans ||  cekilecek_miqdar < 0)
            {
                Console.WriteLine("Balansda kifayet qeder mebleg yoxdur, Duzgun emlyat yerne yetirin");
            } 
            else

            {
                
                double kesintiMiqdari = cekilecek_miqdar * 0.01;
                int kesinti = cekilecek_miqdar + (int)kesintiMiqdari;

                if (balans < kesinti)
                {
                    Console.WriteLine("Faizi odyecek qeder balansin yoxdur!");
                }
                else
                {
                    balans -= kesinti;
                    Console.WriteLine("Cekilen mebleg: " + cekilecek_miqdar);
                    Console.WriteLine("Kesinti Faizi: " + (int)kesintiMiqdari);
                    Console.WriteLine("Qalan balans: " + balans);
                }
              
            }
        }

      public void AddMoney()
        {
            Console.WriteLine("Elave etmek istediyiniz miqdari daxil edin:");
            int artilacaq_pul = Convert.ToInt32(Console.ReadLine());
            balans += artilacaq_pul;
            Console.WriteLine("Yeni Balans: " + balans);
        }


        public void Shops()
        {

            while (true) {

                Console.WriteLine("======================================================================================");
                Console.WriteLine("1 Mauslar 5 azn");

                Console.WriteLine("======================================================================================");
               
                Console.WriteLine("2 Qulaqliq 2 azn");

                Console.WriteLine("======================================================================================");
               
                Console.WriteLine("3 Klaviyatra 15 azn");

                Console.WriteLine("======================================================================================");
                Console.WriteLine("4 usb flash kartlar 2 azn");

                Console.WriteLine("======================================================================================");
                Console.WriteLine("5 Exit");

                Console.WriteLine("======================================================================================");

                int price = Convert.ToInt32(Console.ReadLine());

            switch (price)
            {
                case 1:
                        int price1 = 300;
                        double kesintiMiqdari = price1 * 0.01;
                        int kesinti = price1 + (int)kesintiMiqdari;

                        balans -= kesinti;

                        if (balans<price)
                        {
                            Console.WriteLine("Balnsda kifayet qeder pul yoxdur");
                            break;
                        }
                       

                        Console.WriteLine("Maus Sifaris verildi xosh gunler: Yeni Balans:     " + balans +"     Kesinti:    "+ kesintiMiqdari);
                    break;

                    case 2:
                    balans -= 5;

                        if (balans < price)
                        {
                            Console.WriteLine("Balnsda kifayet qeder pul yoxdur");
                            break;
                        }
                        Console.WriteLine("Qulaqliq Sifaris verildi xosh gunler: Yeni Balans" +balans);
                    break;
                        
                case 3:
                    balans -= 15;
                        if (balans < price)
                        {
                            Console.WriteLine("Balnsda kifayet qeder pul yoxdur");
                            break;
                        }
                        Console.WriteLine("Sifaris verildi xosh gunler: Yeni Balans" +balans);
                    break;

                    case 4:
                    balans -= 15;
                        if (balans < price)
                        {
                            Console.WriteLine("Balnsda kifayet qeder pul yoxdur");
                            break;
                        }
                        Console.WriteLine("Usb Falsh Sifaris verildi xosh gunler: Yeni Balans" + balans);
                    break;

                case 5:
                    Exit();
                    return;
            }

            }

        }
     



      public void Exit()
        {
            Console.WriteLine("Proses sonlandi xosh gunler");
        }
    }
}
