using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Abstract
{
    public interface IGameSaleService
    {
        void GameSales(List<Game> games , Member member, ICampaignService campaign);
    }
}
