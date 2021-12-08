using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormSQL.Data.Tables;

namespace WinFormSQL.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("MyDb") { }

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
