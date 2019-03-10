namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNameRecordsMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name = 'Pay As You Go' WHERE DurationInMonths = 0");
            Sql("UPDATE MembershipTypes set Name = 'Monthly' WHERE DurationInMonths = 1");
            Sql("UPDATE MembershipTypes set Name = 'Quarterly' WHERE DurationInMonths = 3");
            Sql("UPDATE MembershipTypes set Name = 'Annually' WHERE DurationInMonths = 12");
        }
        
        public override void Down()
        {
        }
    }
}
