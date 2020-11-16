using System;
using System.Collections.Generic;
using System.Text;
using VoteSystem.Data.Entities.UserAggregate;

namespace VoteSystem.Data.Entities.UserAggregate
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PassportCode { get; set; }
        public int IdentificationCode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Region Region { get; set; }
    }
}
