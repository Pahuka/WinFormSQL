using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;
using WinFormSQL.Data;

namespace WinFormSQL.Migrations;

internal sealed class Configuration : DbMigrationsConfiguration<DataBaseContext>
{
	public Configuration()
	{
		AutomaticMigrationsEnabled = true;
		SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
	}

	protected override void Seed(DataBaseContext context)
	{
		//  This method will be called after migrating to the latest version.

		//  You can use the DbSet<T>.AddOrUpdate() helper extension method
		//  to avoid creating duplicate seed data.
	}
}