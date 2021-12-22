using System.Data.Entity;

namespace WinFormSQL.Data
{
    class DataBaseInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
    {

        protected override void Seed(DataBaseContext context)
        {
            context.Users.Add(new Tables.DbUser() {
            FirstName = "Administrator",
            LastName = "",
            Login = "admin",
            Password = "admin",
            Administrator = true});
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
