namespace WinFormSQL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class addedtableshistoryandincidents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.History",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IncidentId = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "UniqueAttribute",
                                    new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                                },
                            }),
                        UserId = c.Guid(nullable: false),
                        EditingDate = c.DateTime(nullable: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Incidents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Requisites = c.String(),
                        Author = c.Guid(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Incidents");
            DropTable("dbo.History",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "IncidentId",
                        new Dictionary<string, object>
                        {
                            { "UniqueAttribute", "SQLite.CodeFirst.UniqueAttribute" },
                        }
                    },
                });
        }
    }
}
