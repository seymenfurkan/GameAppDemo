using GameAppDemo.Abstract;
using GameAppDemo.Entities;
using GameAppDemo.FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Concrete
{
    public class HolidayCampaign : ICampaignService
    {
        Theme theme = new Theme(); 
        public void Add(List<Game> games, Member member)
        {
            theme.Header(member);
            Console.WriteLine("Bayram'a özel tüm oyunlarda %30 indirim!! \n" +
                "Bu fırsatı kaçırma! \n");
            theme.Footer(member);
            HolidayCampaignDiscountManager discountManager = new HolidayCampaignDiscountManager();
            discountManager.DoDiscount(games,member);

        }

        public void Delete(List<Game> games, Member member)
        {
            theme.Header(member);
            Console.WriteLine("Bayram kampanyası sona erdi! \n" + 
                "Kampanya silindi! \n");
            theme.Footer(member);
            HolidayCampaignDiscountManager noDiscountManager = new HolidayCampaignDiscountManager();
            noDiscountManager.NoDiscount(games,member);
           
        }

        public void Update(List<Game> games, Member member)
        {
            theme.Header(member);
            Console.WriteLine("Tüm oyunlarda %30 indirime ek +%10 indirim daha! \n");
            theme.Footer(member);
            HolidayCampaignDiscountManager moreDiscountManager = new HolidayCampaignDiscountManager();
            moreDiscountManager.MoreDiscount(games,member);
        }
    }
}
