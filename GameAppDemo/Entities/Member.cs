using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Entities
{
    public class Member : IEntity
    {
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Balance { get; set; }
    }
}
