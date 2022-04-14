using GameAppDemo.Abstract;
using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Concrete
{
    public class WinterCampaignDiscountManager : IDiscountManager
    {
        int ListNumber = 1;
        int SelectedItem,SelectedItem2,SelectedItem3;
        string IsApproved;
        public void DoDiscount(List<Game> games, Member member)
        {
            
            foreach (Game _game in games)
            {
                Console.WriteLine(ListNumber + " - " + _game.Name + " --> " + _game.Price + "$");
                ListNumber++;
            }
            Console.WriteLine("Almak istediğiniz 1.Oyunun Numarasını Seçiniz!");
            SelectedItem = Convert.ToInt32(Console.ReadLine());
            double priceOfGame1 = games[SelectedItem - 1].Price;
            
            Console.WriteLine("Almak istediğiniz 2.Oyunun Numarasını Seçiniz!");
            SelectedItem2 = Convert.ToInt32(Console.ReadLine());
            double priceOfGame2 = games[SelectedItem2 - 1].Price;

            Console.WriteLine("Almak istediğiniz 3.Oyunun Numarasını Seçiniz! Unutma bu oyun bizden :))");
            SelectedItem3 = Convert.ToInt32(Console.ReadLine());
            

            double totalPrice = priceOfGame1+ priceOfGame2;

            Console.WriteLine("Seçtiğiniz oyunlar : "+games[SelectedItem-1].Name+" , "+games[SelectedItem2-1].Name+" ve "+games[SelectedItem3-1].Name);
            Console.WriteLine("Toplam Ödenecek Tutar : "+totalPrice+ "$  Onaylıyor musunuz ?  Y | N  ---- ||| ---" + "  Büyük Harfle Seçiniz!");

            IsApproved = Console.ReadLine();
            switch (IsApproved)
            {
                case "Y":
                    Console.WriteLine("Oyunlar satın alındı. Kütüphaneye göz atabilirsin! \n");
                    member.Balance = member.Balance - totalPrice;
                    Console.WriteLine("-------Kalan Bakiye :" + member.Balance + "$-------\n");
                    break;

                case "N":
                    Console.WriteLine("Satın alma işlemi iptal edildi!");
                    break;

                default:
                    break;
            }


        }

        public void MoreDiscount(List<Game> games, Member member)
        {
            
            foreach (Game _game in games)
            {
                double discountedPrice = (_game.Price) - ((_game.Price * 10) / 100);
                discountedPrice = (double)System.Math.Round(discountedPrice, 2);

                Console.WriteLine(ListNumber + " - " + _game.Name + " --> " + _game.Price + "$  YERİNE SADECE "
                    + "--> " + discountedPrice + "$");
                ListNumber++;
            }

            Console.WriteLine("Almak istediğiniz 1.Oyunun Numarasını Seçiniz!");
            SelectedItem = Convert.ToInt32(Console.ReadLine());
            double priceOfGame1 = (games[SelectedItem - 1].Price)-((games[SelectedItem-1].Price*10) / 100);

            Console.WriteLine("Almak istediğiniz 2.Oyunun Numarasını Seçiniz!");
            SelectedItem2 = Convert.ToInt32(Console.ReadLine());
            double priceOfGame2 = (games[SelectedItem2 - 1].Price) - ((games[SelectedItem2 - 1].Price * 10) / 100); ;

            Console.WriteLine("Almak istediğiniz 3.Oyunun Numarasını Seçiniz! Unutma bu oyun bizden :))");
            SelectedItem3 = Convert.ToInt32(Console.ReadLine());


            double totalPrice = priceOfGame1 + priceOfGame2;

            Console.WriteLine("Seçtiğiniz oyunlar : " + games[SelectedItem - 1].Name + " , " + games[SelectedItem2 - 1].Name + " ve " + games[SelectedItem3 - 1].Name);
            Console.WriteLine("Toplam Ödenecek Tutar : " + totalPrice + "$  Onaylıyor musunuz ?  Y | N  ---- ||| ---" + "  Büyük Harfle Seçiniz!");

            IsApproved = Console.ReadLine();
            switch (IsApproved)
            {
                case "Y":
                    Console.WriteLine("Oyunlar satın alındı. Kütüphaneye göz atabilirsin! \n");
                    member.Balance = member.Balance - totalPrice;
                    Console.WriteLine("-------Kalan Bakiye :" + member.Balance + "$-------\n");
                    break;

                case "N":
                    Console.WriteLine("Satın alma işlemi iptal edildi!");
                    break;

                default:
                    break;
            }

        }

        public void NoDiscount(List<Game> games, Member member)
        {
            
            foreach (Game _game in games)
            {
                Console.WriteLine(ListNumber + " - " + _game.Name + " --> " + _game.Price + "$");
                ListNumber++;
            }
            Console.WriteLine("\nAlmak istediğiniz oyunun numarasını giriniz!");
            SelectedItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Almak istediğiniz oyun : > > " +
                games[SelectedItem - 1].Name);
            Console.WriteLine("Ödenecek tutar : " + games[SelectedItem - 1].Price + "$");
            Console.WriteLine("Onaylıyor musunuz ?  Y | N  ---- ||| ---" + "  Büyük Harfle Seçiniz!");
            IsApproved = Console.ReadLine();

            switch (IsApproved)
            {
                case "Y":
                    Console.WriteLine("Oyun satın alındı. Kütüphaneye göz atabilirsin! \n");
                    member.Balance = member.Balance - games[SelectedItem - 1].Price;
                    Console.WriteLine("-------Kalan Bakiye :" + member.Balance + "$-------\n");
                    break;

                case "N":
                    Console.WriteLine("Satın alma işlemi iptal edildi!");
                    break;

                default:
                    break;
            }
        }
    }
}
