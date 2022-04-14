using GameAppDemo.Abstract;
using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Concrete
{
    public class BaseMemberManager : IMemberService
    {
        IMemberCheckService _memberCheckService;

        public BaseMemberManager(IMemberCheckService memberCheckService)
        {
            _memberCheckService = memberCheckService;
        }

        public void Add(Member member)
        {
            if (_memberCheckService.IsMemberCheck(member))
            {
                Console.WriteLine(member.FirstName + " İsimli Oyuncu Sisteme Kaydoldu");
            }
            else
            {
                throw new Exception("Kullanıcı Bilgilerini Kontrol Edip Tekrar Deneyin ! ");
            }
        }

        public void Delete(Member member)
        {
            Console.WriteLine(member.FirstName + " İsimli Oyuncu Sistemde Güncellendi");
        }

        public void Update(Member member)
        {
            Console.WriteLine(member.FirstName + " İsimli Oyuncu Sistemden Silindi");
        }

    }
}
