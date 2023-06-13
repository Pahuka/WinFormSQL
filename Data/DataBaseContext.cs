using System.Data.Entity;
using SQLite.CodeFirst;
using WinFormSQL.Data.Tables;

namespace WinFormSQL.Data;

public class DataBaseContext : DbContext
{
	public DataBaseContext()
		: base("localDb")
	{
		Database.SetInitializer(new DataBaseInitializer());
	}

	public DbSet<DbUser> Users { get; set; }
	public DbSet<DbIncident> Incidents { get; set; }
	public DbSet<DbHistory> History { get; set; }

	protected override void OnModelCreating(DbModelBuilder modelBuilder)
	{
		var sqlConnectInit = new SqliteCreateDatabaseIfNotExists<DataBaseContext>(modelBuilder);
	}
}