using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Abstract
{
    public interface ICampaignService
    {
        void Add(List<Game> games, Member member);
        void Update(List<Game> games, Member member);
        void Delete(List<Game> games, Member member);
    }
}
