using GameAppDemo.Abstract;
using GameAppDemo.Concrete;
using GameAppDemo.FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Entities
{
    public class WinterCampaign : ICampaignService
    {
        Theme theme = new Theme();
        public void Add(List<Game> games, Member member)
        {
            theme.Header(member);
            Console.WriteLine("Bu kışa özel içinizi ısıtacak indirimler sizleri bekliyor !!!! \n" +
                 "3 AL 2 ÖDE !!!! \n");
            theme.Footer(member);
            WinterCampaignDiscountManager discountManager = new WinterCampaignDiscountManager();
            discountManager.DoDiscount(games,member);

        }

        public void Delete(List<Game> games, Member member)
        {
            theme.Header(member);
            Console.WriteLine("Kış kampanyası sona erdi! \n" +
                "Kampanya silindi \n");
            theme.Footer(member);
            WinterCampaignDiscountManager noDiscountManager =  new WinterCampaignDiscountManager();
            noDiscountManager.NoDiscount(games,member);

        }

        public void Update(List<Game> games, Member member)
        {
            theme.Header(member);
            Console.WriteLine("3 AL 2 ÖDE ürünlerinde +%10 indirim !! \n");
            theme.Footer(member);
            WinterCampaignDiscountManager moreDiscountManager = new WinterCampaignDiscountManager();
            moreDiscountManager.MoreDiscount(games,member);
        }
    }
}
