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
    class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base() { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqlConnectInit = new SqliteCreateDatabaseIfNotExists<DataBaseContext>(modelBuilder);
            //DataBase.SetInitializer(sqlConnectInit);
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Incidents> Incidents { get; set; }
        public DbSet<DbHistory> History { get; set; }
    }
}
