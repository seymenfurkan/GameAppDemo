using GameAppDemo.Abstract;
using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;
using System.Globalization;

namespace GameAppDemo.Adapters
{
    public class MernisServiceAdapter : IMemberCheckService
    {
        public bool IsMemberCheck(Member member)
        {
            //Mernis Doğrulama
            var locale = new CultureInfo("tr-TR", false);
            var svc = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            {
                var cmd = svc.TCKimlikNoDogrulaAsync(Convert.ToInt64(member.NationalityId), member.FirstName, member.LastName, member.DateOfBirth.Year);
                return cmd.Result.Body.TCKimlikNoDogrulaResult;
            };

        }
    }
}
