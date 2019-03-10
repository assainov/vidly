namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES " +
                "(1, 'Action'), " +
                "(2, 'Adventure'), " +
                "(3, 'Comedy'), " +
                "(4, 'Crime'), " +
                "(5, 'Drama'), " +
                "(6, 'Fantasy'), " +
                "(7, 'Historical'), " +
                "(8, 'Horror'), " +
                "(9, 'Mystery'), " +
                "(10, 'Philosophical'), " +
                "(11, 'Romance'), " +
                "(12, 'Satire'), " +
                "(13, 'Sci Fi'), " +
                "(14, 'Thriller'), " +
                "(15, 'Animation'), " +
                "(16, 'Cartoon'), " +
                "(17, 'Western'), " +
                "(18, 'Saga'), " +
                "(19, 'Social'), " +
                "(20, 'Political'), " +
                "(21, 'Family')");
        }
        
        public override void Down()
        {
        }
    }
}
