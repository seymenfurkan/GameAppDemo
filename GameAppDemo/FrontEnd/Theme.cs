using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.FrontEnd
{
    public class Theme
    {
        public void Header(Member member)
        {
            Console.WriteLine(member.FirstName + " Dükkana Hoş Geldin! Oyunlara Bir Göz At İstersen ! \n");
            Console.WriteLine("                         <<<<<Kampanyalar>>>>>  ");
            Console.WriteLine(
                "________________________________________________________________________\n"
             );
        }
        public void Footer(Member member)
        {
            Console.WriteLine("________________________________________________________________________\n\n");
            Console.WriteLine("-------Satıştaki Oyunlar-------   --------Bakiye: "
                + member.Balance + "$------- \n\n");
        }
    }
}
