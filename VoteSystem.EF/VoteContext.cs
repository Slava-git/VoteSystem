using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace VoteSystem.EF
{
    public class VoteContext : DbContext
    {
        public DbSet<Choice> Choices { get;set; }
    }
}
