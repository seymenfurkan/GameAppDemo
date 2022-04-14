using GameAppDemo.Abstract;
using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Concrete
{
    public class BaseCampaignManager : ICampaignsService
    {
        public void Add(List<Game> games, Member member,ICampaignService campaignService)
        {
            campaignService.Add(games,member);
        }

        public void Delete(List<Game> games, Member member, ICampaignService campaignService)
        {
            campaignService.Delete(games, member);
        }

        public void Update(List<Game> games, Member member, ICampaignService campaignService)
        {
            campaignService.Update(games,member);
        }
    }
}
