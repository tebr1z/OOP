using System;

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
                Console.WriteLine("Bir Reqem secin");
                Console.WriteLine("1- Balans goster");
                Console.WriteLine("2- Pul cek");
                Console.WriteLine("3- Pul elave et");
                Console.WriteLine("4- Chixis et");

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

            if (cekilecek_miqdar > balans)
            {
                Console.WriteLine("Balansda kifayet qeder mebleg yoxdur.");
            }
            else
            {
                
                double kesintiMiqdari = cekilecek_miqdar * 0.01; 
                balans -= (cekilecek_miqdar + (int)kesintiMiqdari);

                Console.WriteLine("Cekilen mebleg: " + cekilecek_miqdar);
                Console.WriteLine("Kesinti: " + (int)kesintiMiqdari);
                Console.WriteLine("Qalan balans: " + balans);
            }
        }

      public void AddMoney()
        {
            Console.WriteLine("Elave etmek istediyiniz miqdari daxil edin:");
            int artilacaq_pul = Convert.ToInt32(Console.ReadLine());
            balans += artilacaq_pul;
            Console.WriteLine("Yeni Balans: " + balans);
        }

      public void Exit()
        {
            Console.WriteLine("Hesabdan pul chixildi. Xosh gunler!");
        }
    }
}
