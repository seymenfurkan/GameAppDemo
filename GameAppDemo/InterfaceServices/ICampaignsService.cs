using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Abstract
{
    public interface ICampaignsService 
    {
        void Add(List<Game> games, Member member, ICampaignService campaignService);
        void Update(List<Game> games, Member member, ICampaignService campaignService);
        void Delete(List<Game> games, Member member, ICampaignService campaignService);
    }
}
