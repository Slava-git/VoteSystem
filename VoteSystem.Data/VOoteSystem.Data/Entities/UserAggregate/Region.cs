using System;
using System.Collections.Generic;
using System.Text;

namespace VoteSystem.Data.Entities.UserAggregate
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }


    }
}
