using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using VoteSystem.Data.Entities.PollAggregate;
using VoteSystem.Data.Entities.UserAggregate;
using VoteSystem.Data.Entities.VoteAggregate;

namespace VoteSystem.EF
{
    public class VoteContext : DbContext
    {
        public DbSet<Choice> Choices { get;set; }
        public DbSet<Poll> Polls { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vote> Votes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Region>().HasMany(r => r.Users).WithRequired(u => u.Region);

            modelBuilder.Entity<Poll>().HasMany(p => p.Choices).WithRequired(c => c.Poll);

            modelBuilder.Entity<Vote>();
        }
    }
}
