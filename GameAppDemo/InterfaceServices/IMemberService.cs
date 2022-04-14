using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
        void Update(Member member);
        void Delete(Member member);

    }
}
