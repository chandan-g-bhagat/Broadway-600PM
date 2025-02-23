﻿namespace Broadway.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubjectAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        ClassId = c.Int(),
                        TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.ClassId)
                .Index(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Subjects", "ClassId", "dbo.Classes");
            DropIndex("dbo.Subjects", new[] { "TeacherId" });
            DropIndex("dbo.Subjects", new[] { "ClassId" });
            DropTable("dbo.Subjects");
        }
    }
}
