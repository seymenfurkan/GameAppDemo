using GameAppDemo.Abstract;
using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Concrete
{
    public class HolidayCampaignDiscountManager : IDiscountManager
    {
        int ListNumber = 1;
        int SelectedItem;
        string IsApproved;
        
        public void DoDiscount( List<Game> games, Member member)
        {
            

            foreach (Game _game in games)
            {
                double discountedPrice = (_game.Price) - ((_game.Price * 30) / 100);
                discountedPrice = (double)System.Math.Round(discountedPrice, 2);

                Console.WriteLine(ListNumber + " - " + _game.Name + " --> " + _game.Price + "$  YERİNE SADECE "
                    +"--> " + discountedPrice+ "$" );
                ListNumber++;

            }

            Console.WriteLine("\nAlmak istediğiniz oyunun numarasını giriniz!");
            SelectedItem = Convert.ToInt32(Console.ReadLine());

            double discountedPriceInSale = (games[SelectedItem - 1].Price) - ((games[SelectedItem - 1].Price * 30) / 100);
            discountedPriceInSale = (double)System.Math.Round(discountedPriceInSale, 2);

            Console.WriteLine("Almak istediğiniz oyun : > > " +
                games[SelectedItem - 1].Name);
            Console.WriteLine("Ödenecek tutar : "+ discountedPriceInSale+"$");
            Console.WriteLine("Onaylıyor musunuz ?  Y | N  ---- ||| ---" + "  Büyük Harfle Seçiniz!");
            IsApproved = Console.ReadLine();

            switch (IsApproved)
            {
                case "Y":
                    Console.WriteLine("Oyun satın alındı. Kütüphaneye göz atabilirsin! \n");
                    member.Balance = member.Balance - discountedPriceInSale;
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
                double discountedPrice = (_game.Price) - ((_game.Price * 30) / 100);
                double newDiscountedPrice = discountedPrice - ((discountedPrice * 10) / 100);
                newDiscountedPrice = (double)System.Math.Round(newDiscountedPrice, 2);

                Console.WriteLine(ListNumber + " - " + _game.Name + " --> " + _game.Price + "$  YERİNE SADECE "
                    + "--> " + newDiscountedPrice + "$");
                ListNumber++;
            }
            Console.WriteLine("\nAlmak istediğiniz oyunun numarasını giriniz!");
            SelectedItem = Convert.ToInt32(Console.ReadLine());

            double discountedPriceInSale = (games[SelectedItem - 1].Price) - ((games[SelectedItem - 1].Price * 30) / 100);
            double newDiscountedPriceInSale = (discountedPriceInSale - ((discountedPriceInSale * 10) / 100));
            newDiscountedPriceInSale = (double)System.Math.Round(newDiscountedPriceInSale, 2);

            Console.WriteLine("Almak istediğiniz oyun : > > " +
                games[SelectedItem - 1].Name);
            Console.WriteLine("Ödenecek tutar : " + newDiscountedPriceInSale + "$");
            Console.WriteLine("Onaylıyor musunuz ?  Y | N  ---- ||| ---" + "  Büyük Harfle Seçiniz!");
            IsApproved = Console.ReadLine();

            switch (IsApproved)
            {
                case "Y":
                    Console.WriteLine("Oyun satın alındı. Kütüphaneye göz atabilirsin! \n");
                    member.Balance = member.Balance - newDiscountedPriceInSale;
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
            int i = 1;
            foreach (Game _game in games)
            {
                Console.WriteLine(i + " - " + _game.Name + " --> " + _game.Price + "$");
                i++;
            }
            Console.WriteLine("\nAlmak istediğiniz oyunun numarasını giriniz!");
            SelectedItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Almak istediğiniz oyun : > > " +
                games[SelectedItem - 1].Name);
            Console.WriteLine("Ödenecek tutar : " + games[SelectedItem-1].Price + "$");
            Console.WriteLine("Onaylıyor musunuz ?  Y | N  ---- ||| ---" + "  Büyük Harfle Seçiniz!");
            IsApproved = Console.ReadLine();

            switch (IsApproved)
            {
                case "Y":
                    Console.WriteLine("Oyun satın alındı. Kütüphaneye göz atabilirsin! \n");
                    member.Balance = member.Balance - games[SelectedItem-1].Price;
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
