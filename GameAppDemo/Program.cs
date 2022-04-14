using System;
using System.Collections.Generic;
using System.Reflection;
using GameAppDemo.Abstract;
using GameAppDemo.Adapters;
using GameAppDemo.Concrete;
using GameAppDemo.Entities;
using GameAppDemo.FrontEnd;

namespace GameAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member();
            member1.NationalityId = "12345678910";
            member1.FirstName = "Muhammet Furkan";
            member1.LastName = "Seymen";
            member1.DateOfBirth = new DateTime(2000, 4, 1);
            member1.Balance = 500.99;

            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "Counter Strike - Global Offensive";
            game1.Price = 30.99;
            Game game2 = new Game();
            game2.Id = 2;
            game2.Name = "FIFA-2023";
            game2.Price = 50.99;
            Game game3 = new Game();
            game3.Id = 3;
            game3.Name = "Player Unknowns Battle Grounds - PUBG";
            game3.Price = 47.99;
            Game game4 = new Game();
            game4.Id = 4;
            game4.Name = "Grand Theft Auto V - GTA5";
            game4.Price = 90;

            List<Game> games = new List<Game> {game1,game2,game3,game4};

            ICampaignService holidayCampaign = new HolidayCampaign();
            ICampaignService winterCampaign = new WinterCampaign();


            //Çalışmasını istediğiniz metodun yorum satırı özelliğini kaldırın
            

            //////// Kullanıcı Ekleme-Silme-Güncelleme
            //  BaseMemberManager memberManager = new BaseMemberManager(new MernisServiceAdapter());
            //  memberManager.Add(member1);
            //  Console.WriteLine("\n");
            //  memberManager.Delete(member1);
            //  memberManager.Update(member1);


            //////// Kampanya Entegreli Satış Simülasyonu
             BaseGameManager gameManager = new BaseGameManager();
             gameManager.GameSales(games, member1,holidayCampaign);
            /////// Satış ve kampanya güncelleme ekleme metotlarına
            /////// BaseGameManager.cs üzerinden ulaşabilirsiniz



            ///// winterCampaign isimli kampanya operasyonlarına ulaşmak için
            ///// gameManager.GameSales(games,member1,winterCampaign) şeklinde düzeltebilirsiniz..


        }
    }
}
