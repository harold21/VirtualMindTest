namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUser : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Users (FirstName, LastName, UserName, Password) VALUES (N'Harold', N'Buenaventura', N'HB', N'123123')");
            Sql("INSERT INTO Users (FirstName, LastName, UserName, Password) VALUES (N'Luis', N'Gonzalez', N'LG', N'123123')");
            Sql("INSERT INTO Users (FirstName, LastName, UserName, Password) VALUES (N'Andrea', N'Velazques', N'AV', N'123123')");
        }
        
        public override void Down()
        {
        }
    }
}
