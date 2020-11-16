using System;
using System.Collections.Generic;
using System.Text;
using VoteSystem.Data.Entities.UserAggregate;

namespace VoteSystem.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PassportCode { get; set; }
        public int IdentificationCode { get; set; }
        public Region region { get; set; }
        
    }
}
