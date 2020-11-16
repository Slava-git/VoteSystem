namespace VoteSystem.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Choice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Poll_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Poll", t => t.Poll_Id, cascadeDelete: true)
                .Index(t => t.Poll_Id);
            
            CreateTable(
                "dbo.Poll",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        PassportCode = c.String(),
                        IdentificationCode = c.Int(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                        Region_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Region", t => t.Region_Id, cascadeDelete: true)
                .Index(t => t.Region_Id);
            
            CreateTable(
                "dbo.Vote",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        voteStart = c.DateTime(nullable: false),
                        voteEnd = c.DateTime(nullable: false),
                        choice_Id = c.Int(),
                        user_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Choice", t => t.choice_Id)
                .ForeignKey("dbo.User", t => t.user_Id)
                .Index(t => t.choice_Id)
                .Index(t => t.user_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vote", "user_Id", "dbo.User");
            DropForeignKey("dbo.Vote", "choice_Id", "dbo.Choice");
            DropForeignKey("dbo.User", "Region_Id", "dbo.Region");
            DropForeignKey("dbo.Choice", "Poll_Id", "dbo.Poll");
            DropIndex("dbo.Vote", new[] { "user_Id" });
            DropIndex("dbo.Vote", new[] { "choice_Id" });
            DropIndex("dbo.User", new[] { "Region_Id" });
            DropIndex("dbo.Choice", new[] { "Poll_Id" });
            DropTable("dbo.Vote");
            DropTable("dbo.User");
            DropTable("dbo.Region");
            DropTable("dbo.Poll");
            DropTable("dbo.Choice");
        }
    }
}
