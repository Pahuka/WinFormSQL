using SQLite.CodeFirst;
using System.Data.Entity;
using WinFormSQL.Data.Tables;

namespace WinFormSQL.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("localDb2") 
        {
            Database.SetInitializer<DataBaseContext>(new DataBaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqlConnectInit = new SqliteCreateDatabaseIfNotExists<DataBaseContext>(modelBuilder);
            //DataBase.SetInitializer(sqlConnectInit);
        }

        public DbSet<DbUser> Users { get; set; }
        public DbSet<DbIncident> Incidents { get; set; }
        public DbSet<DbHistory> History { get; set; }
    }
}
