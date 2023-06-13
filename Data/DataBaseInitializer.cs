using System.Data.Entity;
using WinFormSQL.Data.Tables;

namespace WinFormSQL.Data;

internal class DataBaseInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
{
	protected override void Seed(DataBaseContext context)
	{
		context.Users.Add(new DbUser
		{
			FirstName = "Administrator",
			LastName = "",
			Login = "admin",
			Password = "admin",
			Administrator = true
		});
		context.SaveChanges();
		base.Seed(context);
	}
}