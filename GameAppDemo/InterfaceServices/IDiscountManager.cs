using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Abstract
{
    public interface IDiscountManager
    {
        void DoDiscount(List<Game> games,Member member);
        void NoDiscount(List<Game> games, Member member);

        void MoreDiscount(List<Game> games, Member member);
    }
}
