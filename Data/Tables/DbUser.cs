using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SQLite.CodeFirst;

namespace WinFormSQL.Data.Tables;

[Table("Users")]
public class DbUser
{
	public DbUser()
	{
		Id = Guid.NewGuid();
	}

	[Key] public Guid Id { get; private set; }

	public string FirstName { get; set; }
	public string LastName { get; set; }

	[Unique] public string Login { get; set; }

	public string Password { get; set; }

	public bool Administrator { get; set; }
}