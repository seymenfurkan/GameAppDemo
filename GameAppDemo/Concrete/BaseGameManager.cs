using GameAppDemo.Abstract;
using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Concrete
{
    public class BaseGameManager :  IGameSaleService
    {
        

        public void GameSales(List<Game> games, Member member,ICampaignService campaign)
        {
            // Çalışmasını istediğiniz metodun yorum satırı özelliğini kaldırın

                campaign.Add(games,member);
             // campaign.Update(games, member);
             // campaign.Delete(games, member);

        }
        
    }
}
