using GameAppDemo.Abstract;
using GameAppDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Concrete
{
    public class MemberCheckManager : IMemberCheckService
    {
        public bool IsMemberCheck(Member member)
        {

            //Statik doğrulama

            //if (member.FirstName == "Muhammet Furkan" &&
            //    member.LastName == "Seymen" &&
            //    member.DateOfBirth == new DateTime(2000, 4, 1) &&
            //    member.NationalityId == "14389162396")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return true;
        }
    }
}
